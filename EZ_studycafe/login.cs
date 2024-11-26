using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;

namespace EZ_studycafe
{
    public partial class login : Form
    {
        // Oracle Connection 설정
        private string connectionString = "Data Source=localhost;User Id=scott;Password=tiger;";

        public static string LoggedInUserID; // 정적 변수 추가

        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string phoneNumber = userPhone.Text;
            string password = userPass.Text;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // USER 테이블의 PHONE 및 PASSWORD 컬럼명을 정확히 일치시킵니다.
                    string query = "SELECT USER_ID FROM \"USER\" WHERE PHONE = :phoneNumber AND PASSWORD = :password";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(":phoneNumber", phoneNumber);
                        cmd.Parameters.Add(":password", password);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            LoggedInUserID = result.ToString(); // 로그인한 사용자 ID 저장

                            this.Visible = false;
                            seat showseat = new seat();
                            showseat.ShowDialog();
                            this.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("로그인 실패! 전화번호와 비밀번호를 확인하세요.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB 연결 오류: " + ex.Message);
                }
            }
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            join showjoin = new join();
            showjoin.ShowDialog();
            this.Visible = true;
        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminPass showadminPass = new adminPass();
            showadminPass.ShowDialog();
        }
    }
}