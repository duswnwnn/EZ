using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.DataAccess.Client;

namespace EZ_studycafe
{
    public partial class join : Form
    {
        public join()
        {
            InitializeComponent();
        }

        private void joinOKBtn_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);

            string name = joinName.Text;
            string phoneNumber = joinPhone.Text;
            string password = joinPass.Text;

                try
                {
                    conn.Open();
                    string query = "INSERT INTO \"USER\" (USER_ID, NAME, PHONE, PASSWORD, POINT_BALANCE, STAMP_COUNT) " +
                                   "VALUES (:userID, :name, :phoneNumber, :password, 0, 0)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        string userId = Guid.NewGuid().ToString();
                        cmd.Parameters.Add(":userID", userId);
                        cmd.Parameters.Add(":name", name);
                        cmd.Parameters.Add(":phoneNumber", phoneNumber);
                        cmd.Parameters.Add(":password", password);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                        // 회원가입 성공 시 user.sql 파일에 추가 기록
                        string filePath = @"c:\hong\user.sql"; // 원하는 절대 경로로 수정
                        File.AppendAllText(filePath, $"INSERT INTO \"USER\" (USER_ID, NAME, PHONE, PASSWORD, STAMP_COUNT) VALUES('{userId}', '{name}', '{phoneNumber}', '{password}', 0);\n");

                        //File.AppendAllText("user.sql", $"INSERT INTO \"USER\" (USER_ID, NAME, PHONE, PASSWORD, STAMP_COUNT) VALUES('{userId}', '{name}', '{phoneNumber}', '{password}', 0);\n");

                        MessageBox.Show("회원가입 성공!");
                            this.Visible = false;
                            login showmain = new login();
                            showmain.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("회원가입 실패! 다시 시도해주세요.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB 연결 오류: " + ex.Message);
                }
            }

        private void backJoin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login showmain = new login();
            showmain.ShowDialog();
        }
    }
}