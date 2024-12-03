
namespace EZ_studycafe
{
    partial class couponUserAdmin
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
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CuserNameLabel = new System.Windows.Forms.Label();
            this.backStamp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AcouponDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AcouponDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(557, 385);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 33);
            this.addBtn.TabIndex = 121;
            this.addBtn.Text = "추가";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(651, 385);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 33);
            this.delBtn.TabIndex = 120;
            this.delBtn.Text = "삭제";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(53, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 118;
            this.label3.Text = "현재 쿠폰 : ";
            // 
            // CuserNameLabel
            // 
            this.CuserNameLabel.AutoSize = true;
            this.CuserNameLabel.Location = new System.Drawing.Point(54, 89);
            this.CuserNameLabel.Name = "CuserNameLabel";
            this.CuserNameLabel.Size = new System.Drawing.Size(67, 15);
            this.CuserNameLabel.TabIndex = 116;
            this.CuserNameLabel.Text = "최연주님";
            // 
            // backStamp
            // 
            this.backStamp.AutoSize = true;
            this.backStamp.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backStamp.Location = new System.Drawing.Point(27, 30);
            this.backStamp.Name = "backStamp";
            this.backStamp.Size = new System.Drawing.Size(33, 30);
            this.backStamp.TabIndex = 115;
            this.backStamp.Text = "<";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 114;
            this.label1.Text = "쿠폰관리";
            // 
            // AcouponDataGridView
            // 
            this.AcouponDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcouponDataGridView.Location = new System.Drawing.Point(32, 168);
            this.AcouponDataGridView.Name = "AcouponDataGridView";
            this.AcouponDataGridView.RowHeadersWidth = 51;
            this.AcouponDataGridView.RowTemplate.Height = 27;
            this.AcouponDataGridView.Size = new System.Drawing.Size(694, 197);
            this.AcouponDataGridView.TabIndex = 122;
            // 
            // couponUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 430);
            this.Controls.Add(this.AcouponDataGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuserNameLabel);
            this.Controls.Add(this.backStamp);
            this.Controls.Add(this.label1);
            this.Name = "couponUserAdmin";
            this.Text = "couponUserAdmin";
            this.Load += new System.EventHandler(this.couponUserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcouponDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CuserNameLabel;
        private System.Windows.Forms.Label backStamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AcouponDataGridView;
    }
}