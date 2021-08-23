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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvHouses = new System.Windows.Forms.DataGridView();
            this.h_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_people = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(751, 12);
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dgvHouses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvHouses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvHouses.ColumnHeadersHeight = 40;
            this.dgvHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h_description,
            this.id,
            this.h_address,
            this.area,
            this.rental,
            this.number_people,
            this.district_id,
            this.h_status,
            this.h_user_id});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHouses.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvHouses.EnableHeadersVisualStyles = false;
            this.dgvHouses.Location = new System.Drawing.Point(12, 60);
            this.dgvHouses.Name = "dgvHouses";
            this.dgvHouses.ReadOnly = true;
            this.dgvHouses.RowHeadersVisible = false;
            this.dgvHouses.RowTemplate.Height = 50;
            this.dgvHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouses.Size = new System.Drawing.Size(1107, 405);
            this.dgvHouses.TabIndex = 5;
            // 
            // h_description
            // 
            this.h_description.DataPropertyName = "h_description";
            this.h_description.HeaderText = "Mô tả";
            this.h_description.Name = "h_description";
            this.h_description.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // h_address
            // 
            this.h_address.DataPropertyName = "h_address";
            this.h_address.HeaderText = "Địa chỉ";
            this.h_address.Name = "h_address";
            this.h_address.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0";
            this.area.DefaultCellStyle = dataGridViewCellStyle15;
            this.area.HeaderText = "Diện tích";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // rental
            // 
            this.rental.DataPropertyName = "rental";
            this.rental.HeaderText = "Giá";
            this.rental.Name = "rental";
            this.rental.ReadOnly = true;
            // 
            // number_people
            // 
            this.number_people.DataPropertyName = "number_people";
            this.number_people.HeaderText = "Số lượng người ở";
            this.number_people.Name = "number_people";
            this.number_people.ReadOnly = true;
            // 
            // district_id
            // 
            this.district_id.DataPropertyName = "district_id";
            this.district_id.HeaderText = "Quận";
            this.district_id.Name = "district_id";
            this.district_id.ReadOnly = true;
            // 
            // h_status
            // 
            this.h_status.DataPropertyName = "h_status";
            this.h_status.HeaderText = "Tình trạng";
            this.h_status.Name = "h_status";
            this.h_status.ReadOnly = true;
            // 
            // h_user_id
            // 
            this.h_user_id.DataPropertyName = "h_user_id";
            this.h_user_id.HeaderText = "Người cho thuê";
            this.h_user_id.Name = "h_user_id";
            this.h_user_id.ReadOnly = true;
            // 
            // fHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 477);
            this.Controls.Add(this.dgvHouses);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn h_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_people;
        private System.Windows.Forms.DataGridViewTextBoxColumn district_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_user_id;
    }
}