namespace RentingHouse
{
    partial class fHouses
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvHouses = new System.Windows.Forms.DataGridView();
            this.btn_rentHouse = new System.Windows.Forms.Button();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_district_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_number_people = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_checkbox_houses = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Tìm kiếm...";
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
            this.col_district_name,
            this.col_area,
            this.col_rental,
            this.col_number_people,
            this.col_checkbox_houses});
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
            // 
            // btn_rentHouse
            // 
            this.btn_rentHouse.Location = new System.Drawing.Point(958, 12);
            this.btn_rentHouse.Name = "btn_rentHouse";
            this.btn_rentHouse.Size = new System.Drawing.Size(146, 31);
            this.btn_rentHouse.TabIndex = 6;
            this.btn_rentHouse.Text = "Đăng ký thuê";
            this.btn_rentHouse.UseVisualStyleBackColor = true;
            this.btn_rentHouse.Click += new System.EventHandler(this.btn_rentHouse_Click);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_district_name
            // 
            this.col_district_name.DataPropertyName = "name";
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
            this.col_area.HeaderText = "Diện tích";
            this.col_area.Name = "col_area";
            this.col_area.ReadOnly = true;
            // 
            // col_rental
            // 
            this.col_rental.DataPropertyName = "rental";
            this.col_rental.HeaderText = "Giá";
            this.col_rental.Name = "col_rental";
            this.col_rental.ReadOnly = true;
            // 
            // col_number_people
            // 
            this.col_number_people.DataPropertyName = "number_people";
            this.col_number_people.HeaderText = "Số lượng người";
            this.col_number_people.Name = "col_number_people";
            this.col_number_people.ReadOnly = true;
            // 
            // col_checkbox_houses
            // 
            this.col_checkbox_houses.FalseValue = "F";
            this.col_checkbox_houses.HeaderText = "Chọn nhà";
            this.col_checkbox_houses.Name = "col_checkbox_houses";
            this.col_checkbox_houses.TrueValue = "T";
            // 
            // fHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 477);
            this.Controls.Add(this.btn_rentHouse);
            this.Controls.Add(this.dgvHouses);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fHouses";
            this.Text = "fHouses";
            this.Load += new System.EventHandler(this.fHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvHouses;
        private System.Windows.Forms.Button btn_rentHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_district_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_number_people;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_checkbox_houses;
    }
}