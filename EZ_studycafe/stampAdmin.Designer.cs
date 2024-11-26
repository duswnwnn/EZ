
namespace EZ_studycafe
{
    partial class stampAdmin
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
            this.nowStamp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stampTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.backStamp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(297, 178);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 33);
            this.addBtn.TabIndex = 112;
            this.addBtn.Text = "추가";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(391, 178);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 33);
            this.delBtn.TabIndex = 111;
            this.delBtn.Text = "삭제";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // nowStamp
            // 
            this.nowStamp.AutoSize = true;
            this.nowStamp.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowStamp.Location = new System.Drawing.Point(244, 113);
            this.nowStamp.Name = "nowStamp";
            this.nowStamp.Size = new System.Drawing.Size(51, 19);
            this.nowStamp.TabIndex = 109;
            this.nowStamp.Text = "10개";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(101, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 106;
            this.label3.Text = "현재 스탬프 : ";
            // 
            // stampTextBox
            // 
            this.stampTextBox.Location = new System.Drawing.Point(105, 184);
            this.stampTextBox.Name = "stampTextBox";
            this.stampTextBox.Size = new System.Drawing.Size(170, 25);
            this.stampTextBox.TabIndex = 105;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(57, 74);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(67, 15);
            this.userNameLabel.TabIndex = 104;
            this.userNameLabel.Text = "최연주님";
            // 
            // backStamp
            // 
            this.backStamp.AutoSize = true;
            this.backStamp.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backStamp.Location = new System.Drawing.Point(20, 15);
            this.backStamp.Name = "backStamp";
            this.backStamp.Size = new System.Drawing.Size(33, 30);
            this.backStamp.TabIndex = 102;
            this.backStamp.Text = "<";
            this.backStamp.Click += new System.EventHandler(this.backStamp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 101;
            this.label1.Text = "스탬프관리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 113;
            this.label5.Text = "스탬프 수 변경";
            // 
            // stampAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 264);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.nowStamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stampTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.backStamp);
            this.Controls.Add(this.label1);
            this.Name = "stampAdmin";
            this.Text = "stampAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label nowStamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stampTextBox;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label backStamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}