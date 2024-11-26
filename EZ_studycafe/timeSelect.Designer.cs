
namespace EZ_studycafe
{
    partial class timeSelect
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
            this.ticketOKBtn = new System.Windows.Forms.Button();
            this.backTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.couponTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.myPoint = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.needPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ticketOKBtn
            // 
            this.ticketOKBtn.BackColor = System.Drawing.Color.Silver;
            this.ticketOKBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ticketOKBtn.Location = new System.Drawing.Point(431, 341);
            this.ticketOKBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticketOKBtn.Name = "ticketOKBtn";
            this.ticketOKBtn.Size = new System.Drawing.Size(81, 38);
            this.ticketOKBtn.TabIndex = 70;
            this.ticketOKBtn.Text = "완료";
            this.ticketOKBtn.UseVisualStyleBackColor = false;
            this.ticketOKBtn.Click += new System.EventHandler(this.ticketOKBtn_Click);
            // 
            // backTicket
            // 
            this.backTicket.AutoSize = true;
            this.backTicket.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backTicket.Location = new System.Drawing.Point(25, 39);
            this.backTicket.Name = "backTicket";
            this.backTicket.Size = new System.Drawing.Size(33, 30);
            this.backTicket.TabIndex = 69;
            this.backTicket.Text = "<";
            this.backTicket.Click += new System.EventHandler(this.backTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "시간 선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(122, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "시간 입력 : ";
            // 
            // inputTime
            // 
            this.inputTime.Location = new System.Drawing.Point(278, 114);
            this.inputTime.Multiline = true;
            this.inputTime.Name = "inputTime";
            this.inputTime.Size = new System.Drawing.Size(102, 49);
            this.inputTime.TabIndex = 76;
            this.inputTime.TextChanged += new System.EventHandler(this.inputTime_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(390, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(124, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "쿠폰 : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(419, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 79;
            this.button1.Text = "쿠폰선택";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // couponTitle
            // 
            this.couponTitle.AutoSize = true;
            this.couponTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.couponTitle.Location = new System.Drawing.Point(205, 195);
            this.couponTitle.Name = "couponTitle";
            this.couponTitle.Size = new System.Drawing.Size(0, 20);
            this.couponTitle.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(125, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 19);
            this.label11.TabIndex = 82;
            this.label11.Text = "내 잔여 포인트 :";
            // 
            // myPoint
            // 
            this.myPoint.AutoSize = true;
            this.myPoint.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myPoint.Location = new System.Drawing.Point(288, 275);
            this.myPoint.Name = "myPoint";
            this.myPoint.Size = new System.Drawing.Size(0, 19);
            this.myPoint.TabIndex = 83;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(125, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 84;
            this.label14.Text = "필요 포인트 :";
            // 
            // needPoint
            // 
            this.needPoint.AutoSize = true;
            this.needPoint.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.needPoint.Location = new System.Drawing.Point(274, 329);
            this.needPoint.Name = "needPoint";
            this.needPoint.Size = new System.Drawing.Size(0, 19);
            this.needPoint.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "쿠폰정보 와랄라";
            // 
            // timeName
            // 
            this.timeName.AutoSize = true;
            this.timeName.Location = new System.Drawing.Point(126, 79);
            this.timeName.Name = "timeName";
            this.timeName.Size = new System.Drawing.Size(67, 15);
            this.timeName.TabIndex = 87;
            this.timeName.Text = "최연주님";
            // 
            // timeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 413);
            this.Controls.Add(this.timeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.needPoint);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.myPoint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.couponTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ticketOKBtn);
            this.Controls.Add(this.backTicket);
            this.Controls.Add(this.label1);
            this.Name = "timeSelect";
            this.Text = "ticket";
            this.Load += new System.EventHandler(this.timeSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ticketOKBtn;
        private System.Windows.Forms.Label backTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label couponTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label needPoint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label myPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeName;
    }
}