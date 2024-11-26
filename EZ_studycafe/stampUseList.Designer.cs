
namespace EZ_studycafe
{
    partial class stampUseList
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
            this.usingStampList = new System.Windows.Forms.ListView();
            this.STAMP_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STAMP_AMOUNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STAMP_TYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stampUseName = new System.Windows.Forms.Label();
            this.dateTimePickerC = new System.Windows.Forms.DateTimePicker();
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
            this.menuStrip1.Size = new System.Drawing.Size(705, 28);
            this.menuStrip1.TabIndex = 89;
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
            this.label1.Location = new System.Drawing.Point(218, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 88;
            this.label1.Text = "스탬프 사용 내역";
            // 
            // usingStampList
            // 
            this.usingStampList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STAMP_DATE,
            this.STAMP_AMOUNT,
            this.STAMP_TYPE});
            this.usingStampList.HideSelection = false;
            this.usingStampList.Location = new System.Drawing.Point(41, 149);
            this.usingStampList.Name = "usingStampList";
            this.usingStampList.Size = new System.Drawing.Size(617, 236);
            this.usingStampList.TabIndex = 90;
            this.usingStampList.UseCompatibleStateImageBehavior = false;
            this.usingStampList.View = System.Windows.Forms.View.Details;
            // 
            // STAMP_DATE
            // 
            this.STAMP_DATE.Text = "사용날짜";
            this.STAMP_DATE.Width = 173;
            // 
            // STAMP_AMOUNT
            // 
            this.STAMP_AMOUNT.Text = "스탬프 수";
            this.STAMP_AMOUNT.Width = 134;
            // 
            // STAMP_TYPE
            // 
            this.STAMP_TYPE.Text = "분류";
            this.STAMP_TYPE.Width = 132;
            // 
            // stampUseName
            // 
            this.stampUseName.AutoSize = true;
            this.stampUseName.Location = new System.Drawing.Point(38, 118);
            this.stampUseName.Name = "stampUseName";
            this.stampUseName.Size = new System.Drawing.Size(67, 15);
            this.stampUseName.TabIndex = 91;
            this.stampUseName.Text = "최연주님";
            // 
            // dateTimePickerC
            // 
            this.dateTimePickerC.Location = new System.Drawing.Point(458, 118);
            this.dateTimePickerC.Name = "dateTimePickerC";
            this.dateTimePickerC.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerC.TabIndex = 92;
            this.dateTimePickerC.ValueChanged += new System.EventHandler(this.dateTimePickerC_ValueChanged);
            // 
            // stampUseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 413);
            this.Controls.Add(this.dateTimePickerC);
            this.Controls.Add(this.stampUseName);
            this.Controls.Add(this.usingStampList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "stampUseList";
            this.Text = "stampUseList";
            this.Load += new System.EventHandler(this.stampUseList_Load);
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
        private System.Windows.Forms.ListView usingStampList;
        private System.Windows.Forms.ColumnHeader STAMP_DATE;
        private System.Windows.Forms.ColumnHeader STAMP_AMOUNT;
        private System.Windows.Forms.ColumnHeader STAMP_TYPE;
        private System.Windows.Forms.Label stampUseName;
        private System.Windows.Forms.DateTimePicker dateTimePickerC;
    }
}