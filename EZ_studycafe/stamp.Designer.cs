
namespace EZ_studycafe
{
    partial class stamp
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
            this.label1 = new System.Windows.Forms.Label();
            this.stampGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.stampNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.좌석이용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탬프사용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쿠폰조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포인트충전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탬프사용내역ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.포인트사용내역조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.couponConversionBtn = new System.Windows.Forms.Button();
            this.StampName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stampGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(296, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "스탬프 사용";
            // 
            // stampGrid
            // 
            this.stampGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stampGrid.Location = new System.Drawing.Point(76, 200);
            this.stampGrid.Name = "stampGrid";
            this.stampGrid.RowHeadersWidth = 51;
            this.stampGrid.RowTemplate.Height = 27;
            this.stampGrid.Size = new System.Drawing.Size(670, 151);
            this.stampGrid.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "스탬프 개수 : ";
            // 
            // stampNumber
            // 
            this.stampNumber.AutoSize = true;
            this.stampNumber.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stampNumber.Location = new System.Drawing.Point(215, 117);
            this.stampNumber.Name = "stampNumber";
            this.stampNumber.Size = new System.Drawing.Size(31, 19);
            this.stampNumber.TabIndex = 73;
            this.stampNumber.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(72, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "변환 가능 쿠폰 종류";
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
            this.menuStrip1.TabIndex = 82;
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
            // couponConversionBtn
            // 
            this.couponConversionBtn.Location = new System.Drawing.Point(661, 366);
            this.couponConversionBtn.Name = "couponConversionBtn";
            this.couponConversionBtn.Size = new System.Drawing.Size(85, 37);
            this.couponConversionBtn.TabIndex = 83;
            this.couponConversionBtn.Text = "변환하기";
            this.couponConversionBtn.UseVisualStyleBackColor = true;
            this.couponConversionBtn.Click += new System.EventHandler(this.couponConversionBtn_Click);
            // 
            // StampName
            // 
            this.StampName.AutoSize = true;
            this.StampName.Location = new System.Drawing.Point(73, 67);
            this.StampName.Name = "StampName";
            this.StampName.Size = new System.Drawing.Size(67, 15);
            this.StampName.TabIndex = 92;
            this.StampName.Text = "최연주님";
            // 
            // stamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.StampName);
            this.Controls.Add(this.couponConversionBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stampNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stampGrid);
            this.Controls.Add(this.label1);
            this.Name = "stamp";
            this.Text = "stamp";
            ((System.ComponentModel.ISupportInitialize)(this.stampGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stampGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stampNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button couponUseBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 좌석이용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스탬프사용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쿠폰조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포인트충전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스탬프사용내역ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 포인트사용내역조회ToolStripMenuItem1;
        private System.Windows.Forms.Button couponConversionBtn;
        private System.Windows.Forms.ListView coupinList;
        private System.Windows.Forms.Label StampName;
    }
}