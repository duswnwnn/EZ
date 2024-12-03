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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query;
            string searchText = searchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                query = @"
                SELECT 
                    COUPON_CODE_ID, 
                    COUPON_NAME, 
                    DISCOUNT_AMOUNT, 
                    REQUIRED_STAMPS 
                FROM COUPON_CODE";
            }
            else
            {
                query = $@"
                SELECT 
                    COUPON_CODE_ID, 
                    COUPON_NAME, 
                    DISCOUNT_AMOUNT, 
                    REQUIRED_STAMPS 
                FROM COUPON_CODE
                WHERE COUPON_NAME LIKE '%{searchText}%'";
            }

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                    {
                        DataTable couponTable = new DataTable();
                        adapter.Fill(couponTable);
                        couponGridView.DataSource = couponTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"검색 중 오류 발생: {ex.Message}");
                }
            }
        }
        private void eliminationBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void crystalBtn_Click(object sender, EventArgs e)
        {
            EditSelectedRow();
        }

        private void additionalBtn_Click(object sender, EventArgs e)
        {
            AddNewCoupon();
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 추가 작업 수행
            AddNewCoupon();
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 그리드 선택 상태 확인
            if (couponGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 행을 선택해주세요."); // 선택되지 않았을 경우 메시지 표시
                return;
            }

            EditSelectedRow(); // 선택 상태 확인 후 호출
        }

        private void 선택한행삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 삭제 작업 수행
            DeleteSelectedRow();

        }

        private void AddNewCoupon()
        {
            using (couponAddAd addForm = new couponAddAd())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("추가가 완료되었습니다."); // 추가 완료 메시지
                    LoadCoupons(); // 추가 후 데이터 갱신
                }
            }
        }


        private void EditSelectedRow()
        {
            if (couponGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 행을 선택해주세요."); // 선택하지 않았을 때만 메시지 표시
                return; // 작업 중단
            }

            // 선택된 행의 데이터 가져오기
            DataGridViewRow selectedRow = couponGridView.SelectedRows[0];
            string couponId = selectedRow.Cells["COUPON_CODE_ID"].Value.ToString();
            string couponName = selectedRow.Cells["COUPON_NAME"].Value.ToString();
            string discount = selectedRow.Cells["DISCOUNT_AMOUNT"].Value.ToString();
            string stamps = selectedRow.Cells["REQUIRED_STAMPS"].Value.ToString();

            // 수정 폼 열기
            using (couponEditAd editForm = new couponEditAd
            {
                ACouponNum = { Text = couponId },
                ACouponName = { Text = couponName },
                AdisTextBox = { Text = discount },
                ACouponStamp = { Text = stamps }
            })
            {
                if (editForm.ShowDialog() == DialogResult.OK) // 수정 완료 시
                {
                    // 메시지는 couponEditAd에서만 표시하도록 제거
                    LoadCoupons(); // 데이터 갱신
                }
            }

            // 추가 메시지를 출력하지 않음
        }
        private void DeleteSelectedRow()
        {
            if (couponGridView.SelectedRows.Count > 0)
            {
                string selectedCouponId = couponGridView.SelectedRows[0].Cells["COUPON_CODE_ID"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "정말로 선택한 쿠폰을 삭제하시겠습니까?",
                    "삭제 확인",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM COUPON_CODE WHERE COUPON_CODE_ID = '{selectedCouponId}'";

                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (OracleCommand command = new OracleCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("삭제가 완료되었습니다."); // 삭제 완료 메시지
                                LoadCoupons(); // 삭제 후 데이터 갱신
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"삭제 중 오류 발생: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 행을 선택해주세요."); // 선택하지 않은 경우만 표시
            }
        }

        private void backSeat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            admin showAdmin = new admin();
            showAdmin.ShowDialog();
        }
    }
}
