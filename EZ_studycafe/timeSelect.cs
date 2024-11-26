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
    public partial class timeSelect : Form
    {
        private string selectedSeatId;
        private string selectedCouponID; // 선택된 쿠폰 ID
        private decimal discountAmount;  // 쿠폰 할인 금액

        // 데이터베이스 연결 문자열
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public timeSelect(string seatId)
        {
            InitializeComponent();
            selectedSeatId = seatId;
        }

        // 뒤로 가기 버튼 클릭 이벤트
        private void backTicket_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seat showseat = new seat();
            showseat.ShowDialog();
        }

        // 시간 입력 시 needPoint 라벨 업데이트
        private void inputTime_TextChanged(object sender, EventArgs e)
        {
            // 시간 값이 올바른지 확인하고 포인트 계산
            if (int.TryParse(inputTime.Text, out int inputTimeValue))
            {
                // 입력한 시간 * 1000 값을 needPoint 라벨에 출력
                needPoint.Text = (inputTimeValue * 1000).ToString();
            }
            else
            {
                // 입력값이 유효하지 않으면 "입력값이 유효하지 않습니다."를 출력
                needPoint.Text = "입력값이 유효하지 않습니다.";
            }
        }

        // 쿠폰 모달 버튼 클릭 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            couponModal showcouponModal = new couponModal();
            showcouponModal.CouponSelected += CouponModal_CouponSelected; // 이벤트 구독
            showcouponModal.ShowDialog();
        }

        // 쿠폰 선택 시 실행되는 이벤트 핸들러
        private void CouponModal_CouponSelected(object sender, CouponEventArgs e)
        {
            selectedCouponID = e.CouponID; // 선택된 쿠폰 ID 저장
            discountAmount = e.DiscountAmount; // 쿠폰 할인 금액 저장
            LoadCouponDetails(selectedCouponID); // 쿠폰 세부 정보 로드
        }

        // 쿠폰 정보를 데이터베이스에서 가져오는 함수
        private void LoadCouponDetails(string couponID)
        {
            string couponName = "";

            // 데이터베이스 연결하여 쿠폰 이름 가져오기
            string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT CC.Coupon_Name
                        FROM COUPON C
                        JOIN COUPON_CODE CC ON C.Coupon_Code_ID = CC.Coupon_Code_ID
                        WHERE C.Coupon_ID = :CouponID";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("CouponID", couponID));
                        OracleDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            couponName = reader["Coupon_Name"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"쿠폰 정보를 불러오는 데 실패했습니다: {ex.Message}", "오류");
                }
            }

            // 쿠폰 이름 라벨에 표시
            couponTitle.Text = couponName;

            // 필요 포인트에서 할인된 포인트 반영
            UpdateRequiredPoints(discountAmount);
        }

        // 필요 포인트에서 쿠폰 할인 포인트 차감하여 반영
        private void UpdateRequiredPoints(decimal discountAmount)
        {
            decimal currentRequiredPoints = Convert.ToDecimal(needPoint.Text); // 현재 필요 포인트
            decimal newRequiredPoints = currentRequiredPoints - discountAmount;

            if (newRequiredPoints < 0)
            {
                newRequiredPoints = 0; // 필요 포인트가 0 미만으로 내려가지 않도록 설정
            }

            needPoint.Text = newRequiredPoints.ToString("F0"); // 업데이트된 필요 포인트 라벨에 반영
        }
        // 현재 로그인한 사용자의 포인트를 불러와 myPoint 라벨에 출력
        private void LoadUserPoints()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT POINT_BALANCE FROM \"USER\" WHERE USER_ID = :userId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("UserID", login.LoggedInUserID)); // 로그인한 사용자 ID 사용

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            myPoint.Text = result.ToString();
                        }
                        else
                        {
                            myPoint.Text = "사용자 정보를 찾을 수 없습니다.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"포인트를 가져오는 중 오류가 발생했습니다: {ex.Message}");
            }
        }
        // 현재 로그인한 사용자의 이름을 불러와 timeName 라벨에 출력
        private void LoadUserName()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT NAME FROM \"USER\" WHERE USER_ID = :userId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("UserID", login.LoggedInUserID)); // 로그인한 사용자 ID 사용

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            timeName.Text = result.ToString(); // timeName 라벨에 사용자 이름 표시
                        }
                        else
                        {
                            timeName.Text = "사용자 정보를 찾을 수 없습니다.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"사용자 이름을 가져오는 중 오류가 발생했습니다: {ex.Message}");
            }
        }

        // 폼 로드 시 사용자의 이름을 불러오기
        private void timeSelect_Load(object sender, EventArgs e)
        {
            LoadUserName(); // 사용자 이름 로드
            LoadUserPoints(); // 사용자 포인트 로드
        }

        private void ticketOKBtn_Click(object sender, EventArgs e)
        {
            // 선택된 좌석 정보 및 입력된 데이터를 전달
            string seatCategoryName = GetSeatCategoryName(selectedSeatId); // 좌석 카테고리 이름 가져오기
            string inputTimeValue = inputTime.Text; // 입력 시간
            string finalPointValue = needPoint.Text; // 최종 포인트
            string seatNumber = GetSeatNumber(selectedSeatId); // 좌석 번호 (예: S1 -> 1번)

            // reservationDetail 폼으로 데이터 전달 및 폼 열기
            this.Visible = false;
            reservationDetail detailForm = new reservationDetail(seatCategoryName, inputTimeValue, finalPointValue, seatNumber);
            detailForm.ShowDialog();
        }

        // 선택한 좌석의 카테고리 이름 가져오기
        private string GetSeatCategoryName(string seatId)
        {
            string categoryName = "";
            string query = @"
        SELECT SC.CATEGORY_NAME
        FROM SEAT S
        JOIN SEAT_CATEGORY SC ON S.CATEGORY_ID = SC.CATEGORY_ID
        WHERE S.SEAT_ID = :seatId";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open(); // 연결 확인
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // 파라미터 설정
                        command.Parameters.Add(new OracleParameter("seatId", new string(seatId.Where(char.IsDigit).ToArray())));

                        // 쿼리 실행
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            categoryName = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Seat ID '{seatId}'에 해당하는 카테고리가 없습니다.", "정보");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 오류 디버깅 메시지
                MessageBox.Show($"카테고리 이름을 가져오는 중 오류 발생: {ex.Message}", "오류");
            }

            return categoryName;
        }

        // 좌석 번호 가져오기 (예: S1 -> 1번)
        private string GetSeatNumber(string seatId)
        {
            // 좌석 ID에서 숫자 부분만 추출
            return new string(seatId.Where(char.IsDigit).ToArray());
        }
    }
}