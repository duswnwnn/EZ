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
    public partial class admin : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
        private Dictionary<string, (string Category, string Status)> seatData = new Dictionary<string, (string, string)>();

        public admin()
        {
            InitializeComponent();
            LoadSeatData();
            UpdateSeatButtons();
        }

        private void LoadSeatData()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT SEAT.SEAT_ID, SEAT_CATEGORY.CATEGORY_NAME, SEAT.SEAT_STATUS
                        FROM SEAT
                        JOIN SEAT_CATEGORY
                        ON SEAT.CATEGORY_ID = SEAT_CATEGORY.CATEGORY_ID";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seatId = reader["SEAT_ID"].ToString();
                            string category = reader["CATEGORY_NAME"].ToString();
                            string status = reader["SEAT_STATUS"].ToString();

                            seatData[seatId] = (category, status);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"좌석 데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}");
            }
        }
        private void UpdateSeatButtons()
        {
            int personalSeatsUsed = 0;  // 개인석 사용 중인 좌석 수
            int personalSeatsTotal = 0; // 개인석 총 좌석 수
            int meetingRoomSeatsUsed = 0;  // 회의룸 사용 중인 좌석 수
            int meetingRoomSeatsTotal = 0; // 회의룸 총 좌석 수

            for (int i = 1; i <= 19; i++)
            {
                string seatId = i.ToString();
                string buttonName = $"S{seatId}";
                Button seatButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (seatButton != null && seatData.ContainsKey(seatId))
                {
                    string category = seatData[seatId].Category;
                    string status = seatData[seatId].Status;

                    seatButton.Text = category;

                    // 개인석과 회의룸의 사용중인 좌석 수 계산
                    if (category == "개인석")
                    {
                        personalSeatsTotal++;
                        if (status == "사용중")
                        {
                            personalSeatsUsed++;
                            seatButton.Enabled = false;
                            seatButton.BackColor = Color.IndianRed;
                            seatButton.Text += "\n(사용중)";
                        }
                        else if (status == "사용가능")
                        {
                            seatButton.Enabled = true;
                            seatButton.BackColor = Color.LightSteelBlue;
                        }
                    }
                    else if (category == "회의룸")
                    {
                        meetingRoomSeatsTotal++;
                        if (status == "사용중")
                        {
                            meetingRoomSeatsUsed++;
                            seatButton.Enabled = false;
                            seatButton.BackColor = Color.IndianRed;
                            seatButton.Text += "\n(사용중)";
                        }
                        else if (status == "사용가능")
                        {
                            seatButton.Enabled = true;
                            seatButton.BackColor = Color.LightSteelBlue;
                        }
                    }
                }
            }

            // label3에 개인석 사용 중인 좌석 수와 총 좌석 수 출력
            label3.Text = $"개인석: {personalSeatsUsed} / {personalSeatsTotal}";

            // label4에 회의룸 사용 중인 좌석 수와 총 좌석 수 출력
            label4.Text = $"회의룸: {meetingRoomSeatsUsed} / {meetingRoomSeatsTotal}";
        }
        private void seatBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seatAdmin showseatAdmin = new seatAdmin();
            showseatAdmin.ShowDialog();
        }

        private void couponBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            couponAdmin showcouponAdmin = new couponAdmin();
            showcouponAdmin.ShowDialog();
        }

        private void userAdminBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            userAdmin showuserAdmin = new userAdmin();
            showuserAdmin.ShowDialog();
        }

        private void seatUseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seatReservationAd showseatReservationAd = new seatReservationAd();
            showseatReservationAd.ShowDialog();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login showlogin = new login();
            showlogin.ShowDialog();
        }
    }
}
