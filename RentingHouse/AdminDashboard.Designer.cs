using RentingHouse.DAO;
using RentingHouse.DTO;

namespace RentingHouse
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.btnSurvey = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnHouses = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlFormHouses = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnMeeting);
            this.panel1.Controls.Add(this.btnSurvey);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnHouses);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 710);
            this.panel1.TabIndex = 0;
            // 
            // btnMeeting
            // 
            this.btnMeeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeeting.FlatAppearance.BorderSize = 0;
            this.btnMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeeting.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMeeting.Location = new System.Drawing.Point(0, 385);
            this.btnMeeting.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(248, 52);
            this.btnMeeting.TabIndex = 1;
            this.btnMeeting.Text = "Quản lý lịch hẹn";
            this.btnMeeting.UseVisualStyleBackColor = true;
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            this.btnMeeting.Leave += new System.EventHandler(this.btnMeeting_Leave);
            // 
            // btnSurvey
            // 
            this.btnSurvey.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSurvey.FlatAppearance.BorderSize = 0;
            this.btnSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurvey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurvey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSurvey.Location = new System.Drawing.Point(0, 333);
            this.btnSurvey.Margin = new System.Windows.Forms.Padding(4);
            this.btnSurvey.Name = "btnSurvey";
            this.btnSurvey.Size = new System.Drawing.Size(248, 52);
            this.btnSurvey.TabIndex = 1;
            this.btnSurvey.Text = "Quản lý khảo sát";
            this.btnSurvey.UseVisualStyleBackColor = true;
            this.btnSurvey.Click += new System.EventHandler(this.btnSurvey_Click);
            this.btnSurvey.Leave += new System.EventHandler(this.btnSurvey_Leave);
            // 
            // btnBooking
            // 
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBooking.Location = new System.Drawing.Point(0, 281);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(248, 52);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Quản lý đơn thuê nhà";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            this.btnBooking.Leave += new System.EventHandler(this.btnBooking_Leave);
            // 
            // btnHouses
            // 
            this.btnHouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHouses.FlatAppearance.BorderSize = 0;
            this.btnHouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouses.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHouses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHouses.Location = new System.Drawing.Point(0, 229);
            this.btnHouses.Margin = new System.Windows.Forms.Padding(4);
            this.btnHouses.Name = "btnHouses";
            this.btnHouses.Size = new System.Drawing.Size(248, 52);
            this.btnHouses.TabIndex = 1;
            this.btnHouses.Text = "Quản lý nhà";
            this.btnHouses.UseVisualStyleBackColor = true;
            this.btnHouses.Click += new System.EventHandler(this.btnHouses_Click);
            this.btnHouses.Leave += new System.EventHandler(this.btnAccount_Leave);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAccount.Location = new System.Drawing.Point(0, 177);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(248, 52);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Quản lý tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.Leave += new System.EventHandler(this.btnHouses_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 177);
            this.panel2.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 238);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(67, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(65, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(0, 658);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(248, 52);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Leave += new System.EventHandler(this.btnExit_Leave);
            // 
            // pnlFormHouses
            // 
            this.pnlFormHouses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormHouses.Location = new System.Drawing.Point(248, 123);
            this.pnlFormHouses.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormHouses.Name = "pnlFormHouses";
            this.pnlFormHouses.Size = new System.Drawing.Size(1407, 587);
            this.pnlFormHouses.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(272, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Danh sách nhà";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1655, 710);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFormHouses);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnHouses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlFormHouses;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSurvey;
        private System.Windows.Forms.Button btnMeeting;
    }
}