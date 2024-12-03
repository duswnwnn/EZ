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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void seatBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seatAdmin showseatAdmin = new seatAdmin();
            showseatAdmin.ShowDialog();
        }

        private void couponBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            couponAdmin showcouponAdmin = new couponAdmin();
            showcouponAdmin.ShowDialog();
        }

        private void userAdminBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            userAdmin showuserAdmin = new userAdmin();
            showuserAdmin.ShowDialog();
        }

        private void seatUseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seatReservationAd showseatReservationAd = new seatReservationAd();
            showseatReservationAd.ShowDialog();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login showlogin = new login();
            showlogin.ShowDialog();
        }

    }
}
