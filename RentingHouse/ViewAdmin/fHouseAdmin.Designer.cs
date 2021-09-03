namespace RentingHouse
{
    partial class fHouseAdmin
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
            this.dgvHouses = new System.Windows.Forms.DataGridView();
            this.btn_login = new System.Windows.Forms.Button();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_district_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_number_people = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_houses = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHouses
            // 
            this.dgvHouses.AllowUserToAddRows = false;
            this.dgvHouses.AllowUserToDeleteRows = false;
            this.dgvHouses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dgvHouses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHouses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHouses.ColumnHeadersHeight = 40;
            this.dgvHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_address,
            this.col_district_name,
            this.col_area,
            this.col_rental,
            this.col_number_people,
            this.owner,
            this.col_btn_houses});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHouses.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHouses.EnableHeadersVisualStyles = false;
            this.dgvHouses.Location = new System.Drawing.Point(12, 60);
            this.dgvHouses.Name = "dgvHouses";
            this.dgvHouses.RowHeadersVisible = false;
            this.dgvHouses.RowTemplate.Height = 50;
            this.dgvHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouses.Size = new System.Drawing.Size(1107, 405);
            this.dgvHouses.TabIndex = 5;
            this.dgvHouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHouses_CellContentClick);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(1030, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(173, 35);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Thêm";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.FillWeight = 64.79891F;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "h_address";
            this.col_address.FillWeight = 243.6549F;
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // col_district_name
            // 
            this.col_district_name.DataPropertyName = "name";
            this.col_district_name.FillWeight = 81.92433F;
            this.col_district_name.HeaderText = "Quận";
            this.col_district_name.Name = "col_district_name";
            this.col_district_name.ReadOnly = true;
            // 
            // col_area
            // 
            this.col_area.DataPropertyName = "area";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.col_area.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_area.FillWeight = 81.92433F;
            this.col_area.HeaderText = "Diện tích";
            this.col_area.Name = "col_area";
            this.col_area.ReadOnly = true;
            // 
            // col_rental
            // 
            this.col_rental.DataPropertyName = "rental";
            this.col_rental.FillWeight = 81.92433F;
            this.col_rental.HeaderText = "Giá";
            this.col_rental.Name = "col_rental";
            this.col_rental.ReadOnly = true;
            // 
            // col_number_people
            // 
            this.col_number_people.DataPropertyName = "number_people";
            this.col_number_people.FillWeight = 81.92433F;
            this.col_number_people.HeaderText = "Số lượng người";
            this.col_number_people.Name = "col_number_people";
            this.col_number_people.ReadOnly = true;
            // 
            // owner
            // 
            this.owner.DataPropertyName = "h_user_id";
            this.owner.FillWeight = 81.92433F;
            this.owner.HeaderText = "Mã Chủ nhà";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            // 
            // col_btn_houses
            // 
            this.col_btn_houses.FillWeight = 81.92433F;
            this.col_btn_houses.HeaderText = "Chi tiết";
            this.col_btn_houses.Name = "col_btn_houses";
            this.col_btn_houses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_houses.Text = "Xem";
            this.col_btn_houses.UseColumnTextForButtonValue = true;
            // 
            // fHouseAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 477);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.dgvHouses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fHouseAdmin";
            this.Text = "fHouseAdmin";
            this.Load += new System.EventHandler(this.fHouseAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHouses;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_district_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_number_people;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_houses;
    }
}