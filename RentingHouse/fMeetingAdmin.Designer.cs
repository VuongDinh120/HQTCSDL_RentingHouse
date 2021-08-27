namespace RentingHouse
{
    partial class fMeetingAdmin
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
            this.col_book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_house_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.col_book_id,
            this.col_house_id,
            this.col_address,
            this.col_phone,
            this.col_fullname,
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
            // col_book_id
            // 
            this.col_book_id.DataPropertyName = "booking_id";
            this.col_book_id.FillWeight = 83.98891F;
            this.col_book_id.HeaderText = "Booking ID";
            this.col_book_id.Name = "col_book_id";
            this.col_book_id.ReadOnly = true;
            // 
            // col_house_id
            // 
            this.col_house_id.DataPropertyName = "house_id";
            this.col_house_id.FillWeight = 102.6412F;
            this.col_house_id.HeaderText = "House ID";
            this.col_house_id.Name = "col_house_id";
            this.col_house_id.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "h_address";
            this.col_address.FillWeight = 150.5677F;
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // col_phone
            // 
            this.col_phone.DataPropertyName = "phone";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.col_phone.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_phone.FillWeight = 102.6412F;
            this.col_phone.HeaderText = "SĐT";
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            // 
            // col_fullname
            // 
            this.col_fullname.DataPropertyName = "fullname";
            this.col_fullname.FillWeight = 102.6412F;
            this.col_fullname.HeaderText = "Chủ nhà";
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.ReadOnly = true;
            // 
            // btn_detail
            // 
            this.btn_detail.FillWeight = 50.75663F;
            this.btn_detail.HeaderText = "Lịch hẹn";
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Text = "Thêm";
            this.btn_detail.UseColumnTextForButtonValue = true;
            // 
            // fMeetingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 477);
            this.Controls.Add(this.dgvBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMeetingAdmin";
            this.Text = "fHouses";
            this.Load += new System.EventHandler(this.fMeetingAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_house_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewButtonColumn btn_detail;
    }
}