
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
            this.ACouponName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACouponNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ACouponStamp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.couponOk = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한행삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "쿠폰 종류 관리";
            // 
            // couponGridView
            // 
            this.couponGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponGridView.Location = new System.Drawing.Point(42, 205);
            this.couponGridView.Name = "couponGridView";
            this.couponGridView.RowHeadersWidth = 51;
            this.couponGridView.RowTemplate.Height = 27;
            this.couponGridView.Size = new System.Drawing.Size(666, 212);
            this.couponGridView.TabIndex = 85;
            this.couponGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couponGridView_CellClick);
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
            // couponOk
            // 
            this.couponOk.Location = new System.Drawing.Point(363, 425);
            this.couponOk.Name = "couponOk";
            this.couponOk.Size = new System.Drawing.Size(75, 33);
            this.couponOk.TabIndex = 100;
            this.couponOk.Text = "조회";
            this.couponOk.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.수정ToolStripMenuItem,
            this.선택한행삭제ToolStripMenuItem,
            this.검색ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 100);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.추가ToolStripMenuItem.Text = "추가";
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.수정ToolStripMenuItem.Text = "수정";
            // 
            // 선택한행삭제ToolStripMenuItem
            // 
            this.선택한행삭제ToolStripMenuItem.Name = "선택한행삭제ToolStripMenuItem";
            this.선택한행삭제ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.선택한행삭제ToolStripMenuItem.Text = "삭제";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 95;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 98;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 99;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 101;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // 검색ToolStripMenuItem
            // 
            this.검색ToolStripMenuItem.Name = "검색ToolStripMenuItem";
            this.검색ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.검색ToolStripMenuItem.Text = "검색";
            // 
            // couponAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.couponOk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ACouponStamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button couponOk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한행삭제ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem 검색ToolStripMenuItem;
    }
}