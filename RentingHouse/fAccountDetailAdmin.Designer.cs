namespace RentingHouse
{
    partial class fAccountDetailAdmin
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id_card = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_change_pass = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(109, 49);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(187, 22);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(109, 77);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(187, 22);
            this.txt_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(125, 49);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(187, 22);
            this.txt_new_password.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(109, 105);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(187, 22);
            this.txt_fullname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên đầy đủ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_dob);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_balance);
            this.groupBox1.Controls.Add(this.txt_id_card);
            this.groupBox1.Controls.Add(this.txt_role);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_fullname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(416, 52);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(187, 22);
            this.txt_phone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "SĐT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_change_pass);
            this.groupBox2.Controls.Add(this.txt_new_password);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(652, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thay đổi mật khẩu";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(109, 133);
            this.txt_role.Name = "txt_role";
            this.txt_role.ReadOnly = true;
            this.txt_role.Size = new System.Drawing.Size(187, 22);
            this.txt_role.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "CMND";
            // 
            // txt_id_card
            // 
            this.txt_id_card.Location = new System.Drawing.Point(416, 108);
            this.txt_id_card.Name = "txt_id_card";
            this.txt_id_card.Size = new System.Drawing.Size(187, 22);
            this.txt_id_card.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số dư";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(416, 136);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(187, 22);
            this.txt_balance.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Loại tài khoản";
            // 
            // btn_change_pass
            // 
            this.btn_change_pass.Location = new System.Drawing.Point(188, 105);
            this.btn_change_pass.Name = "btn_change_pass";
            this.btn_change_pass.Size = new System.Drawing.Size(124, 40);
            this.btn_change_pass.TabIndex = 3;
            this.btn_change_pass.Text = "Thay đổi";
            this.btn_change_pass.UseVisualStyleBackColor = true;
            this.btn_change_pass.Click += new System.EventHandler(this.btn_change_pass_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(479, 231);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 40);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(890, 331);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 40);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(718, 331);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 40);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(416, 80);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(187, 22);
            this.dtp_dob.TabIndex = 4;
            // 
            // fAccountDetailAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 402);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fAccountDetailAdmin";
            this.Text = "fAccountDetailAdmin";
            this.Load += new System.EventHandler(this.fAccountDetailAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_id_card;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_change_pass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DateTimePicker dtp_dob;
    }
}