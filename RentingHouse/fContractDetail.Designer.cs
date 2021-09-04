namespace RentingHouse
{
    partial class fContractDetail
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
            this.dgv_contract_history = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_detail = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancel_update = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_accept_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_numberPeople = new System.Windows.Forms.TextBox();
            this.txt_rental = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_contract_status = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_add_contract = new System.Windows.Forms.Button();
            this.btn_cancel_contract = new System.Windows.Forms.Button();
            this.txt_endDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_beginDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.cb_district = new System.Windows.Forms.ComboBox();
            this.house_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_begin_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contract_history)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_contract_history
            // 
            this.dgv_contract_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contract_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.house_id,
            this.col_order,
            this.col_begin_date,
            this.col_end_date,
            this.col_fee});
            this.dgv_contract_history.Location = new System.Drawing.Point(3, 346);
            this.dgv_contract_history.Name = "dgv_contract_history";
            this.dgv_contract_history.ReadOnly = true;
            this.dgv_contract_history.RowTemplate.Height = 24;
            this.dgv_contract_history.Size = new System.Drawing.Size(546, 192);
            this.dgv_contract_history.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_district);
            this.groupBox1.Controls.Add(this.txt_detail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_cancel_update);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_accept_update);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_reason);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.txt_numberPeople);
            this.groupBox1.Controls.Add(this.txt_rental);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_area);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà";
            // 
            // txt_detail
            // 
            this.txt_detail.Location = new System.Drawing.Point(697, 38);
            this.txt_detail.Name = "txt_detail";
            this.txt_detail.Size = new System.Drawing.Size(269, 205);
            this.txt_detail.TabIndex = 2;
            this.txt_detail.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quận";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lý do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tình trạng";
            // 
            // btn_cancel_update
            // 
            this.btn_cancel_update.Location = new System.Drawing.Point(74, 191);
            this.btn_cancel_update.Name = "btn_cancel_update";
            this.btn_cancel_update.Size = new System.Drawing.Size(176, 52);
            this.btn_cancel_update.TabIndex = 2;
            this.btn_cancel_update.Text = "Hủy";
            this.btn_cancel_update.UseVisualStyleBackColor = true;
            this.btn_cancel_update.Visible = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(438, 191);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(176, 52);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Cập nhật thông tin";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_accept_update
            // 
            this.btn_accept_update.Location = new System.Drawing.Point(256, 191);
            this.btn_accept_update.Name = "btn_accept_update";
            this.btn_accept_update.Size = new System.Drawing.Size(176, 52);
            this.btn_accept_update.TabIndex = 2;
            this.btn_accept_update.Text = "Cập nhật";
            this.btn_accept_update.UseVisualStyleBackColor = true;
            this.btn_accept_update.Visible = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mô tả";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(438, 122);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.ReadOnly = true;
            this.txt_reason.Size = new System.Drawing.Size(176, 22);
            this.txt_reason.TabIndex = 0;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(438, 94);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(176, 22);
            this.txt_status.TabIndex = 0;
            // 
            // txt_numberPeople
            // 
            this.txt_numberPeople.Location = new System.Drawing.Point(104, 122);
            this.txt_numberPeople.Name = "txt_numberPeople";
            this.txt_numberPeople.Size = new System.Drawing.Size(176, 22);
            this.txt_numberPeople.TabIndex = 0;
            // 
            // txt_rental
            // 
            this.txt_rental.Location = new System.Drawing.Point(104, 94);
            this.txt_rental.Name = "txt_rental";
            this.txt_rental.Size = new System.Drawing.Size(176, 22);
            this.txt_rental.TabIndex = 0;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(438, 38);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(176, 22);
            this.txt_address.TabIndex = 0;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(104, 66);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(176, 22);
            this.txt_area.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(104, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(176, 22);
            this.txt_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin hợp đồng chi tiết";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lịch sử gia hạn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_contract_status);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_add_contract);
            this.groupBox2.Controls.Add(this.btn_cancel_contract);
            this.groupBox2.Controls.Add(this.txt_endDate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_beginDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(567, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng hợp đồng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tình trạng";
            // 
            // txt_contract_status
            // 
            this.txt_contract_status.Location = new System.Drawing.Point(21, 112);
            this.txt_contract_status.Name = "txt_contract_status";
            this.txt_contract_status.ReadOnly = true;
            this.txt_contract_status.Size = new System.Drawing.Size(176, 22);
            this.txt_contract_status.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Thời gian hiệu lực: 30 Ngày";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Money";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Phí gia hạn:";
            // 
            // btn_add_contract
            // 
            this.btn_add_contract.Location = new System.Drawing.Point(235, 154);
            this.btn_add_contract.Name = "btn_add_contract";
            this.btn_add_contract.Size = new System.Drawing.Size(176, 52);
            this.btn_add_contract.TabIndex = 2;
            this.btn_add_contract.Text = "Gia hạn";
            this.btn_add_contract.UseVisualStyleBackColor = true;
            this.btn_add_contract.Click += new System.EventHandler(this.btn_add_contract_Click);
            // 
            // btn_cancel_contract
            // 
            this.btn_cancel_contract.Location = new System.Drawing.Point(235, 105);
            this.btn_cancel_contract.Name = "btn_cancel_contract";
            this.btn_cancel_contract.Size = new System.Drawing.Size(176, 37);
            this.btn_cancel_contract.TabIndex = 2;
            this.btn_cancel_contract.Text = "Hủy bỏ hợp đồng";
            this.btn_cancel_contract.UseVisualStyleBackColor = true;
            // 
            // txt_endDate
            // 
            this.txt_endDate.Location = new System.Drawing.Point(235, 61);
            this.txt_endDate.Name = "txt_endDate";
            this.txt_endDate.ReadOnly = true;
            this.txt_endDate.Size = new System.Drawing.Size(176, 22);
            this.txt_endDate.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ngày kết thúc";
            // 
            // txt_beginDate
            // 
            this.txt_beginDate.Location = new System.Drawing.Point(21, 61);
            this.txt_beginDate.Name = "txt_beginDate";
            this.txt_beginDate.ReadOnly = true;
            this.txt_beginDate.Size = new System.Drawing.Size(176, 22);
            this.txt_beginDate.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ngày bắt đầu";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 568);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(176, 52);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cb_district
            // 
            this.cb_district.FormattingEnabled = true;
            this.cb_district.Location = new System.Drawing.Point(438, 66);
            this.cb_district.Name = "cb_district";
            this.cb_district.Size = new System.Drawing.Size(176, 24);
            this.cb_district.TabIndex = 3;
            // 
            // house_id
            // 
            this.house_id.DataPropertyName = "house_id";
            this.house_id.HeaderText = "Mã nhà";
            this.house_id.Name = "house_id";
            this.house_id.ReadOnly = true;
            this.house_id.Visible = false;
            // 
            // col_order
            // 
            this.col_order.DataPropertyName = "c_order";
            this.col_order.HeaderText = "Lần thứ";
            this.col_order.Name = "col_order";
            this.col_order.ReadOnly = true;
            // 
            // col_begin_date
            // 
            this.col_begin_date.DataPropertyName = "begin_date";
            this.col_begin_date.HeaderText = "Ngày bắt đầu";
            this.col_begin_date.Name = "col_begin_date";
            this.col_begin_date.ReadOnly = true;
            // 
            // col_end_date
            // 
            this.col_end_date.DataPropertyName = "end_date";
            this.col_end_date.HeaderText = "Ngày kết thúc";
            this.col_end_date.Name = "col_end_date";
            this.col_end_date.ReadOnly = true;
            // 
            // col_fee
            // 
            this.col_fee.DataPropertyName = "fee";
            this.col_fee.HeaderText = "Phí giới thiệu";
            this.col_fee.Name = "col_fee";
            this.col_fee.ReadOnly = true;
            // 
            // fContractDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_contract_history);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_close);
            this.Name = "fContractDetail";
            this.Text = "fContractDetail";
            this.Load += new System.EventHandler(this.fContractDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contract_history)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contract_history;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_detail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_numberPeople;
        private System.Windows.Forms.TextBox txt_rental;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_cancel_update;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_accept_update;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_contract_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_add_contract;
        private System.Windows.Forms.TextBox txt_endDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_beginDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_cancel_contract;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cb_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn house_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_begin_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fee;
    }
}