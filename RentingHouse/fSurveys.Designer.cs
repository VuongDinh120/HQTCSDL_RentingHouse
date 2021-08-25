namespace RentingHouse
{
    partial class fSurveys
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSurveys = new System.Windows.Forms.DataGridView();
            this.btnCreateSurvey = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.house_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSurveys
            // 
            this.dgvSurveys.AllowUserToAddRows = false;
            this.dgvSurveys.AllowUserToDeleteRows = false;
            this.dgvSurveys.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dgvSurveys.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSurveys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSurveys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSurveys.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvSurveys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSurveys.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSurveys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSurveys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSurveys.ColumnHeadersHeight = 40;
            this.dgvSurveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSurveys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.detail,
            this.s_status,
            this.house_id,
            this.s_user_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSurveys.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSurveys.EnableHeadersVisualStyles = false;
            this.dgvSurveys.Location = new System.Drawing.Point(9, 49);
            this.dgvSurveys.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSurveys.Name = "dgvSurveys";
            this.dgvSurveys.RowHeadersVisible = false;
            this.dgvSurveys.RowTemplate.Height = 50;
            this.dgvSurveys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSurveys.Size = new System.Drawing.Size(830, 329);
            this.dgvSurveys.TabIndex = 6;
            // 
            // btnCreateSurvey
            // 
            this.btnCreateSurvey.Location = new System.Drawing.Point(713, 11);
            this.btnCreateSurvey.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSurvey.Name = "btnCreateSurvey";
            this.btnCreateSurvey.Size = new System.Drawing.Size(104, 22);
            this.btnCreateSurvey.TabIndex = 7;
            this.btnCreateSurvey.Text = "Tạo khảo sát";
            this.btnCreateSurvey.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // detail
            // 
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Chi tiết";
            this.detail.Name = "detail";
            // 
            // s_status
            // 
            this.s_status.DataPropertyName = "s_status";
            this.s_status.HeaderText = "Trạng thái";
            this.s_status.Name = "s_status";
            // 
            // house_id
            // 
            this.house_id.DataPropertyName = "h_address";
            this.house_id.HeaderText = "Địa chỉ";
            this.house_id.Name = "house_id";
            // 
            // s_user_id
            // 
            this.s_user_id.DataPropertyName = "fullname";
            this.s_user_id.HeaderText = "Người cho thuê";
            this.s_user_id.Name = "s_user_id";
            // 
            // fSurveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(848, 388);
            this.Controls.Add(this.btnCreateSurvey);
            this.Controls.Add(this.dgvSurveys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fSurveys";
            this.Text = "fSurveys";
            this.Load += new System.EventHandler(this.fSurveys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSurveys;
        private System.Windows.Forms.Button btnCreateSurvey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn house_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_user_id;
    }
}