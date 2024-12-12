using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZ_studycafe
{
    public partial class adminPass : Form
    {
        public adminPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 비밀번호 확인
            if (textBox1.Text == "1111")
            {
                this.Visible = false; // 현재 폼을 숨김
                admin showadmin = new admin();
                showadmin.ShowDialog();
                this.Visible = true; // admin 폼을 닫고 다시 보이도록 설정
            }
            else
            {
                // 잘못된 비밀번호 메시지 표시
                MessageBox.Show("비밀번호가 틀렸습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
