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
    public partial class seat : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
        private Dictionary<string, (string Category, string Status)> seatData = new Dictionary<string, (string, string)>();
        private string selectedSeatId = ""; // 선택된 좌석 아이디를 저장할 변수

        public seat()
        {
            InitializeComponent();
            LoadSeatData();
            UpdateSeatButtons();
            LoadUserName(); // 로그인한 사용자 이름 가져오기
        }

        // 로그인한 사용자의 이름을 가져오는 메서드
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
                        command.Parameters.Add(":userId", login.LoggedInUserID);
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            SName.Text = $"{result} 님"; // 라벨에 사용자 이름 출력
                        }
                        else
                        {
                            SName.Text = "사용자 정보 없음";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"사용자 이름을 불러오는 중 오류가 발생했습니다: {ex.Message}");
            }
        }

        private void seat_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("S"))
                {
                    control.Click += new EventHandler(seatButton_Click);
                }
            }
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

                    if (status == "사용중")
                    {
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

        private void seatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string seatId = clickedButton.Name;

                if (selectedSeatId != seatId)
                {
                    if (!string.IsNullOrEmpty(selectedSeatId))
                    {
                        Button previousButton = this.Controls.Find(selectedSeatId, true).FirstOrDefault() as Button;
                        if (previousButton != null)
                        {
                            previousButton.BackColor = Color.LightSteelBlue;
                        }
                    }

                    clickedButton.BackColor = Color.Green;
                    selectedSeatId = seatId;
                }
                else
                {
                    clickedButton.BackColor = Color.LightSteelBlue;
                    selectedSeatId = "";
                }
            }
        }

        private void backSeat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login showlogin = new login();
            showlogin.ShowDialog();
        }

        private void seatOKBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedSeatId))
            {
                this.Visible = false;
                timeSelect showtimeSelect = new timeSelect(selectedSeatId);
                showtimeSelect.ShowDialog();
            }
            else
            {
                MessageBox.Show("좌석을 선택해 주세요.");
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
