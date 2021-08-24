namespace RentingHouse
{
    partial class fRegisterRentHouse
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
            this.dgv_listHouseChecked = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rental = new System.Windows.Forms.TextBox();
            this.txt_numberPeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_owner = new System.Windows.Forms.TextBox();
            this.txt_district = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_detail = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_numberPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ownerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_districtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_addInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_rentFee = new System.Windows.Forms.Label();
            this.lb_liabilityFee = new System.Windows.Forms.Label();
            this.lb_totalFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listHouseChecked)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listHouseChecked
            // 
            this.dgv_listHouseChecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listHouseChecked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_district,
            this.col_area,
            this.col_numberPeople,
            this.col_rental,
            this.col_status,
            this.col_address,
            this.col_detail,
            this.col_owner,
            this.col_ownerId,
            this.col_districtId,
            this.col_addInfo,
            this.col_reason});
            this.dgv_listHouseChecked.Location = new System.Drawing.Point(2, 244);
            this.dgv_listHouseChecked.Name = "dgv_listHouseChecked";
            this.dgv_listHouseChecked.RowTemplate.Height = 24;
            this.dgv_listHouseChecked.Size = new System.Drawing.Size(981, 258);
            this.dgv_listHouseChecked.TabIndex = 0;
            this.dgv_listHouseChecked.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listHouseChecked_CellClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(732, 527);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 39);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(874, 527);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(109, 39);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_detail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.txt_district);
            this.groupBox1.Controls.Add(this.txt_numberPeople);
            this.groupBox1.Controls.Add(this.txt_owner);
            this.groupBox1.Controls.Add(this.txt_rental);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_area);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Location = new System.Drawing.Point(2, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng ký đơn thuê nhà";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(104, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(176, 22);
            this.txt_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(104, 66);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(176, 22);
            this.txt_area.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Diện tích";
            // 
            // txt_rental
            // 
            this.txt_rental.Location = new System.Drawing.Point(104, 94);
            this.txt_rental.Name = "txt_rental";
            this.txt_rental.ReadOnly = true;
            this.txt_rental.Size = new System.Drawing.Size(176, 22);
            this.txt_rental.TabIndex = 0;
            // 
            // txt_numberPeople
            // 
            this.txt_numberPeople.Location = new System.Drawing.Point(104, 122);
            this.txt_numberPeople.Name = "txt_numberPeople";
            this.txt_numberPeople.ReadOnly = true;
            this.txt_numberPeople.Size = new System.Drawing.Size(176, 22);
            this.txt_numberPeople.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số người";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(438, 38);
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = true;
            this.txt_address.Size = new System.Drawing.Size(176, 22);
            this.txt_address.TabIndex = 0;
            // 
            // txt_owner
            // 
            this.txt_owner.Location = new System.Drawing.Point(438, 66);
            this.txt_owner.Name = "txt_owner";
            this.txt_owner.ReadOnly = true;
            this.txt_owner.Size = new System.Drawing.Size(176, 22);
            this.txt_owner.TabIndex = 0;
            // 
            // txt_district
            // 
            this.txt_district.Location = new System.Drawing.Point(438, 94);
            this.txt_district.Name = "txt_district";
            this.txt_district.ReadOnly = true;
            this.txt_district.Size = new System.Drawing.Size(176, 22);
            this.txt_district.TabIndex = 0;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(438, 122);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(176, 22);
            this.txt_status.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên chủ nhà";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quận";
            // 
            // txt_detail
            // 
            this.txt_detail.Location = new System.Drawing.Point(697, 58);
            this.txt_detail.Name = "txt_detail";
            this.txt_detail.ReadOnly = true;
            this.txt_detail.Size = new System.Drawing.Size(242, 86);
            this.txt_detail.TabIndex = 2;
            this.txt_detail.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(694, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mô tả";
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_district
            // 
            this.col_district.DataPropertyName = "district";
            this.col_district.HeaderText = "Quận";
            this.col_district.Name = "col_district";
            this.col_district.ReadOnly = true;
            // 
            // col_area
            // 
            this.col_area.DataPropertyName = "area";
            this.col_area.HeaderText = "Diện tích";
            this.col_area.Name = "col_area";
            this.col_area.ReadOnly = true;
            // 
            // col_numberPeople
            // 
            this.col_numberPeople.DataPropertyName = "number_people";
            this.col_numberPeople.HeaderText = "Số người";
            this.col_numberPeople.Name = "col_numberPeople";
            this.col_numberPeople.ReadOnly = true;
            // 
            // col_rental
            // 
            this.col_rental.DataPropertyName = "rental";
            this.col_rental.HeaderText = "Giá";
            this.col_rental.Name = "col_rental";
            this.col_rental.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "h_status";
            this.col_status.HeaderText = "Trạng thái";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "h_address";
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            this.col_address.Visible = false;
            // 
            // col_detail
            // 
            this.col_detail.DataPropertyName = "h_description";
            this.col_detail.HeaderText = "Mô tả";
            this.col_detail.Name = "col_detail";
            this.col_detail.ReadOnly = true;
            this.col_detail.Visible = false;
            // 
            // col_owner
            // 
            this.col_owner.DataPropertyName = "fullname";
            this.col_owner.HeaderText = "Tên chủ nhà";
            this.col_owner.Name = "col_owner";
            this.col_owner.ReadOnly = true;
            this.col_owner.Visible = false;
            // 
            // col_ownerId
            // 
            this.col_ownerId.DataPropertyName = "h_user_id";
            this.col_ownerId.HeaderText = "ID chủ nhà";
            this.col_ownerId.Name = "col_ownerId";
            this.col_ownerId.ReadOnly = true;
            this.col_ownerId.Visible = false;
            // 
            // col_districtId
            // 
            this.col_districtId.DataPropertyName = "district_id";
            this.col_districtId.HeaderText = "ID Quận";
            this.col_districtId.Name = "col_districtId";
            this.col_districtId.ReadOnly = true;
            this.col_districtId.Visible = false;
            // 
            // col_addInfo
            // 
            this.col_addInfo.DataPropertyName = "h_add_info";
            this.col_addInfo.HeaderText = "Thông tin bổ sung";
            this.col_addInfo.Name = "col_addInfo";
            this.col_addInfo.ReadOnly = true;
            this.col_addInfo.Visible = false;
            // 
            // col_reason
            // 
            this.col_reason.DataPropertyName = "reason";
            this.col_reason.HeaderText = "Lý do";
            this.col_reason.Name = "col_reason";
            this.col_reason.ReadOnly = true;
            this.col_reason.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Phí thuê:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 538);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Phí trách nhiệm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(467, 538);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tổng cộng:";
            // 
            // lb_rentFee
            // 
            this.lb_rentFee.AutoSize = true;
            this.lb_rentFee.Location = new System.Drawing.Point(116, 538);
            this.lb_rentFee.Name = "lb_rentFee";
            this.lb_rentFee.Size = new System.Drawing.Size(16, 17);
            this.lb_rentFee.TabIndex = 1;
            this.lb_rentFee.Text = "0";
            // 
            // lb_liabilityFee
            // 
            this.lb_liabilityFee.AutoSize = true;
            this.lb_liabilityFee.Location = new System.Drawing.Point(346, 538);
            this.lb_liabilityFee.Name = "lb_liabilityFee";
            this.lb_liabilityFee.Size = new System.Drawing.Size(16, 17);
            this.lb_liabilityFee.TabIndex = 1;
            this.lb_liabilityFee.Text = "0";
            // 
            // lb_totalFee
            // 
            this.lb_totalFee.AutoSize = true;
            this.lb_totalFee.Location = new System.Drawing.Point(553, 538);
            this.lb_totalFee.Name = "lb_totalFee";
            this.lb_totalFee.Size = new System.Drawing.Size(16, 17);
            this.lb_totalFee.TabIndex = 1;
            this.lb_totalFee.Text = "0";
            // 
            // fRegisterRentHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dgv_listHouseChecked);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_totalFee);
            this.Controls.Add(this.lb_liabilityFee);
            this.Controls.Add(this.lb_rentFee);
            this.Controls.Add(this.label11);
            this.Name = "fRegisterRentHouse";
            this.Text = "fRegisterRentHouse";
            this.Load += new System.EventHandler(this.fRegisterRentHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listHouseChecked)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listHouseChecked;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_detail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.TextBox txt_numberPeople;
        private System.Windows.Forms.TextBox txt_owner;
        private System.Windows.Forms.TextBox txt_rental;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numberPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ownerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_districtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_addInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_rentFee;
        private System.Windows.Forms.Label lb_liabilityFee;
        private System.Windows.Forms.Label lb_totalFee;
    }
}