namespace RentingHouse
{
    partial class fBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_beginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_receiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_number_house = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_liabilityFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dgvBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooking.ColumnHeadersHeight = 40;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_beginDate,
            this.col_endDate,
            this.col_receiveDate,
            this.col_number_house,
            this.col_status,
            this.col_liabilityFee,
            this.col_rentFee,
            this.btn_detail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooking.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooking.EnableHeadersVisualStyles = false;
            this.dgvBooking.Location = new System.Drawing.Point(12, 60);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.RowTemplate.Height = 50;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(1107, 405);
            this.dgvBooking.TabIndex = 5;
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.FillWeight = 91.37057F;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_beginDate
            // 
            this.col_beginDate.DataPropertyName = "begin_date";
            this.col_beginDate.FillWeight = 111.6622F;
            this.col_beginDate.HeaderText = "Ngày đăng kí";
            this.col_beginDate.Name = "col_beginDate";
            this.col_beginDate.ReadOnly = true;
            // 
            // col_endDate
            // 
            this.col_endDate.DataPropertyName = "end_date";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.col_endDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_endDate.FillWeight = 111.6622F;
            this.col_endDate.HeaderText = "Ngày hết hạn";
            this.col_endDate.Name = "col_endDate";
            this.col_endDate.ReadOnly = true;
            // 
            // col_receiveDate
            // 
            this.col_receiveDate.DataPropertyName = "received_date";
            this.col_receiveDate.FillWeight = 111.6622F;
            this.col_receiveDate.HeaderText = "Ngày xác nhận";
            this.col_receiveDate.Name = "col_receiveDate";
            this.col_receiveDate.ReadOnly = true;
            // 
            // col_number_house
            // 
            this.col_number_house.DataPropertyName = "number_house";
            this.col_number_house.FillWeight = 111.6622F;
            this.col_number_house.HeaderText = "Số lượng nhà";
            this.col_number_house.Name = "col_number_house";
            this.col_number_house.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "b_status";
            this.col_status.FillWeight = 111.6622F;
            this.col_status.HeaderText = "Trạng thái";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_liabilityFee
            // 
            this.col_liabilityFee.DataPropertyName = "liability_fee";
            this.col_liabilityFee.FillWeight = 97.55052F;
            this.col_liabilityFee.HeaderText = "Phí trách nhiệm";
            this.col_liabilityFee.Name = "col_liabilityFee";
            this.col_liabilityFee.ReadOnly = true;
            // 
            // col_rentFee
            // 
            this.col_rentFee.DataPropertyName = "rent_fee";
            this.col_rentFee.FillWeight = 97.55052F;
            this.col_rentFee.HeaderText = "Phí thuê";
            this.col_rentFee.Name = "col_rentFee";
            this.col_rentFee.ReadOnly = true;
            // 
            // btn_detail
            // 
            this.btn_detail.FillWeight = 55.21756F;
            this.btn_detail.HeaderText = "Chi tiết";
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Text = "Xem";
            this.btn_detail.UseColumnTextForButtonValue = true;
            // 
            // fBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 477);
            this.Controls.Add(this.dgvBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBooking";
            this.Text = "fHouses";
            this.Load += new System.EventHandler(this.fBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_beginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_receiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_number_house;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_liabilityFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rentFee;
        private System.Windows.Forms.DataGridViewButtonColumn btn_detail;
    }
}