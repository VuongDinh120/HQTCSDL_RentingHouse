namespace RentingHouse
{
    partial class fBookingDetail
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
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_begin_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_end_date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_received_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_rent_fee = new System.Windows.Forms.TextBox();
            this.txt_liability_fee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id_house = new System.Windows.Forms.TextBox();
            this.txt_meet_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_meet_time = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_meet_phone = new System.Windows.Forms.TextBox();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meet_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meet_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meet_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_numberPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_is_rented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_checkbox_houses = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listHouseChecked)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listHouseChecked
            // 
            this.dgv_listHouseChecked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listHouseChecked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.meet_time,
            this.meet_address,
            this.meet_phone,
            this.col_address,
            this.col_district,
            this.col_area,
            this.col_numberPeople,
            this.col_rental,
            this.col_owner,
            this.col_is_rented,
            this.col_checkbox_houses});
            this.dgv_listHouseChecked.Location = new System.Drawing.Point(12, 251);
            this.dgv_listHouseChecked.Name = "dgv_listHouseChecked";
            this.dgv_listHouseChecked.RowTemplate.Height = 24;
            this.dgv_listHouseChecked.Size = new System.Drawing.Size(1089, 258);
            this.dgv_listHouseChecked.TabIndex = 1;
            this.dgv_listHouseChecked.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listHouseChecked_CellClick);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(962, 529);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(139, 47);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Thuê";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(808, 529);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 47);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Hủy thuê";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 529);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(139, 47);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_begin_date
            // 
            this.txt_begin_date.Location = new System.Drawing.Point(133, 42);
            this.txt_begin_date.Name = "txt_begin_date";
            this.txt_begin_date.ReadOnly = true;
            this.txt_begin_date.Size = new System.Drawing.Size(162, 22);
            this.txt_begin_date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày đăng ký";
            // 
            // txt_end_date
            // 
            this.txt_end_date.Location = new System.Drawing.Point(133, 79);
            this.txt_end_date.Name = "txt_end_date";
            this.txt_end_date.ReadOnly = true;
            this.txt_end_date.Size = new System.Drawing.Size(162, 22);
            this.txt_end_date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày hết hạn";
            // 
            // txt_received_date
            // 
            this.txt_received_date.Location = new System.Drawing.Point(133, 117);
            this.txt_received_date.Name = "txt_received_date";
            this.txt_received_date.ReadOnly = true;
            this.txt_received_date.Size = new System.Drawing.Size(162, 22);
            this.txt_received_date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày xác nhận";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(449, 42);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(162, 22);
            this.txt_status.TabIndex = 3;
            // 
            // txt_rent_fee
            // 
            this.txt_rent_fee.Location = new System.Drawing.Point(449, 79);
            this.txt_rent_fee.Name = "txt_rent_fee";
            this.txt_rent_fee.ReadOnly = true;
            this.txt_rent_fee.Size = new System.Drawing.Size(162, 22);
            this.txt_rent_fee.TabIndex = 3;
            // 
            // txt_liability_fee
            // 
            this.txt_liability_fee.Location = new System.Drawing.Point(449, 117);
            this.txt_liability_fee.Name = "txt_liability_fee";
            this.txt_liability_fee.ReadOnly = true;
            this.txt_liability_fee.Size = new System.Drawing.Size(162, 22);
            this.txt_liability_fee.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phí thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phí trách nhiệm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_rent_fee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_liability_fee);
            this.groupBox1.Controls.Add(this.txt_received_date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_end_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_begin_date);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuê nhà";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chi tiết đơn thuê nhà";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id_house);
            this.groupBox2.Controls.Add(this.txt_meet_address);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_meet_time);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_meet_phone);
            this.groupBox2.Location = new System.Drawing.Point(695, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 172);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch hẹn";
            // 
            // txt_id_house
            // 
            this.txt_id_house.Location = new System.Drawing.Point(133, 39);
            this.txt_id_house.Name = "txt_id_house";
            this.txt_id_house.ReadOnly = true;
            this.txt_id_house.Size = new System.Drawing.Size(188, 22);
            this.txt_id_house.TabIndex = 3;
            // 
            // txt_meet_address
            // 
            this.txt_meet_address.Location = new System.Drawing.Point(133, 67);
            this.txt_meet_address.Name = "txt_meet_address";
            this.txt_meet_address.ReadOnly = true;
            this.txt_meet_address.Size = new System.Drawing.Size(188, 22);
            this.txt_meet_address.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Mã nhà";
            // 
            // txt_meet_time
            // 
            this.txt_meet_time.Location = new System.Drawing.Point(133, 95);
            this.txt_meet_time.Name = "txt_meet_time";
            this.txt_meet_time.ReadOnly = true;
            this.txt_meet_time.Size = new System.Drawing.Size(188, 22);
            this.txt_meet_time.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thời gian";
            // 
            // txt_meet_phone
            // 
            this.txt_meet_phone.Location = new System.Drawing.Point(133, 124);
            this.txt_meet_phone.Name = "txt_meet_phone";
            this.txt_meet_phone.ReadOnly = true;
            this.txt_meet_phone.Size = new System.Drawing.Size(188, 22);
            this.txt_meet_phone.TabIndex = 3;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // meet_time
            // 
            this.meet_time.DataPropertyName = "meet_time";
            this.meet_time.HeaderText = "Thời gian gặp";
            this.meet_time.Name = "meet_time";
            this.meet_time.ReadOnly = true;
            this.meet_time.Visible = false;
            // 
            // meet_address
            // 
            this.meet_address.DataPropertyName = "meet_address";
            this.meet_address.HeaderText = "Địa Chỉ gặp";
            this.meet_address.Name = "meet_address";
            this.meet_address.ReadOnly = true;
            this.meet_address.Visible = false;
            // 
            // meet_phone
            // 
            this.meet_phone.DataPropertyName = "meet_phone";
            this.meet_phone.HeaderText = "sdt liên lạc";
            this.meet_phone.Name = "meet_phone";
            this.meet_phone.ReadOnly = true;
            this.meet_phone.Visible = false;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "h_address";
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            this.col_address.Visible = false;
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
            // col_owner
            // 
            this.col_owner.DataPropertyName = "fullname";
            this.col_owner.HeaderText = "Tên chủ nhà";
            this.col_owner.Name = "col_owner";
            this.col_owner.ReadOnly = true;
            this.col_owner.Visible = false;
            // 
            // col_is_rented
            // 
            this.col_is_rented.DataPropertyName = "h_status";
            this.col_is_rented.HeaderText = "Tình trạng";
            this.col_is_rented.Name = "col_is_rented";
            this.col_is_rented.ReadOnly = true;
            // 
            // col_checkbox_houses
            // 
            this.col_checkbox_houses.FalseValue = "F";
            this.col_checkbox_houses.HeaderText = "Chọn nhà";
            this.col_checkbox_houses.Name = "col_checkbox_houses";
            this.col_checkbox_houses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_checkbox_houses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_checkbox_houses.TrueValue = "T";
            // 
            // fBookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.dgv_listHouseChecked);
            this.Controls.Add(this.label7);
            this.Name = "fBookingDetail";
            this.Text = "BookingDetail";
            this.Load += new System.EventHandler(this.fBookingDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listHouseChecked)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listHouseChecked;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_begin_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_end_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_received_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_rent_fee;
        private System.Windows.Forms.TextBox txt_liability_fee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_meet_address;
        private System.Windows.Forms.TextBox txt_meet_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_meet_phone;
        private System.Windows.Forms.TextBox txt_id_house;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn meet_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn meet_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn meet_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numberPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_is_rented;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_checkbox_houses;
    }
}