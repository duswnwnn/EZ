
namespace EZ_studycafe
{
    partial class couponEditAd
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
            this.ACouponStamp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ACouponName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACouponNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AdisTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ACouponStamp
            // 
            this.ACouponStamp.Location = new System.Drawing.Point(208, 203);
            this.ACouponStamp.Name = "ACouponStamp";
            this.ACouponStamp.Size = new System.Drawing.Size(170, 25);
            this.ACouponStamp.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(73, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "필요 스탬프";
            // 
            // ACouponName
            // 
            this.ACouponName.Location = new System.Drawing.Point(208, 124);
            this.ACouponName.Name = "ACouponName";
            this.ACouponName.Size = new System.Drawing.Size(170, 25);
            this.ACouponName.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(73, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "쿠폰이름";
            // 
            // ACouponNum
            // 
            this.ACouponNum.Location = new System.Drawing.Point(208, 82);
            this.ACouponNum.Name = "ACouponNum";
            this.ACouponNum.Size = new System.Drawing.Size(170, 25);
            this.ACouponNum.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "쿠폰번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 104;
            this.label1.Text = "쿠폰 수정";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 105;
            this.button1.Text = "적용";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdisTextBox
            // 
            this.AdisTextBox.Location = new System.Drawing.Point(208, 163);
            this.AdisTextBox.Name = "AdisTextBox";
            this.AdisTextBox.Size = new System.Drawing.Size(170, 25);
            this.AdisTextBox.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(74, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 116;
            this.label5.Text = "할인률";
            // 
            // couponEditAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 289);
            this.Controls.Add(this.AdisTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ACouponStamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ACouponName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ACouponNum);
            this.Controls.Add(this.label2);
            this.Name = "couponEditAd";
            this.Text = "couponEditAd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ACouponStamp;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ACouponName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ACouponNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox AdisTextBox;
        private System.Windows.Forms.Label label5;
    }
}