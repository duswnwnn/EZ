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
    public partial class reservationDetail : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        private string userId; // 로그인된 사용자 ID
        private string seatId; // 선택된 좌석 ID

        public reservationDetail(string Category, string useT, string finalP, string seatN)
        {
            InitializeComponent();

            this.userId = login.LoggedInUserID;
            this.seatId = seatN;

            // 사용자 이름 가져오기
            string userName = GetUserName(userId);
            if (!string.IsNullOrEmpty(userName))
            {
                detailName.Text = $"{userName} 님"; // 사용자 이름을 detailName에 설정
            }
            else
            {
                detailName.Text = "사용자 이름 없음"; // 예외 상황 처리
            }

            // 전달받은 데이터를 라벨에 표시
            seatCategory.Text = Category;
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // 현재 시간 출력
            useTime.Text = useT + " 시간";
            finalPoint.Text = finalP + " 포인트";
            seatNumber.Text = seatN + "번";
        }

        // 사용자 이름 조회 메서드
        private string GetUserName(string userId)
        {
            string query = "SELECT NAME FROM \"USER\" WHERE USER_ID = :userId";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("userId", userId));
                    object result = command.ExecuteScalar();
                    return result?.ToString(); // 결과 반환 (null 검사 후 문자열 반환)
                }
            }
        }


        private void ticketOKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int pointsToDeduct = int.Parse(finalPoint.Text.Replace(" 포인트", ""));
                int rentalDuration = int.Parse(useTime.Text.Replace(" 시간", ""));

                // 1. 포인트 사용 기록 생성
                string usageId = CreatePointUsage(userId, pointsToDeduct);

                // 2. 유저 포인트 차감
                DeductUserPoints(userId, pointsToDeduct);

                // 3. 좌석 렌탈 기록 생성
                CreateSeatRentalRecord(userId, seatId, usageId, rentalDuration);

                // 4. 메인 화면으로 이동
                this.Visible = false;
                seat seatForm = new seat(); // 메인 화면 폼
                seatForm.ShowDialog(); // 메인 화면 표시
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CreatePointUsage(string userId, int points)
        {
            string usageId = Guid.NewGuid().ToString(); // 고유 ID 생성
            string query = @"
                INSERT INTO POINT_USAGE (USAGE_ID, USER_ID, POINT_AMOUNT, USAGE_TYPE)
                VALUES (:usageId, :userId, :points, '좌석 렌탈')";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("usageId", usageId));
                    command.Parameters.Add(new OracleParameter("userId", userId));
                    command.Parameters.Add(new OracleParameter("points", points));
                    command.ExecuteNonQuery();
                }
            }

            return usageId;
        }

        private void DeductUserPoints(string userId, int points)
        {
            string query = @"
                UPDATE ""USER""
                SET POINT_BALANCE = POINT_BALANCE - :points
                WHERE USER_ID = :userId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("points", points));
                    command.Parameters.Add(new OracleParameter("userId", userId));
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateSeatRentalRecord(string userId, string seatId, string usageId, int rentalDuration)
        {
            string rentalId = Guid.NewGuid().ToString(); // 고유 ID 생성
            string insertRentalQuery = @"
        INSERT INTO SEAT_RENTAL (RENTAL_ID, USER_ID, SEAT_ID, POINT_USAGE_ID, RENTAL_DURATION)
        VALUES (:rentalId, :userId, :seatId, :usageId, :rentalDuration)";

            string updateSeatStatusQuery = @"
        UPDATE SEAT
        SET SEAT_STATUS = '사용중'
        WHERE SEAT_ID = :seatId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleTransaction transaction = connection.BeginTransaction()) // 트랜잭션 시작
                {
                    try
                    {
                        // 1. SEAT_RENTAL 테이블에 렌탈 데이터 추가
                        using (OracleCommand insertCommand = new OracleCommand(insertRentalQuery, connection))
                        {
                            insertCommand.Parameters.Add(new OracleParameter("rentalId", rentalId));
                            insertCommand.Parameters.Add(new OracleParameter("userId", userId));
                            insertCommand.Parameters.Add(new OracleParameter("seatId", seatId));
                            insertCommand.Parameters.Add(new OracleParameter("usageId", usageId));
                            insertCommand.Parameters.Add(new OracleParameter("rentalDuration", rentalDuration));
                            insertCommand.ExecuteNonQuery();
                        }

                        // 2. SEAT 테이블에서 좌석 상태를 '사용중'으로 업데이트
                        using (OracleCommand updateCommand = new OracleCommand(updateSeatStatusQuery, connection))
                        {
                            updateCommand.Parameters.Add(new OracleParameter("seatId", seatId));
                            updateCommand.ExecuteNonQuery();
                        }

                        transaction.Commit(); // 트랜잭션 커밋
                    }
                    catch
                    {
                        transaction.Rollback(); // 오류 발생 시 롤백
                        throw; // 예외를 다시 던져서 상위 레벨에서 처리
                    }
                }
            }
        }
    }
}
