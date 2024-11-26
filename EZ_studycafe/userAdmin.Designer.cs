
namespace EZ_studycafe
{
    partial class userAdmin
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
            this.backSeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userSearchBtn = new System.Windows.Forms.Button();
            this.stampManageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backSeat
            // 
            this.backSeat.AutoSize = true;
            this.backSeat.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backSeat.Location = new System.Drawing.Point(17, 21);
            this.backSeat.Name = "backSeat";
            this.backSeat.Size = new System.Drawing.Size(33, 30);
            this.backSeat.TabIndex = 86;
            this.backSeat.Text = "<";
            this.backSeat.Click += new System.EventHandler(this.backSeat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(269, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 85;
            this.label1.Text = "회원 관리";
            // 
            // userListView
            // 
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(32, 166);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(615, 229);
            this.userListView.TabIndex = 87;
            this.userListView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 88;
            this.label2.Text = "회원 리스트";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(386, 127);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(169, 25);
            this.userTextBox.TabIndex = 89;
            // 
            // userSearchBtn
            // 
            this.userSearchBtn.Location = new System.Drawing.Point(561, 127);
            this.userSearchBtn.Name = "userSearchBtn";
            this.userSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.userSearchBtn.TabIndex = 90;
            this.userSearchBtn.Text = "검색";
            this.userSearchBtn.UseVisualStyleBackColor = true;
            this.userSearchBtn.Click += new System.EventHandler(this.userSearchBtn_Click);
            // 
            // stampManageBtn
            // 
            this.stampManageBtn.Location = new System.Drawing.Point(533, 408);
            this.stampManageBtn.Name = "stampManageBtn";
            this.stampManageBtn.Size = new System.Drawing.Size(114, 36);
            this.stampManageBtn.TabIndex = 92;
            this.stampManageBtn.Text = "스탬프 관리";
            this.stampManageBtn.UseVisualStyleBackColor = true;
            this.stampManageBtn.Click += new System.EventHandler(this.stampManageBtn_Click);
            // 
            // userAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 456);
            this.Controls.Add(this.userSearchBtn);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.stampManageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.backSeat);
            this.Controls.Add(this.label1);
            this.Name = "userAdmin";
            this.Text = "userAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button userSearchBtn;
        private System.Windows.Forms.Button stampManageBtn;
    }
}