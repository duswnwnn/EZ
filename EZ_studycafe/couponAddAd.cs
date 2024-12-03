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
    public partial class couponAddAd : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public couponAddAd()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string query = @"
        INSERT INTO COUPON_CODE (COUPON_CODE_ID, COUPON_NAME, DISCOUNT_AMOUNT, REQUIRED_STAMPS)
        VALUES (:id, :name, :discount, :stamps)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("id", AddCouponNum.Text);
                        command.Parameters.Add("name", AddCouponName.Text);
                        command.Parameters.Add("discount", disTextBox.Text);
                        command.Parameters.Add("stamps", AddCouponStamp.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("새로운 쿠폰이 추가되었습니다.");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"추가 중 오류 발생: {ex.Message}");
                }
            }
        }
    }
}
