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
    public partial class userAdmin : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public userAdmin()
        {
            InitializeComponent();
            InitializeUserListView();
            LoadUserData();
        }

        // ListView 초기화 설정
        private void InitializeUserListView()
        {
            userListView.View = View.Details;
            userListView.FullRowSelect = true;
            userListView.GridLines = true;

            // 열 추가
            userListView.Columns.Add("아이디", 100);
            userListView.Columns.Add("이름", 100);
            userListView.Columns.Add("전화번호", 150);
            userListView.Columns.Add("포인트", 80);
            userListView.Columns.Add("스탬프", 80);
        }

        // 사용자 데이터 로드
        private void LoadUserData(string searchKeyword = "")
        {
            try
            {
                userListView.Items.Clear(); // 기존 데이터 초기화
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT USER_ID, NAME, PHONE, POINT_BALANCE, STAMP_COUNT FROM \"USER\"";
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += " WHERE USER_ID LIKE :search OR NAME LIKE :search OR PHONE LIKE :search";
                    }

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchKeyword))
                        {
                            cmd.Parameters.Add(new OracleParameter("search", $"%{searchKeyword}%"));
                        }

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // 데이터 읽기
                                string userId = reader.GetString(0);
                                string name = reader.GetString(1);
                                string phone = reader.GetString(2);
                                int points = Convert.ToInt32(reader.GetDecimal(3)); // 수정된 부분
                                int stamps = Convert.ToInt32(reader.GetDecimal(4)); // 수정된 부분

                                // ListView에 추가
                                ListViewItem item = new ListViewItem(userId);
                                item.SubItems.Add(name);
                                item.SubItems.Add(phone);
                                item.SubItems.Add(points.ToString());
                                item.SubItems.Add(stamps.ToString());
                                userListView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 검색 버튼 클릭 이벤트
        private void userSearchBtn_Click(object sender, EventArgs e)
        {
            string searchKeyword = userTextBox.Text.Trim();
            LoadUserData(searchKeyword); // 검색어로 데이터 로드
        }

        private void stampManageBtn_Click(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("사용자를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 선택된 행의 데이터 가져오기
            var selectedItem = userListView.SelectedItems[0];
            string userName = selectedItem.SubItems[1].Text; // NAME
            int stampCount = int.Parse(selectedItem.SubItems[4].Text); // STAMP_COUNT

            // stampAdmin 폼에 데이터 전달
            stampAdmin adminForm = new stampAdmin(userName, stampCount);
            adminForm.ShowDialog();
        }

        private void backSeat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            admin showadmin = new admin();
            showadmin.ShowDialog();
        }
    }
}