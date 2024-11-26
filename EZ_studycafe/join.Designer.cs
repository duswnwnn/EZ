
namespace EZ_studycafe
{
    partial class join
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
            this.joinOKBtn = new System.Windows.Forms.Button();
            this.joinPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joinName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backJoin = new System.Windows.Forms.Label();
            this.joinPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joinOKBtn
            // 
            this.joinOKBtn.Location = new System.Drawing.Point(661, 387);
            this.joinOKBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.joinOKBtn.Name = "joinOKBtn";
            this.joinOKBtn.Size = new System.Drawing.Size(86, 29);
            this.joinOKBtn.TabIndex = 14;
            this.joinOKBtn.Text = "확인";
            this.joinOKBtn.UseVisualStyleBackColor = true;
            this.joinOKBtn.Click += new System.EventHandler(this.joinOKBtn_Click);
            // 
            // joinPhone
            // 
            this.joinPhone.Location = new System.Drawing.Point(310, 247);
            this.joinPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.joinPhone.Name = "joinPhone";
            this.joinPhone.Size = new System.Drawing.Size(200, 25);
            this.joinPhone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "이름";
            // 
            // joinName
            // 
            this.joinName.Location = new System.Drawing.Point(310, 188);
            this.joinName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.joinName.Name = "joinName";
            this.joinName.Size = new System.Drawing.Size(200, 25);
            this.joinName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(315, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "회원가입";
            // 
            // backJoin
            // 
            this.backJoin.AutoSize = true;
            this.backJoin.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backJoin.Location = new System.Drawing.Point(24, 23);
            this.backJoin.Name = "backJoin";
            this.backJoin.Size = new System.Drawing.Size(33, 30);
            this.backJoin.TabIndex = 15;
            this.backJoin.Text = "<";
            this.backJoin.Click += new System.EventHandler(this.backJoin_Click);
            // 
            // joinPass
            // 
            this.joinPass.Location = new System.Drawing.Point(310, 313);
            this.joinPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.joinPass.Name = "joinPass";
            this.joinPass.Size = new System.Drawing.Size(200, 25);
            this.joinPass.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "비밀번호";
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.joinPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backJoin);
            this.Controls.Add(this.joinOKBtn);
            this.Controls.Add(this.joinPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.joinName);
            this.Controls.Add(this.label1);
            this.Name = "join";
            this.Text = "join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinOKBtn;
        private System.Windows.Forms.TextBox joinPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox joinName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backJoin;
        private System.Windows.Forms.TextBox joinPass;
        private System.Windows.Forms.Label label4;
    }
}