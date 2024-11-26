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
    public partial class couponModal : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        // 선택된 쿠폰 아이디를 부모 폼으로 전달하기 위한 이벤트
        public event EventHandler<CouponEventArgs> CouponSelected;

        public couponModal()
        {
            InitializeComponent();
            LoadCouponData();
        }

        private void LoadCouponData()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT C.Coupon_ID, C.Coupon_Code_ID, CC.Coupon_Name, C.Received_Date, C.Is_Used, CC.DISCOUNT_AMOUNT
                    FROM COUPON C
                    JOIN COUPON_CODE CC ON C.Coupon_Code_ID = CC.Coupon_Code_ID
                    WHERE C.User_ID = :UserID"; // User_ID는 현재 로그인한 사용자의 ID로 바꿔야 합니다.

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("UserID", login.LoggedInUserID)); // 로그인한 사용자 ID 사용

                        OracleDataReader reader = command.ExecuteReader();

                        // ListView 초기화
                        coupinList.Items.Clear();  // 이전 데이터 초기화
                        coupinList.Columns.Clear(); // 컬럼 초기화
                        coupinList.Columns.Add("쿠폰 ID", 100);
                        coupinList.Columns.Add("쿠폰 코드", 100);
                        coupinList.Columns.Add("쿠폰 이름", 150);
                        coupinList.Columns.Add("발급일", 120);
                        coupinList.Columns.Add("사용 여부", 80);
                        coupinList.Columns.Add("할인 금액", 100); // 추가된 컬럼

                        // 데이터 읽어서 ListView에 추가
                        while (reader.Read())
                        {
                            string couponID = reader["Coupon_ID"].ToString();
                            string couponCode = reader["Coupon_Code_ID"].ToString();
                            string couponName = reader["Coupon_Name"].ToString();
                            string receivedDate = reader["Received_Date"].ToString();
                            string isUsed = reader["Is_Used"].ToString() == "Y" ? "사용됨" : "미사용";
                            string discountAmount = reader["DISCOUNT_AMOUNT"].ToString();

                            ListViewItem item = new ListViewItem(new[] { couponID, couponCode, couponName, receivedDate, isUsed, discountAmount });
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

        // 쿠폰 선택 버튼 클릭 이벤트
        private void selectCouponBtn_Click(object sender, EventArgs e)
        {
            if (coupinList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = coupinList.SelectedItems[0];
                string couponID = selectedItem.SubItems[0].Text;
                string discountAmountStr = selectedItem.SubItems[5].Text;
                decimal discountAmount = 0;

                if (decimal.TryParse(discountAmountStr, out discountAmount))
                {
                    CouponEventArgs args = new CouponEventArgs(couponID, discountAmount);
                    CouponSelected?.Invoke(this, args); // 이벤트 발생하여 부모 폼에 전달
                    this.Close(); // 모달 닫기
                }
                else
                {
                    MessageBox.Show("할인 금액을 읽을 수 없습니다.", "오류");
                }
            }
            else
            {
                MessageBox.Show("쿠폰을 선택해주세요.", "오류");
            }
        }

        // 뒤로 가기 버튼 클릭 이벤트
        private void backCoupon_Click(object sender, EventArgs e)
        {
            this.Close(); // 모달 창 닫기
        }

        // 쿠폰 사용 버튼 클릭 이벤트
        private void couponUseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            stamp showstamp = new stamp();
            showstamp.ShowDialog();
        }
    }

    // 쿠폰 선택 이벤트를 전달할 클래스
    public class CouponEventArgs : EventArgs
    {
        public string CouponID { get; set; }
        public decimal DiscountAmount { get; set; }

        public CouponEventArgs(string couponID, decimal discountAmount)
        {
            CouponID = couponID;
            DiscountAmount = discountAmount;
        }
    }
}
