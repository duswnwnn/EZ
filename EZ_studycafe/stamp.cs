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
    public partial class stamp : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        private int stampAmount = 0; // 초기 스탬프 수
        public stamp()
        {
            InitializeComponent();
            LoadStampData();  // 스탬프 데이터 로드
            LoadCouponData(); // 쿠폰 데이터 로드
        }

        // 스탬프 수 로드
        // 스탬프 수 로드 및 사용자 이름 출력
        private void LoadStampData()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 사용자 이름 및 스탬프 수를 가져오는 쿼리
                    string query = "SELECT NAME, STAMP_COUNT FROM \"USER\" WHERE USER_ID = :UserID";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("UserID", login.LoggedInUserID));
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 사용자 이름 및 스탬프 수
                                string userName = reader["NAME"].ToString();
                                stampAmount = reader["STAMP_COUNT"] != DBNull.Value ? Convert.ToInt32(reader["STAMP_COUNT"]) : 0;

                                // StampName에 사용자 이름 출력
                                StampName.Text = $"{userName}님";
                                stampNumber.Text = $"{stampAmount} 개";
                            }
                            else
                            {
                                MessageBox.Show("사용자 데이터를 찾을 수 없습니다.", "오류");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"스탬프 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류");
                }
            }
        }



        // 쿠폰 데이터 로드 (내가 가진 스탬프에 따라 조건을 추가)
        private void LoadCouponData()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT COUPON_CODE_ID, COUPON_NAME, DISCOUNT_AMOUNT, REQUIRED_STAMPS
                FROM COUPON_CODE
                WHERE REQUIRED_STAMPS <= :stampAmount";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("stampAmount", stampAmount));

                        DataTable couponTable = new DataTable();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(couponTable);
                        }

                        stampGrid.DataSource = couponTable.Rows.Count > 0 ? couponTable : null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"쿠폰 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류");
                }
            }
        }

        // 쿠폰 교환 버튼 클릭
        private void couponConversionBtn_Click(object sender, EventArgs e)
        {
            if (stampGrid.SelectedRows.Count > 0) // 쿠폰 선택 여부 확인
            {
                // 선택한 쿠폰 코드 ID 가져오기
                string selectedCouponCodeId = stampGrid.SelectedRows[0].Cells["COUPON_CODE_ID"].Value.ToString();
                string selectedCoupoonRequiredStamp = stampGrid.SelectedRows[0].Cells["REQUIRED_STAMPS"].Value.ToString();

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // 트랜잭션 시작
                        OracleTransaction transaction = connection.BeginTransaction();

                        try
                        {
                            // 1. 스탬프 사용 내역 추가 (STAMP 테이블)
                            string insertStampQuery = @"
                    INSERT INTO STAMP (STAMP_ID, USER_ID, STAMP_AMOUNT, STAMP_TYPE, STAMP_DATE)
                    VALUES (:StampId, :UserId, :StampAmount, '사용', SYSDATE)";
                            using (OracleCommand stampCommand = new OracleCommand(insertStampQuery, connection))
                            {
                                string stampId = Guid.NewGuid().ToString(); // 고유 ID 생성
                                stampCommand.Parameters.Add(new OracleParameter("StampId", stampId));
                                stampCommand.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));
                                stampCommand.Parameters.Add(new OracleParameter("StampAmount", selectedCoupoonRequiredStamp));

                                stampCommand.ExecuteNonQuery();
                            }

                            // 2. 사용자 스탬프 차감
                            string updateUserStampQuery = @"
                    UPDATE ""USER"" 
                    SET STAMP_COUNT = STAMP_COUNT - :StampAmount
                    WHERE USER_ID = :UserId AND STAMP_COUNT >= :StampAmount";
                            using (OracleCommand updateCommand = new OracleCommand(updateUserStampQuery, connection))
                            {
                                updateCommand.Parameters.Add(new OracleParameter("StampAmount", selectedCoupoonRequiredStamp));
                                updateCommand.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    throw new Exception("스탬프가 부족합니다.");
                                }
                            }

                            // 3. COUPON 테이블에 쿠폰 추가
                            string insertCouponQuery = @"
                    INSERT INTO COUPON (COUPON_ID, COUPON_CODE_ID, USER_ID, RECEIVED_DATE, IS_USED, POINT_USAGE_ID)
                    VALUES (:CouponId, :CouponCodeId, :UserId, SYSDATE, 'N', NULL)";
                            using (OracleCommand couponCommand = new OracleCommand(insertCouponQuery, connection))
                            {
                                string couponId = Guid.NewGuid().ToString(); // 고유 ID 생성
                                couponCommand.Parameters.Add(new OracleParameter("CouponId", couponId));
                                couponCommand.Parameters.Add(new OracleParameter("CouponCodeId", selectedCouponCodeId));
                                couponCommand.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                                couponCommand.ExecuteNonQuery();
                            }

                            // 트랜잭션 커밋
                            transaction.Commit();

                            MessageBox.Show("쿠폰 교환이 완료되었습니다.", "성공");
                            LoadStampData(); // 최신 스탬프 데이터 로드
                            LoadCouponData(); // 최신 쿠폰 데이터 로드
                        }
                        catch
                        {
                            // 트랜잭션 롤백
                            transaction.Rollback();
                            throw;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"오류가 발생했습니다: {ex.Message}", "오류");
                    }
                }
            }
            else
            {
                MessageBox.Show("교환할 쿠폰을 선택하세요.", "오류");
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
    }
}