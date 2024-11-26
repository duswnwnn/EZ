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
    public partial class pointUseList : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public pointUseList()
        {
            InitializeComponent();
            LoadPointUsage();
            LoadUserName();  // 유저 이름을 로드하는 메서드 추가
        }

        // 유저의 이름을 데이터베이스에서 불러오는 메서드
        private void LoadUserName()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 현재 로그인한 유저의 이름을 가져오는 쿼리
                    string query = @"
                    SELECT NAME
                    FROM ""USER""
                    WHERE USER_ID = :UserId";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userName = reader["NAME"].ToString();
                                pointUaeName.Text = $"{userName} 님"; // pointUseName은 이름을 표시할 TextBox 또는 Label
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"유저 이름을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }

        private void LoadPointUsage()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 유저 ID를 기반으로 포인트 사용 내역 가져오기
                    string query = @"
                    SELECT USAGE_DATE, POINT_AMOUNT, USAGE_TYPE
                    FROM POINT_USAGE
                    WHERE USER_ID = :UserId
                    ORDER BY USAGE_DATE DESC";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // 리스트뷰 초기화
                            usingPointList.Items.Clear();

                            while (reader.Read())
                            {
                                // 각 행 데이터를 리스트뷰 항목으로 추가
                                ListViewItem item = new ListViewItem(Convert.ToDateTime(reader["USAGE_DATE"]).ToString("yyyy-MM-dd HH:mm:ss")); // 첫 번째 컬럼: 날짜
                                item.SubItems.Add(reader["POINT_AMOUNT"].ToString()); // 두 번째 컬럼: 포인트 수
                                item.SubItems.Add(reader["USAGE_TYPE"].ToString());  // 세 번째 컬럼: 분류

                                usingPointList.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"포인트 사용 내역을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }
        private void dateTimePickerP_ValueChanged(object sender, EventArgs e)
        {
            // 사용자가 선택한 날짜 가져오기
            DateTime selectedDate = dateTimePickerP.Value.Date; // 날짜만 비교를 위해 시간 부분 제외

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 선택한 날짜에 해당하는 포인트 사용 내역 가져오기
                    string query = @"
            SELECT USAGE_DATE, POINT_AMOUNT, USAGE_TYPE
            FROM POINT_USAGE
            WHERE USER_ID = :UserId
            AND TRUNC(USAGE_DATE) = :SelectedDate
            ORDER BY USAGE_DATE DESC";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));
                        cmd.Parameters.Add(new OracleParameter("SelectedDate", selectedDate));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // 리스트뷰 초기화
                            usingPointList.Items.Clear();

                            while (reader.Read())
                            {
                                // 각 행 데이터를 리스트뷰 항목으로 추가
                                ListViewItem item = new ListViewItem(Convert.ToDateTime(reader["USAGE_DATE"]).ToString("yyyy-MM-dd HH:mm:ss")); // 첫 번째 컬럼: 날짜
                                item.SubItems.Add(reader["POINT_AMOUNT"].ToString()); // 두 번째 컬럼: 포인트 수
                                item.SubItems.Add(reader["USAGE_TYPE"].ToString());  // 세 번째 컬럼: 분류

                                usingPointList.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"포인트 사용 내역을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
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