namespace RentingHouse
{
    partial class fContract
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
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dgvContract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContract.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContract.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContract.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContract.ColumnHeadersHeight = 40;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_createdAt,
            this.col_address,
            this.col_district,
            this.col_status,
            this.col_reason,
            this.btn_detail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContract.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContract.EnableHeadersVisualStyles = false;
            this.dgvContract.Location = new System.Drawing.Point(12, 60);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowHeadersVisible = false;
            this.dgvContract.RowTemplate.Height = 50;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(1107, 405);
            this.dgvContract.TabIndex = 5;
            this.dgvContract.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.FillWeight = 91.37057F;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_createdAt
            // 
            this.col_createdAt.DataPropertyName = "created_at";
            this.col_createdAt.FillWeight = 111.6622F;
            this.col_createdAt.HeaderText = "Ngày đăng kí";
            this.col_createdAt.Name = "col_createdAt";
            this.col_createdAt.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "h_address";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.col_address.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_address.FillWeight = 111.6622F;
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // col_district
            // 
            this.col_district.DataPropertyName = "district";
            this.col_district.HeaderText = "Quận";
            this.col_district.Name = "col_district";
            this.col_district.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "b_status";
            this.col_status.FillWeight = 111.6622F;
            this.col_status.HeaderText = "Trạng thái";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_reason
            // 
            this.col_reason.DataPropertyName = "reason";
            this.col_reason.FillWeight = 111.6622F;
            this.col_reason.HeaderText = "Lý do";
            this.col_reason.Name = "col_reason";
            this.col_reason.ReadOnly = true;
            // 
            // btn_detail
            // 
            this.btn_detail.FillWeight = 55.21756F;
            this.btn_detail.HeaderText = "Chi tiết";
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Text = "Xem";
            this.btn_detail.UseColumnTextForButtonValue = true;
            // 
            // fContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 477);
            this.Controls.Add(this.dgvContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fContract";
            this.Text = "fHouses";
            this.Load += new System.EventHandler(this.fContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reason;
        private System.Windows.Forms.DataGridViewButtonColumn btn_detail;
    }
}