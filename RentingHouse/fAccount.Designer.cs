namespace RentingHouse
{
    partial class fAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idCard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.btn_update_user = new System.Windows.Forms.Button();
            this.btn_update_password = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_update_balance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(229, 134);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(166, 22);
            this.txt_username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đầy đủ";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(229, 172);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(166, 22);
            this.txt_fullname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "SĐT";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(229, 247);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(166, 22);
            this.txt_phone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "CMND";
            // 
            // txt_idCard
            // 
            this.txt_idCard.Location = new System.Drawing.Point(229, 285);
            this.txt_idCard.Name = "txt_idCard";
            this.txt_idCard.Size = new System.Drawing.Size(166, 22);
            this.txt_idCard.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số dư hiện có";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(622, 285);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.Size = new System.Drawing.Size(166, 22);
            this.txt_balance.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Loại tài khoản";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(229, 325);
            this.txt_role.Name = "txt_role";
            this.txt_role.ReadOnly = true;
            this.txt_role.Size = new System.Drawing.Size(166, 22);
            this.txt_role.TabIndex = 2;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(229, 209);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(166, 22);
            this.dtp_dob.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mật khẩu mới";
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(622, 134);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(166, 22);
            this.txt_new_password.TabIndex = 2;
            // 
            // btn_update_user
            // 
            this.btn_update_user.Location = new System.Drawing.Point(229, 380);
            this.btn_update_user.Name = "btn_update_user";
            this.btn_update_user.Size = new System.Drawing.Size(166, 26);
            this.btn_update_user.TabIndex = 4;
            this.btn_update_user.Text = "Cập nhật thông tin";
            this.btn_update_user.UseVisualStyleBackColor = true;
            // 
            // btn_update_password
            // 
            this.btn_update_password.Location = new System.Drawing.Point(622, 188);
            this.btn_update_password.Name = "btn_update_password";
            this.btn_update_password.Size = new System.Drawing.Size(166, 26);
            this.btn_update_password.TabIndex = 4;
            this.btn_update_password.Text = "Cập nhật mật khẩu";
            this.btn_update_password.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số tiền nạp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(622, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_update_balance
            // 
            this.btn_update_balance.Location = new System.Drawing.Point(622, 380);
            this.btn_update_balance.Name = "btn_update_balance";
            this.btn_update_balance.Size = new System.Drawing.Size(166, 26);
            this.btn_update_balance.TabIndex = 4;
            this.btn_update_balance.Text = "Nạp tiền";
            this.btn_update_balance.UseVisualStyleBackColor = true;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(977, 587);
            this.Controls.Add(this.btn_update_password);
            this.Controls.Add(this.btn_update_balance);
            this.Controls.Add(this.btn_update_user);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idCard);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_new_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fAccount";
            this.Text = "fAccount";
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Button btn_update_user;
        private System.Windows.Forms.Button btn_update_password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_update_balance;
    }
}