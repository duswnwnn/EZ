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
    public partial class couponUserAdminList : Form
    {
        private string userId;
        public string SelectedCouponCodeId { get; private set; } // 선택된 쿠폰 코드 ID를 저장하는 속성

        public couponUserAdminList(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        // 폼 로드 시 전체 쿠폰 리스트를 불러오는 메서드
        private void couponUserAdminList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCouponData(); // 전체 쿠폰 데이터를 로드
            }
            catch (Exception ex)
            {
                MessageBox.Show($"쿠폰 데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 전체 쿠폰 데이터를 DataGridView에 로드
        private void LoadCouponData()
        {
            string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        COUPON_CODE_ID, 
                        COUPON_NAME, 
                        DISCOUNT_AMOUNT AS 할인률, 
                        REQUIRED_STAMPS AS 필요스탬프
                    FROM 
                        COUPON_CODE";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();

                        // DataTable 생성 후 DataGridView에 바인딩
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        coupinUserAdGridView.DataSource = dt;

                        // DataGridView 컬럼 이름 설정
                        coupinUserAdGridView.Columns["COUPON_CODE_ID"].HeaderText = "쿠폰 ID";
                        coupinUserAdGridView.Columns["COUPON_NAME"].HeaderText = "쿠폰 이름";
                        coupinUserAdGridView.Columns["할인률"].HeaderText = "할인률";
                        coupinUserAdGridView.Columns["필요스탬프"].HeaderText = "필요 스탬프";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"쿠폰 데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 쿠폰을 선택하고 '쿠폰 선택' 버튼을 클릭했을 때
        private void couponListBtn_Click(object sender, EventArgs e)
        {
            // DataGridView에서 선택된 행이 있는지 확인
            if (coupinUserAdGridView.SelectedRows.Count > 0)
            {
                // 선택된 행에서 쿠폰 코드 ID 가져오기
                SelectedCouponCodeId = coupinUserAdGridView.SelectedRows[0].Cells["COUPON_CODE_ID"].Value.ToString();
                this.DialogResult = DialogResult.OK; // 선택된 쿠폰 정보가 있으므로 OK 반환
                this.Close(); // 폼 닫기
            }
            else
            {
                MessageBox.Show("쿠폰을 선택해 주세요.", "선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
