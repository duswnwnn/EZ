
namespace EZ_studycafe
{
    partial class admin
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
            this.userBtn = new System.Windows.Forms.Button();
            this.seatBtn = new System.Windows.Forms.Button();
            this.couponBtn = new System.Windows.Forms.Button();
            this.userAdminBtn = new System.Windows.Forms.Button();
            this.seatUseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(294, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "관리자";
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(12, 352);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(75, 23);
            this.userBtn.TabIndex = 18;
            this.userBtn.Text = "사용자";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // seatBtn
            // 
            this.seatBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.seatBtn.Location = new System.Drawing.Point(204, 268);
            this.seatBtn.Name = "seatBtn";
            this.seatBtn.Size = new System.Drawing.Size(122, 55);
            this.seatBtn.TabIndex = 19;
            this.seatBtn.Text = "좌석 종류 관리";
            this.seatBtn.UseVisualStyleBackColor = false;
            this.seatBtn.Click += new System.EventHandler(this.seatBtn_Click);
            // 
            // couponBtn
            // 
            this.couponBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.couponBtn.Location = new System.Drawing.Point(535, 268);
            this.couponBtn.Name = "couponBtn";
            this.couponBtn.Size = new System.Drawing.Size(124, 55);
            this.couponBtn.TabIndex = 20;
            this.couponBtn.Text = "쿠폰 종류 관리";
            this.couponBtn.UseVisualStyleBackColor = false;
            this.couponBtn.Click += new System.EventHandler(this.couponBtn_Click);
            // 
            // userAdminBtn
            // 
            this.userAdminBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.userAdminBtn.Location = new System.Drawing.Point(45, 268);
            this.userAdminBtn.Name = "userAdminBtn";
            this.userAdminBtn.Size = new System.Drawing.Size(121, 55);
            this.userAdminBtn.TabIndex = 22;
            this.userAdminBtn.Text = "회원 관리";
            this.userAdminBtn.UseVisualStyleBackColor = false;
            this.userAdminBtn.Click += new System.EventHandler(this.userAdminBtn_Click);
            // 
            // seatUseBtn
            // 
            this.seatUseBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.seatUseBtn.Location = new System.Drawing.Point(373, 268);
            this.seatUseBtn.Name = "seatUseBtn";
            this.seatUseBtn.Size = new System.Drawing.Size(131, 55);
            this.seatUseBtn.TabIndex = 23;
            this.seatUseBtn.Text = "좌석 이용 현황";
            this.seatUseBtn.UseVisualStyleBackColor = false;
            this.seatUseBtn.Click += new System.EventHandler(this.seatUseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(104, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "개인석 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(224, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "3/16";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(224, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "1/3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(104, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "회의룸 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(161, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 149);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "좌석 이용 현황";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seatUseBtn);
            this.Controls.Add(this.userAdminBtn);
            this.Controls.Add(this.couponBtn);
            this.Controls.Add(this.seatBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.Text = "admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button seatBtn;
        private System.Windows.Forms.Button couponBtn;
        private System.Windows.Forms.Button userAdminBtn;
        private System.Windows.Forms.Button seatUseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}