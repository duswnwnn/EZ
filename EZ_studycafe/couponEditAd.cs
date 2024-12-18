﻿using System;
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
    public partial class couponEditAd : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public couponEditAd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 저장 버튼
        {
            string query = @"
        UPDATE COUPON_CODE
        SET 
            COUPON_NAME = :name, 
            DISCOUNT_AMOUNT = :discount, 
            REQUIRED_STAMPS = :stamps
        WHERE COUPON_CODE_ID = :id";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("name", ACouponName.Text);
                        command.Parameters.Add("discount", AdisTextBox.Text);
                        command.Parameters.Add("stamps", ACouponStamp.Text);
                        command.Parameters.Add("id", ACouponNum.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("쿠폰 정보가 수정되었습니다."); // 메시지 표시
                        this.DialogResult = DialogResult.OK; // 수정 완료 상태 반환
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"수정 중 오류 발생: {ex.Message}");
                }
            }
        }
    }
}
