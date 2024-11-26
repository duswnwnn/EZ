
namespace EZ_studycafe
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.joinBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.roomSeat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openSeat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.privateSeat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joinBtn
            // 
            this.joinBtn.BackColor = System.Drawing.Color.Moccasin;
            this.joinBtn.Location = new System.Drawing.Point(412, 349);
            this.joinBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(177, 71);
            this.joinBtn.TabIndex = 27;
            this.joinBtn.Text = "회원가입";
            this.joinBtn.UseVisualStyleBackColor = false;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Moccasin;
            this.loginBtn.Location = new System.Drawing.Point(211, 349);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(176, 71);
            this.loginBtn.TabIndex = 26;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(348, 271);
            this.userPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(231, 25);
            this.userPhone.TabIndex = 25;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(348, 213);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(231, 25);
            this.userName.TabIndex = 24;
            // 
            // roomSeat
            // 
            this.roomSeat.AutoSize = true;
            this.roomSeat.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roomSeat.Location = new System.Drawing.Point(503, 137);
            this.roomSeat.Name = "roomSeat";
            this.roomSeat.Size = new System.Drawing.Size(45, 17);
            this.roomSeat.TabIndex = 23;
            this.roomSeat.Text = "1 / 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(498, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "회의룸";
            // 
            // openSeat
            // 
            this.openSeat.AutoSize = true;
            this.openSeat.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.openSeat.Location = new System.Drawing.Point(366, 137);
            this.openSeat.Name = "openSeat";
            this.openSeat.Size = new System.Drawing.Size(54, 17);
            this.openSeat.TabIndex = 21;
            this.openSeat.Text = "3 / 12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(361, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "개방석";
            // 
            // privateSeat
            // 
            this.privateSeat.AutoSize = true;
            this.privateSeat.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.privateSeat.Location = new System.Drawing.Point(232, 137);
            this.privateSeat.Name = "privateSeat";
            this.privateSeat.Size = new System.Drawing.Size(54, 17);
            this.privateSeat.TabIndex = 19;
            this.privateSeat.Text = "3 / 12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(227, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "개인석";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(216, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(216, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(319, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "스터디카페";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.roomSeat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.openSeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.privateSeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label roomSeat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label openSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label privateSeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

