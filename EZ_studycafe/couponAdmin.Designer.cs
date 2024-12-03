
namespace EZ_studycafe
{
    partial class couponAdmin
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
            this.components = new System.ComponentModel.Container();
            this.backSeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.couponGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한행삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ACouponName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACouponNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ACouponStamp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crystalBtn = new System.Windows.Forms.Button();
            this.eliminationBtn = new System.Windows.Forms.Button();
            this.additionalBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.couponGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backSeat
            // 
            this.backSeat.AutoSize = true;
            this.backSeat.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backSeat.Location = new System.Drawing.Point(16, 18);
            this.backSeat.Name = "backSeat";
            this.backSeat.Size = new System.Drawing.Size(33, 30);
            this.backSeat.TabIndex = 84;
            this.backSeat.Text = "<";
            this.backSeat.Click += new System.EventHandler(this.backSeat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "쿠폰 종류 관리";
            // 
            // couponGridView
            // 
            this.couponGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.couponGridView.Location = new System.Drawing.Point(42, 205);
            this.couponGridView.Name = "couponGridView";
            this.couponGridView.RowHeadersWidth = 51;
            this.couponGridView.RowTemplate.Height = 27;
            this.couponGridView.Size = new System.Drawing.Size(666, 212);
            this.couponGridView.TabIndex = 85;
            this.couponGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couponGridView_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.수정ToolStripMenuItem,
            this.선택한행삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 76);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.추가ToolStripMenuItem_Click);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.수정ToolStripMenuItem_Click);
            // 
            // 선택한행삭제ToolStripMenuItem
            // 
            this.선택한행삭제ToolStripMenuItem.Name = "선택한행삭제ToolStripMenuItem";
            this.선택한행삭제ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.선택한행삭제ToolStripMenuItem.Text = "삭제";
            this.선택한행삭제ToolStripMenuItem.Click += new System.EventHandler(this.선택한행삭제ToolStripMenuItem_Click);
            // 
            // ACouponName
            // 
            this.ACouponName.Location = new System.Drawing.Point(142, 116);
            this.ACouponName.Name = "ACouponName";
            this.ACouponName.Size = new System.Drawing.Size(170, 25);
            this.ACouponName.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 93;
            this.label3.Text = "쿠폰이름";
            // 
            // ACouponNum
            // 
            this.ACouponNum.Location = new System.Drawing.Point(142, 74);
            this.ACouponNum.Name = "ACouponNum";
            this.ACouponNum.Size = new System.Drawing.Size(170, 25);
            this.ACouponNum.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "쿠폰번호";
            // 
            // ACouponStamp
            // 
            this.ACouponStamp.Location = new System.Drawing.Point(142, 160);
            this.ACouponStamp.Name = "ACouponStamp";
            this.ACouponStamp.Size = new System.Drawing.Size(170, 25);
            this.ACouponStamp.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 96;
            this.label4.Text = "필요 스탬프";
            // 
            // crystalBtn
            // 
            this.crystalBtn.Location = new System.Drawing.Point(543, 163);
            this.crystalBtn.Name = "crystalBtn";
            this.crystalBtn.Size = new System.Drawing.Size(75, 33);
            this.crystalBtn.TabIndex = 95;
            this.crystalBtn.Text = "수정";
            this.crystalBtn.UseVisualStyleBackColor = true;
            this.crystalBtn.Click += new System.EventHandler(this.crystalBtn_Click);
            // 
            // eliminationBtn
            // 
            this.eliminationBtn.Location = new System.Drawing.Point(633, 163);
            this.eliminationBtn.Name = "eliminationBtn";
            this.eliminationBtn.Size = new System.Drawing.Size(75, 33);
            this.eliminationBtn.TabIndex = 98;
            this.eliminationBtn.Text = "삭제";
            this.eliminationBtn.UseVisualStyleBackColor = true;
            this.eliminationBtn.Click += new System.EventHandler(this.eliminationBtn_Click);
            // 
            // additionalBtn
            // 
            this.additionalBtn.Location = new System.Drawing.Point(447, 163);
            this.additionalBtn.Name = "additionalBtn";
            this.additionalBtn.Size = new System.Drawing.Size(75, 33);
            this.additionalBtn.TabIndex = 99;
            this.additionalBtn.Text = "추가";
            this.additionalBtn.UseVisualStyleBackColor = true;
            this.additionalBtn.Click += new System.EventHandler(this.additionalBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(633, 68);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 33);
            this.searchBtn.TabIndex = 101;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(447, 74);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 25);
            this.searchTextBox.TabIndex = 102;
            // 
            // couponAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 448);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.additionalBtn);
            this.Controls.Add(this.eliminationBtn);
            this.Controls.Add(this.ACouponStamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crystalBtn);
            this.Controls.Add(this.ACouponName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ACouponNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.couponGridView);
            this.Controls.Add(this.backSeat);
            this.Controls.Add(this.label1);
            this.Name = "couponAdmin";
            this.Text = "couponAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.couponGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView couponGridView;
        private System.Windows.Forms.TextBox ACouponName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ACouponNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ACouponStamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한행삭제ToolStripMenuItem;
        private System.Windows.Forms.Button crystalBtn;
        private System.Windows.Forms.Button eliminationBtn;
        private System.Windows.Forms.Button additionalBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}