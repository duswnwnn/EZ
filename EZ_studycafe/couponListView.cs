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
    public partial class couponListView : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public couponListView()
        {
            InitializeComponent();
            LoadCouponData();  // 쿠폰 데이터 로드
            LoadUserName();    // 로그인한 사용자의 이름을 표시
        }

        // 로그인한 사용자의 이름을 가져와서 couponName에 표시
        private void LoadUserName()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 사용자 이름을 가져오는 쿼리
                    string query = "SELECT NAME FROM \"USER\" WHERE USER_ID = :UserID";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("UserID", login.LoggedInUserID));
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userName = reader["NAME"].ToString();
                                couponName.Text = $"{userName} 님"; // couponName은 사용자 이름을 표시할 Label
                            }
                            else
                            {
                                MessageBox.Show("사용자 데이터를 찾을 수 없습니다.", "오류");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"사용자 이름을 불러오는데 실패했습니다: {ex.Message}", "오류");
                }
            }
        }

        private void LoadCouponData()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
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
                    C.User_ID = :UserID"; // 사용자 이름을 제외한 쿠폰 정보 조회

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // 로그인한 사용자 ID를 파라미터로 전달
                        command.Parameters.Add(new OracleParameter("UserID", login.LoggedInUserID));

                        OracleDataReader reader = command.ExecuteReader();

                        // ListView 초기화
                        coupinList.Items.Clear();  // 이전 데이터 초기화
                        coupinList.Columns.Clear(); // 컬럼 초기화
                        coupinList.Columns.Add("쿠폰 ID", 100);
                        coupinList.Columns.Add("쿠폰 코드", 100);
                        coupinList.Columns.Add("쿠폰 이름", 100);  // 쿠폰 이름 컬럼 추가
                        coupinList.Columns.Add("발급일", 120);
                        coupinList.Columns.Add("사용 여부", 80);

                        // 데이터 읽어서 ListView에 추가
                        while (reader.Read())
                        {
                            string couponID = reader["Coupon_ID"].ToString();
                            string couponCode = reader["Coupon_Code_ID"].ToString();
                            string couponName = reader["Coupon_Name"].ToString();  // 쿠폰 이름
                            string receivedDate = reader["Received_Date"].ToString();
                            string isUsed = reader["Is_Used"].ToString() == "Y" ? "사용됨" : "미사용";

                            ListViewItem item = new ListViewItem(new[] { couponID, couponCode, couponName, receivedDate, isUsed });
                            coupinList.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"쿠폰 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류");
                }
            }
        }

        // 기존 코드 (다른 메뉴 클릭 시 폼 전환 등)
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
