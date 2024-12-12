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
    public partial class stampUseList : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public stampUseList()
        {
            InitializeComponent();
            LoadStampUsage();
            LoadUserName(); // 추가된 부분: 사용자 이름 로드
        }

        private void LoadStampUsage(DateTime? selectedDate = null)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 기본 쿼리
                    string query = @"
            SELECT STAMP_AMOUNT, STAMP_TYPE, STAMP_DATE 
            FROM STAMP 
            WHERE USER_ID = :UserId";

                    // 날짜가 선택된 경우 조건 추가
                    if (selectedDate.HasValue)
                    {
                        query += " AND TRUNC(STAMP_DATE) = :SelectedDate";
                    }

                    query += " ORDER BY STAMP_DATE DESC";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                        if (selectedDate.HasValue)
                        {
                            cmd.Parameters.Add(new OracleParameter("SelectedDate", selectedDate.Value.Date));
                        }

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // 리스트뷰 초기화
                            usingStampList.Items.Clear();

                            while (reader.Read())
                            {
                                // 각 행 데이터를 리스트뷰 항목으로 추가
                                ListViewItem item = new ListViewItem(Convert.ToDateTime(reader["STAMP_DATE"]).ToString("yyyy-MM-dd HH:mm:ss"));
                                item.SubItems.Add(reader["STAMP_AMOUNT"].ToString()); // 첫 번째 컬럼
                                item.SubItems.Add(reader["STAMP_TYPE"].ToString()); // 두 번째 컬럼

                                usingStampList.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"스탬프 사용 내역을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }

        // dateTimePickerC의 날짜 변경 이벤트 핸들러
        private void dateTimePickerC_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerC.Value;
            LoadStampUsage(selectedDate);
        }


        // 로그인된 사용자 이름을 가져와서 stampUseName에 표시
        private void LoadUserName()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 사용자 이름을 가져오는 쿼리
                    string query = @"
                    SELECT NAME
                    FROM ""USER""
                    WHERE USER_ID = :UserId";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("UserId", login.LoggedInUserID));

                        // 사용자 이름을 읽어서 stampUseName에 설정
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            stampUseName.Text = $"{result} 님"; // stampUseName는 텍스트 박스 혹은 레이블 컨트롤이어야 함
                        }
                        else
                        {
                            MessageBox.Show("사용자 이름을 찾을 수 없습니다.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"사용자 이름을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }
        private void loadStampBtn_Click(object sender, EventArgs e)
        {
            // 날짜 선택 초기화
            dateTimePickerC.Value = DateTime.Today; // 오늘 날짜로 초기화

            // 전체 리스트를 로드
            LoadStampUsage(); // 날짜 필터 없이 모든 스탬프 사용 내역을 불러옵니다.
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

        private void stampUseList_Load(object sender, EventArgs e)
        {
        }
    }
}
