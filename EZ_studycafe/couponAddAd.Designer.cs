
namespace EZ_studycafe
{
    partial class couponAddAd
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCouponStamp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCouponName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCouponNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(337, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 113;
            this.addButton.Text = "적용";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(133, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 112;
            this.label1.Text = "쿠폰 추가";
            // 
            // AddCouponStamp
            // 
            this.AddCouponStamp.Location = new System.Drawing.Point(176, 213);
            this.AddCouponStamp.Name = "AddCouponStamp";
            this.AddCouponStamp.Size = new System.Drawing.Size(170, 25);
            this.AddCouponStamp.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(44, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 110;
            this.label4.Text = "필요 스탬프";
            // 
            // AddCouponName
            // 
            this.AddCouponName.Location = new System.Drawing.Point(176, 133);
            this.AddCouponName.Name = "AddCouponName";
            this.AddCouponName.Size = new System.Drawing.Size(170, 25);
            this.AddCouponName.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(41, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 108;
            this.label3.Text = "쿠폰이름";
            // 
            // AddCouponNum
            // 
            this.AddCouponNum.Location = new System.Drawing.Point(176, 91);
            this.AddCouponNum.Name = "AddCouponNum";
            this.AddCouponNum.Size = new System.Drawing.Size(170, 25);
            this.AddCouponNum.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "쿠폰번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(44, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "할인률";
            // 
            // disTextBox
            // 
            this.disTextBox.Location = new System.Drawing.Point(176, 174);
            this.disTextBox.Name = "disTextBox";
            this.disTextBox.Size = new System.Drawing.Size(170, 25);
            this.disTextBox.TabIndex = 115;
            // 
            // couponAddAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 308);
            this.Controls.Add(this.disTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCouponStamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddCouponName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddCouponNum);
            this.Controls.Add(this.label2);
            this.Name = "couponAddAd";
            this.Text = "couponAddAd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCouponStamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddCouponName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddCouponNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox disTextBox;
    }
}