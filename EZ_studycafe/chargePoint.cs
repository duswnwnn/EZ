using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace EZ_studycafe
{
    public partial class chargePoint : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
        private int currentPoint = 0;

        public chargePoint()
        {
            InitializeComponent();
            LoadUserPoint(); // 포인트 로드 메소드 호출
            InitializeEvents(); // 이벤트 초기화
        }

        // 유저 포인트를 로드하여 rcPoint 라벨에 표시하는 메소드
        private void LoadUserPoint()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 현재 로그인한 유저의 ID를 기준으로 이름과 포인트 가져오기
                    string query = @"
            SELECT NAME, POINT_BALANCE
            FROM ""USER""
            WHERE USER_ID = :UserId";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 사용자 이름과 포인트 값 가져오기
                                string userName = reader.GetString(0); // 첫 번째 열은 이름

                                // 두 번째 열은 포인트. GetDecimal로 처리.
                                decimal pointBalance = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1); // DBNull 확인 후 값 가져오기
                                currentPoint = (int)pointBalance; // 포인트는 정수로 처리 (소수점 버림)

                                // chargeName 라벨에 사용자 이름 표시
                                chargeName.Text = $"{userName} 님";

                                // rcPoint 라벨에 포인트 표시
                                rcPoint.Text = $"{currentPoint} Point";
                            }
                            else
                            {
                                rcPoint.Text = "포인트 정보를 불러올 수 없습니다.";
                                currentPoint = 0; // 실패 시 0으로 초기화
                                chargeName.Text = "회원 정보를 불러올 수 없습니다."; // 실패 시 메시지 출력
                            }
                        }
                    }
                }
                catch (OracleException ex)
                {
                    // OracleException을 잡아서 정확한 오류 메시지 출력
                    MessageBox.Show($"오류 발생: {ex.Message}", "오류");
                }
                catch (Exception ex)
                {
                    // 일반적인 예외 처리
                    MessageBox.Show($"포인트 정보를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }

        // 이벤트 초기화
        private void InitializeEvents()
        {
            chargeValue.TextChanged += ChargeValue_TextChanged;
        }

        // chargeValue 입력 시 발생하는 이벤트
        private void ChargeValue_TextChanged(object sender, EventArgs e)
        {
            // chargeValue에 숫자가 입력되었는지 확인
            if (int.TryParse(chargeValue.Text, out int chargeAmount))
            {
                // currentPoint와 입력 값을 더해서 afterPoint에 출력
                int afterValue = currentPoint + chargeAmount;
                afterPoint.Text = $"{afterValue} Point";

                // reqPrice에 입력된 값 표시
                reqPrice.Text = $"{chargeAmount} 원";
            }
            else
            {
                // 숫자가 아닌 경우 초기화
                afterPoint.Text = $"{currentPoint} Point";
                reqPrice.Text = "0 원";
            }
        }
        private void 좌석이용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seat showseat = new seat();
            showseat.ShowDialog();
        }

        private void 스탬프사용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            stamp showstamp = new stamp();
            showstamp.ShowDialog();
        }

        private void 쿠폰조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            couponListView showcouponListView = new couponListView();
            showcouponListView.ShowDialog();
        }

        private void 포인트충전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            chargePoint showchargePoint = new chargePoint();
            showchargePoint.ShowDialog();
        }

        private void 스탬프사용내역ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            stampUseList showstampUseList = new stampUseList();
            showstampUseList.ShowDialog();
        }

        private void 포인트사용내역조회ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pointUseList showpointUseList = new pointUseList();
            showpointUseList.ShowDialog();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            // 1. 포인트 유세이지 데이터 추가
            string paymentMethod = cashBtn.Checked ? "현금" : cardBtn.Checked ? "카드" : null;
            if (paymentMethod == null)
            {
                MessageBox.Show("결제 수단을 선택하세요.", "오류");
                return;
            }

            if (!int.TryParse(chargeValue.Text, out int chargeAmount) || chargeAmount <= 0)
            {
                MessageBox.Show("유효한 충전 금액을 입력하세요.", "오류");
                return;
            }

            string usageId = Guid.NewGuid().ToString(); // 유세이지 ID 생성
            string usageType = "충전"; // 유세이지 타입: 충전
            DateTime usageDate = DateTime.Now;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        // 1.1 포인트 유세이지 데이터 삽입
                        string insertUsageQuery = @"
                    INSERT INTO POINT_USAGE (USAGE_ID, USER_ID, USAGE_TYPE, POINT_AMOUNT, USAGE_DATE)
                    VALUES (:UsageId, :UserId, :UsageType, :PointAmount, :UsageDate)";

                        using (OracleCommand cmd = new OracleCommand(insertUsageQuery, connection))
                        {
                            cmd.Parameters.Add(new OracleParameter("UsageId", usageId));
                            cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));
                            cmd.Parameters.Add(new OracleParameter("UsageType", usageType));
                            cmd.Parameters.Add(new OracleParameter("PointAmount", chargeAmount));
                            cmd.Parameters.Add(new OracleParameter("UsageDate", usageDate));

                            cmd.ExecuteNonQuery();
                        }

                        // 1.2 페이먼트 데이터 삽입
                        string paymentId = Guid.NewGuid().ToString(); // 결제 ID 생성
                        string insertPaymentQuery = @"
                    INSERT INTO PAYMENT (PAYMENT_ID, POINT_USAGE_ID, PAYMENT_METHOD, PAYMENT_AMOUNT, PAYMENT_DATE)
                    VALUES (:PaymentId, :UsageId, :PaymentMethod, :PaymentAmount, :PaymentDate)";

                        using (OracleCommand cmd = new OracleCommand(insertPaymentQuery, connection))
                        {
                            cmd.Parameters.Add(new OracleParameter("PaymentId", paymentId));
                            cmd.Parameters.Add(new OracleParameter("UsageId", usageId));
                            cmd.Parameters.Add(new OracleParameter("PaymentMethod", paymentMethod));
                            cmd.Parameters.Add(new OracleParameter("PaymentAmount", chargeAmount));
                            cmd.Parameters.Add(new OracleParameter("PaymentDate", usageDate));

                            cmd.ExecuteNonQuery();
                        }

                        // 1.3 유저 테이블 포인트 업데이트
                        string updateUserPointQuery = @"
                    UPDATE ""USER""
                    SET POINT_BALANCE = POINT_BALANCE + :ChargeAmount
                    WHERE USER_ID = :UserId";

                        using (OracleCommand cmd = new OracleCommand(updateUserPointQuery, connection))
                        {
                            cmd.Parameters.Add(new OracleParameter("ChargeAmount", chargeAmount));
                            cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit(); // 모든 작업이 성공적으로 완료되었으면 커밋
                        MessageBox.Show("포인트 충전이 완료되었습니다.", "성공");

                        // UI 업데이트
                        LoadUserPoint();
                        afterPoint.Text = "";
                        chargeValue.Clear();
                        reqPrice.Text = "0 원";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"결제 처리 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }
    }
}
