
namespace EZ_studycafe
{
    partial class seatAdmin
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
            this.seatAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.seatNumber = new System.Windows.Forms.TextBox();
            this.seatCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seatModificationBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sseatSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seatAdminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backSeat
            // 
            this.backSeat.AutoSize = true;
            this.backSeat.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backSeat.Location = new System.Drawing.Point(17, 16);
            this.backSeat.Name = "backSeat";
            this.backSeat.Size = new System.Drawing.Size(33, 30);
            this.backSeat.TabIndex = 82;
            this.backSeat.Text = "<";
            this.backSeat.Click += new System.EventHandler(this.backSeat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(202, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 81;
            this.label1.Text = "좌석 종류 관리";
            // 
            // seatAdminDataGridView
            // 
            this.seatAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seatAdminDataGridView.Location = new System.Drawing.Point(41, 184);
            this.seatAdminDataGridView.Name = "seatAdminDataGridView";
            this.seatAdminDataGridView.RowHeadersWidth = 51;
            this.seatAdminDataGridView.RowTemplate.Height = 27;
            this.seatAdminDataGridView.Size = new System.Drawing.Size(536, 212);
            this.seatAdminDataGridView.TabIndex = 83;
            this.seatAdminDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seatAdminDataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "좌석번호";
            // 
            // seatNumber
            // 
            this.seatNumber.Location = new System.Drawing.Point(123, 75);
            this.seatNumber.Name = "seatNumber";
            this.seatNumber.Size = new System.Drawing.Size(100, 25);
            this.seatNumber.TabIndex = 85;
            // 
            // seatCategory
            // 
            this.seatCategory.Location = new System.Drawing.Point(123, 126);
            this.seatCategory.Name = "seatCategory";
            this.seatCategory.Size = new System.Drawing.Size(100, 25);
            this.seatCategory.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "좌석분류";
            // 
            // seatModificationBtn
            // 
            this.seatModificationBtn.Location = new System.Drawing.Point(502, 409);
            this.seatModificationBtn.Name = "seatModificationBtn";
            this.seatModificationBtn.Size = new System.Drawing.Size(75, 33);
            this.seatModificationBtn.TabIndex = 90;
            this.seatModificationBtn.Text = "수정";
            this.seatModificationBtn.UseVisualStyleBackColor = true;
            this.seatModificationBtn.Click += new System.EventHandler(this.seatModificationBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(347, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 25);
            this.textBox3.TabIndex = 92;
            // 
            // sseatSearchBtn
            // 
            this.sseatSearchBtn.Location = new System.Drawing.Point(502, 145);
            this.sseatSearchBtn.Name = "sseatSearchBtn";
            this.sseatSearchBtn.Size = new System.Drawing.Size(75, 33);
            this.sseatSearchBtn.TabIndex = 92;
            this.sseatSearchBtn.Text = "찾기";
            this.sseatSearchBtn.UseVisualStyleBackColor = true;
            this.sseatSearchBtn.Click += new System.EventHandler(this.sseatSearchBtn_Click);
            // 
            // seatAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 461);
            this.Controls.Add(this.sseatSearchBtn);
            this.Controls.Add(this.seatModificationBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.seatCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seatNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seatAdminDataGridView);
            this.Controls.Add(this.backSeat);
            this.Controls.Add(this.label1);
            this.Name = "seatAdmin";
            this.Text = "seatAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.seatAdminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView seatAdminDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seatNumber;
        private System.Windows.Forms.TextBox seatCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button seatModificationBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sseatSearchBtn;
    }
}