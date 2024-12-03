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
    public partial class couponUserAdmin : Form
    {
        private string userId; // 사용자 ID 변수
        private string userName; // 사용자 이름 변수

        public couponUserAdmin(string userId)
        {
            InitializeComponent();
            this.userId = userId; // 전달된 userId 값 저장
        }

        // 폼 로드 시 사용자 정보를 불러오기
        private void couponUserAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                // 사용자 이름을 가져오는 메서드 호출
                userName = GetUserNameById(userId);

                // CuserNameLabel에 사용자 이름을 출력하고 "님"을 붙여서 출력
                CuserNameLabel.Text = $"{userName}님";

                // 쿠폰 데이터를 DataGridView에 로드
                LoadCouponData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"사용자 정보를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 사용자 ID에 맞는 이름을 데이터베이스에서 가져오는 메서드
        private string GetUserNameById(string userId)
        {
            string name = string.Empty;
            string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NAME FROM \"USER\" WHERE USER_ID = :userId";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("userId", userId));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader.GetString(0); // 사용자 이름 가져오기
                        }
                    }
                }
            }

            return name;
        }

        // 쿠폰 데이터를 DataGridView에 로드
        private void LoadCouponData()
        {
            string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        C.Coupon_ID, 
                        C.Coupon_Code_ID, 
                        CC.Coupon_Name,  -- 쿠폰 이름 추가
                        C.Received_Date, 
                        C.Is_Used
                    FROM 
                        COUPON C
                    JOIN 
                        COUPON_CODE CC ON C.Coupon_Code_ID = CC.Coupon_Code_ID
                    WHERE 
                        C.User_ID = :userId"; // 사용자 ID를 이용하여 데이터 필터링

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("userId", userId));

                        OracleDataReader reader = cmd.ExecuteReader();

                        // DataTable 생성 후 DataGridView에 바인딩
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // DataGridView에 DataTable 설정
                        AcouponDataGridView.DataSource = dt;

                        // DataGridView 컬럼 이름 설정 (필요에 따라)
                        AcouponDataGridView.Columns["Coupon_ID"].HeaderText = "쿠폰 ID";
                        AcouponDataGridView.Columns["Coupon_Code_ID"].HeaderText = "쿠폰 코드";
                        AcouponDataGridView.Columns["Coupon_Name"].HeaderText = "쿠폰 이름";
                        AcouponDataGridView.Columns["Received_Date"].HeaderText = "발급일";
                        AcouponDataGridView.Columns["Is_Used"].HeaderText = "사용 여부";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"쿠폰 데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            // 선택된 행이 있을 때만 삭제 진행
            if (AcouponDataGridView.SelectedRows.Count > 0)
            {
                // 선택된 행에서 첫 번째 행을 가져옴
                DataGridViewRow selectedRow = AcouponDataGridView.SelectedRows[0];

                // 선택된 행의 쿠폰 ID를 가져옴
                string couponId = selectedRow.Cells[0].Value.ToString();  // object -> string으로 변환

                // 데이터베이스에서 해당 쿠폰을 삭제
                bool isDeleted = DeleteCouponFromDatabase(couponId);

                // 데이터베이스에서 삭제가 성공하면 DataGridView에서도 삭제
                if (isDeleted)
                {
                    AcouponDataGridView.Rows.Remove(selectedRow);
                    MessageBox.Show("쿠폰이 성공적으로 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("쿠폰 삭제에 실패했습니다.");
                }
            }
            else
            {
                MessageBox.Show("삭제할 행을 선택해주세요.");
            }
        }
        private bool DeleteCouponFromDatabase(string couponId)
        {
            // 올바른 연결 문자열 사용
            string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

            // 데이터베이스 연결
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL 명령 정의
                    string query = "DELETE FROM COUPON WHERE COUPON_ID = :CouponID";

                    // SQL 명령 실행
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        // @CouponID 매개변수에 쿠폰 ID 값을 할당
                        cmd.Parameters.Add(":CouponID", OracleDbType.Varchar2).Value = couponId;

                        // 삭제 실행
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // 1 이상의 행이 영향을 받았다면 삭제 성공
                        if (rowsAffected > 0)
                        {
                            return true; // 삭제 성공
                        }
                        else
                        {
                            MessageBox.Show("해당 쿠폰을 찾을 수 없습니다.");
                            return false; // 쿠폰이 존재하지 않으면 실패
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 예외 처리: 오류 메시지 출력
                    MessageBox.Show($"쿠폰 삭제 실패: {ex.Message}");
                    return false;
                }
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            // couponUserAdminList 폼을 모달로 열기
            couponUserAdminList couponListForm = new couponUserAdminList(userId);

            // 폼이 닫히고 나면 선택된 쿠폰 정보가 전달되므로, 폼을 닫은 후 처리
            if (couponListForm.ShowDialog() == DialogResult.OK)
            {
                // 선택된 쿠폰 ID를 가져와서 데이터베이스에 추가
                string selectedCouponCodeId = couponListForm.SelectedCouponCodeId;
                AddCouponToUser(selectedCouponCodeId);
            }
        }

        private void AddCouponToUser(string selectedCouponCodeId)
        {
            string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // COUPON 테이블에 데이터를 추가하는 쿼리
                    string query = @"
                    INSERT INTO COUPON (COUPON_ID, COUPON_CODE_ID, USER_ID, RECEIVED_DATE, IS_USED)
                    VALUES (:CouponId, :CouponCodeId, :UserId, CURRENT_TIMESTAMP, 'N')";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        string couponId = Guid.NewGuid().ToString();
                        cmd.Parameters.Add("CouponId", couponId);
                        cmd.Parameters.Add("CouponCodeId", OracleDbType.Varchar2).Value = selectedCouponCodeId;
                        cmd.Parameters.Add("UserId", OracleDbType.Varchar2).Value = userId;

                        // 쿼리 실행
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("쿠폰이 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 데이터 다시 불러오기
                        LoadCouponData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"쿠폰 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

