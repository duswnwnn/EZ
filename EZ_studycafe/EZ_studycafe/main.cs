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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            join showjoin = new join();
            showjoin.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seat showseat = new seat();
            showseat.ShowDialog();
        }
    }
}
