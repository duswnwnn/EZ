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
    public partial class seatModify : Form
    {
        public seatModify()
        {
            InitializeComponent();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seatAdmin showseatAdmin = new seatAdmin();
            showseatAdmin.ShowDialog();
        }
    }
}
