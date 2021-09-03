namespace RentingHouse
{
    partial class fHouseDetailAdmin
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numberPeople = new System.Windows.Forms.TextBox();
            this.txt_rental = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_owner = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_district = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_contract = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contract)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(409, 606);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 40);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(255, 606);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 40);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(557, 606);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 40);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý nhà";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(130, 255);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(551, 119);
            this.txt_description.TabIndex = 30;
            this.txt_description.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số người";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Diện tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID";
            // 
            // txt_numberPeople
            // 
            this.txt_numberPeople.Location = new System.Drawing.Point(130, 158);
            this.txt_numberPeople.Name = "txt_numberPeople";
            this.txt_numberPeople.Size = new System.Drawing.Size(184, 22);
            this.txt_numberPeople.TabIndex = 20;
            // 
            // txt_rental
            // 
            this.txt_rental.Location = new System.Drawing.Point(130, 130);
            this.txt_rental.Name = "txt_rental";
            this.txt_rental.Size = new System.Drawing.Size(184, 22);
            this.txt_rental.TabIndex = 21;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(130, 71);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(184, 22);
            this.txt_id.TabIndex = 22;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(130, 102);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(184, 22);
            this.txt_area.TabIndex = 23;
            // 
            // txt_owner
            // 
            this.txt_owner.Location = new System.Drawing.Point(130, 186);
            this.txt_owner.Name = "txt_owner";
            this.txt_owner.Size = new System.Drawing.Size(184, 22);
            this.txt_owner.TabIndex = 23;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(422, 71);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(259, 22);
            this.txt_address.TabIndex = 22;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(422, 158);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(259, 22);
            this.txt_status.TabIndex = 21;
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(422, 186);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(259, 22);
            this.txt_reason.TabIndex = 20;
            // 
            // txt_district
            // 
            this.txt_district.Location = new System.Drawing.Point(422, 99);
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(259, 22);
            this.txt_district.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Lý do";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tình trạng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Chủ nhà";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Quận";
            // 
            // dgv_contract
            // 
            this.dgv_contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contract.Location = new System.Drawing.Point(130, 403);
            this.dgv_contract.Name = "dgv_contract";
            this.dgv_contract.ReadOnly = true;
            this.dgv_contract.RowTemplate.Height = 24;
            this.dgv_contract.Size = new System.Drawing.Size(551, 156);
            this.dgv_contract.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Lịch sử gia hạn";
            // 
            // fHouseDetailAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 658);
            this.Controls.Add(this.dgv_contract);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_district);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_numberPeople);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_rental);
            this.Controls.Add(this.txt_owner);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Name = "fHouseDetailAdmin";
            this.Text = "fHouseDetailAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numberPeople;
        private System.Windows.Forms.TextBox txt_rental;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_owner;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_contract;
        private System.Windows.Forms.Label label9;
    }
}