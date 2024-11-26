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
    public partial class couponAdmin : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public couponAdmin()
        {
            InitializeComponent();
            LoadCoupons(); // 폼 로드 시 쿠폰 데이터를 로드
        }

        private void LoadCoupons()
        {
            string query = @"
                SELECT 
                    COUPON_CODE_ID, 
                    COUPON_NAME, 
                    DISCOUNT_AMOUNT, 
                    REQUIRED_STAMPS 
                FROM COUPON_CODE";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                    {
                        DataTable couponTable = new DataTable();
                        adapter.Fill(couponTable);
                        couponGridView.DataSource = couponTable; // 그리드뷰에 데이터 바인딩
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 로드 중 오류 발생: {ex.Message}");
                }
            }
        }

        private void couponGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 유효한 행 클릭 시
            {
                DataGridViewRow selectedRow = couponGridView.Rows[e.RowIndex];
                ACouponNum.Text = selectedRow.Cells["COUPON_CODE_ID"].Value.ToString(); // 쿠폰 코드
                ACouponName.Text = selectedRow.Cells["COUPON_NAME"].Value.ToString(); // 쿠폰 이름
                ACouponStamp.Text = selectedRow.Cells["REQUIRED_STAMPS"].Value.ToString(); // 필요 스탬프
            }
        }
    }
}
