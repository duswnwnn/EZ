
namespace EZ_studycafe
{
    partial class couponListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.좌석이용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탬프사용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쿠폰조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포인트충전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탬프사용내역ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.포인트사용내역조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.coupinList = new System.Windows.Forms.ListView();
            this.coupon_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coupon_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coupon_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coupon_is = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.couponName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.좌석이용ToolStripMenuItem,
            this.스탬프사용ToolStripMenuItem,
            this.쿠폰조회ToolStripMenuItem,
            this.포인트충전ToolStripMenuItem,
            this.사용내역ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 좌석이용ToolStripMenuItem
            // 
            this.좌석이용ToolStripMenuItem.Name = "좌석이용ToolStripMenuItem";
            this.좌석이용ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.좌석이용ToolStripMenuItem.Text = "좌석이용";
            this.좌석이용ToolStripMenuItem.Click += new System.EventHandler(this.좌석이용ToolStripMenuItem_Click);
            // 
            // 스탬프사용ToolStripMenuItem
            // 
            this.스탬프사용ToolStripMenuItem.Name = "스탬프사용ToolStripMenuItem";
            this.스탬프사용ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.스탬프사용ToolStripMenuItem.Text = "스탬프 사용";
            this.스탬프사용ToolStripMenuItem.Click += new System.EventHandler(this.스탬프사용ToolStripMenuItem_Click);
            // 
            // 쿠폰조회ToolStripMenuItem
            // 
            this.쿠폰조회ToolStripMenuItem.Name = "쿠폰조회ToolStripMenuItem";
            this.쿠폰조회ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.쿠폰조회ToolStripMenuItem.Text = "쿠폰 조회";
            this.쿠폰조회ToolStripMenuItem.Click += new System.EventHandler(this.쿠폰조회ToolStripMenuItem_Click);
            // 
            // 포인트충전ToolStripMenuItem
            // 
            this.포인트충전ToolStripMenuItem.Name = "포인트충전ToolStripMenuItem";
            this.포인트충전ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.포인트충전ToolStripMenuItem.Text = "포인트 충전";
            this.포인트충전ToolStripMenuItem.Click += new System.EventHandler(this.포인트충전ToolStripMenuItem_Click);
            // 
            // 사용내역ToolStripMenuItem
            // 
            this.사용내역ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.스탬프사용내역ToolStripMenuItem1,
            this.포인트사용내역조회ToolStripMenuItem1});
            this.사용내역ToolStripMenuItem.Name = "사용내역ToolStripMenuItem";
            this.사용내역ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.사용내역ToolStripMenuItem.Text = "사용내역";
            // 
            // 스탬프사용내역ToolStripMenuItem1
            // 
            this.스탬프사용내역ToolStripMenuItem1.Name = "스탬프사용내역ToolStripMenuItem1";
            this.스탬프사용내역ToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.스탬프사용내역ToolStripMenuItem1.Text = "스탬프 사용 내역 조회";
            this.스탬프사용내역ToolStripMenuItem1.Click += new System.EventHandler(this.스탬프사용내역ToolStripMenuItem1_Click);
            // 
            // 포인트사용내역조회ToolStripMenuItem1
            // 
            this.포인트사용내역조회ToolStripMenuItem1.Name = "포인트사용내역조회ToolStripMenuItem1";
            this.포인트사용내역조회ToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.포인트사용내역조회ToolStripMenuItem1.Text = "포인트 사용 내역 조회";
            this.포인트사용내역조회ToolStripMenuItem1.Click += new System.EventHandler(this.포인트사용내역조회ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(287, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "보유 쿠폰 내역";
            // 
            // coupinList
            // 
            this.coupinList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coupon_id,
            this.coupon_name,
            this.coupon_time,
            this.coupon_is});
            this.coupinList.GridLines = true;
            this.coupinList.HideSelection = false;
            this.coupinList.Location = new System.Drawing.Point(87, 109);
            this.coupinList.Name = "coupinList";
            this.coupinList.Size = new System.Drawing.Size(610, 254);
            this.coupinList.TabIndex = 86;
            this.coupinList.UseCompatibleStateImageBehavior = false;
            this.coupinList.View = System.Windows.Forms.View.Details;
            // 
            // coupon_id
            // 
            this.coupon_id.Text = "쿠폰ID";
            this.coupon_id.Width = 150;
            // 
            // coupon_name
            // 
            this.coupon_name.Text = "쿠폰이름";
            this.coupon_name.Width = 122;
            // 
            // coupon_time
            // 
            this.coupon_time.Text = "발급일";
            this.coupon_time.Width = 229;
            // 
            // coupon_is
            // 
            this.coupon_is.Text = "사용여부";
            this.coupon_is.Width = 150;
            // 
            // couponName
            // 
            this.couponName.AutoSize = true;
            this.couponName.Location = new System.Drawing.Point(84, 73);
            this.couponName.Name = "couponName";
            this.couponName.Size = new System.Drawing.Size(67, 15);
            this.couponName.TabIndex = 92;
            this.couponName.Text = "최연주님";
            // 
            // couponListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.couponName);
            this.Controls.Add(this.coupinList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "couponListView";
            this.Text = "couponListView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 좌석이용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스탬프사용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쿠폰조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포인트충전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스탬프사용내역ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 포인트사용내역조회ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView coupinList;
        private System.Windows.Forms.ColumnHeader coupon_id;
        private System.Windows.Forms.ColumnHeader coupon_name;
        private System.Windows.Forms.ColumnHeader coupon_time;
        private System.Windows.Forms.ColumnHeader coupon_is;
        private System.Windows.Forms.Label couponName;
    }
}