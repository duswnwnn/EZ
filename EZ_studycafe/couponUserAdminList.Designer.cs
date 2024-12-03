
namespace EZ_studycafe
{
    partial class couponUserAdminList
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
            this.coupinUserAdGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backStamp = new System.Windows.Forms.Label();
            this.couponListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coupinUserAdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // coupinUserAdGridView
            // 
            this.coupinUserAdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coupinUserAdGridView.Location = new System.Drawing.Point(32, 85);
            this.coupinUserAdGridView.Name = "coupinUserAdGridView";
            this.coupinUserAdGridView.RowHeadersWidth = 51;
            this.coupinUserAdGridView.RowTemplate.Height = 27;
            this.coupinUserAdGridView.Size = new System.Drawing.Size(638, 268);
            this.coupinUserAdGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(265, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 115;
            this.label1.Text = "쿠폰리스트";
            // 
            // backStamp
            // 
            this.backStamp.AutoSize = true;
            this.backStamp.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backStamp.Location = new System.Drawing.Point(12, 20);
            this.backStamp.Name = "backStamp";
            this.backStamp.Size = new System.Drawing.Size(33, 30);
            this.backStamp.TabIndex = 116;
            this.backStamp.Text = "<";
            // 
            // couponListBtn
            // 
            this.couponListBtn.Location = new System.Drawing.Point(292, 362);
            this.couponListBtn.Name = "couponListBtn";
            this.couponListBtn.Size = new System.Drawing.Size(109, 34);
            this.couponListBtn.TabIndex = 117;
            this.couponListBtn.Text = "추가";
            this.couponListBtn.UseVisualStyleBackColor = true;
            this.couponListBtn.Click += new System.EventHandler(this.couponListBtn_Click);
            // 
            // couponUserAdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 405);
            this.Controls.Add(this.couponListBtn);
            this.Controls.Add(this.backStamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coupinUserAdGridView);
            this.Name = "couponUserAdminList";
            this.Text = "couponUserAdminList";
            this.Load += new System.EventHandler(this.couponUserAdminList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coupinUserAdGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coupinUserAdGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backStamp;
        private System.Windows.Forms.Button couponListBtn;
    }
}