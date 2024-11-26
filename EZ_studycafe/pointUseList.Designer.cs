
namespace EZ_studycafe
{
    partial class pointUseList
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
            this.usingPointList = new System.Windows.Forms.ListView();
            this.USAGE_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POINT_AMOUNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.USAGE_TYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.좌석이용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탬프사용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쿠폰조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포인트충전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탬프사용내역ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.포인트사용내역조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pointUaeName = new System.Windows.Forms.Label();
            this.dateTimePickerP = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usingPointList
            // 
            this.usingPointList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.USAGE_DATE,
            this.POINT_AMOUNT,
            this.USAGE_TYPE});
            this.usingPointList.HideSelection = false;
            this.usingPointList.Location = new System.Drawing.Point(50, 150);
            this.usingPointList.Name = "usingPointList";
            this.usingPointList.Size = new System.Drawing.Size(617, 236);
            this.usingPointList.TabIndex = 93;
            this.usingPointList.UseCompatibleStateImageBehavior = false;
            this.usingPointList.View = System.Windows.Forms.View.Details;
            // 
            // USAGE_DATE
            // 
            this.USAGE_DATE.Text = "사용날짜";
            this.USAGE_DATE.Width = 194;
            // 
            // POINT_AMOUNT
            // 
            this.POINT_AMOUNT.Text = "포인트 수";
            this.POINT_AMOUNT.Width = 152;
            // 
            // USAGE_TYPE
            // 
            this.USAGE_TYPE.Text = "분류";
            this.USAGE_TYPE.Width = 131;
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
            this.menuStrip1.Size = new System.Drawing.Size(714, 30);
            this.menuStrip1.TabIndex = 92;
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
            this.포인트사용내역조회ToolStripMenuItem1.Text = "포인트 사용내역 조회";
            this.포인트사용내역조회ToolStripMenuItem1.Click += new System.EventHandler(this.포인트사용내역조회ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(217, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 91;
            this.label1.Text = "포인트 사용 내역";
            // 
            // pointUaeName
            // 
            this.pointUaeName.AutoSize = true;
            this.pointUaeName.Location = new System.Drawing.Point(47, 116);
            this.pointUaeName.Name = "pointUaeName";
            this.pointUaeName.Size = new System.Drawing.Size(67, 15);
            this.pointUaeName.TabIndex = 94;
            this.pointUaeName.Text = "최연주님";
            // 
            // dateTimePickerP
            // 
            this.dateTimePickerP.Location = new System.Drawing.Point(467, 109);
            this.dateTimePickerP.Name = "dateTimePickerP";
            this.dateTimePickerP.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerP.TabIndex = 95;
            this.dateTimePickerP.ValueChanged += new System.EventHandler(this.dateTimePickerP_ValueChanged);
            // 
            // pointUseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 411);
            this.Controls.Add(this.dateTimePickerP);
            this.Controls.Add(this.pointUaeName);
            this.Controls.Add(this.usingPointList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "pointUseList";
            this.Text = "pointUseList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usingPointList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 좌석이용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스탬프사용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쿠폰조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포인트충전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스탬프사용내역ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 포인트사용내역조회ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader USAGE_DATE;
        private System.Windows.Forms.ColumnHeader POINT_AMOUNT;
        private System.Windows.Forms.ColumnHeader USAGE_TYPE;
        private System.Windows.Forms.Label pointUaeName;
        private System.Windows.Forms.DateTimePicker dateTimePickerP;
    }
}