
namespace EZ_studycafe
{
    partial class couponModal
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
            this.couponUseBtn = new System.Windows.Forms.Button();
            this.backCoupon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coupinList = new System.Windows.Forms.ListView();
            this.coupon_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coupon_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coupon_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coupon_is = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // couponUseBtn
            // 
            this.couponUseBtn.BackColor = System.Drawing.Color.DarkGray;
            this.couponUseBtn.Location = new System.Drawing.Point(553, 349);
            this.couponUseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.couponUseBtn.Name = "couponUseBtn";
            this.couponUseBtn.Size = new System.Drawing.Size(106, 36);
            this.couponUseBtn.TabIndex = 81;
            this.couponUseBtn.Text = "사용하기";
            this.couponUseBtn.UseVisualStyleBackColor = false;
            this.couponUseBtn.Click += new System.EventHandler(this.selectCouponBtn_Click);
            // 
            // backCoupon
            // 
            this.backCoupon.AutoSize = true;
            this.backCoupon.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backCoupon.Location = new System.Drawing.Point(25, 20);
            this.backCoupon.Name = "backCoupon";
            this.backCoupon.Size = new System.Drawing.Size(33, 30);
            this.backCoupon.TabIndex = 68;
            this.backCoupon.Text = "<";
            this.backCoupon.Click += new System.EventHandler(this.backCoupon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 67;
            this.label1.Text = "쿠폰사용";
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
            this.coupinList.Location = new System.Drawing.Point(40, 77);
            this.coupinList.Name = "coupinList";
            this.coupinList.Size = new System.Drawing.Size(610, 254);
            this.coupinList.TabIndex = 87;
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
            // couponModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 408);
            this.Controls.Add(this.coupinList);
            this.Controls.Add(this.couponUseBtn);
            this.Controls.Add(this.backCoupon);
            this.Controls.Add(this.label1);
            this.Name = "couponModal";
            this.Text = "coupon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button couponUseBtn;
        private System.Windows.Forms.Label backCoupon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView coupinList;
        private System.Windows.Forms.ColumnHeader coupon_id;
        private System.Windows.Forms.ColumnHeader coupon_name;
        private System.Windows.Forms.ColumnHeader coupon_time;
        private System.Windows.Forms.ColumnHeader coupon_is;
    }
}