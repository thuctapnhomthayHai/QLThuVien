namespace QLTVHVKTQS_s
{
    partial class frmMuonTra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgMuonTra = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCTMT = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuonTra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.dateNS);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 333);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbGT
            // 
            this.cbGT.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(120, 241);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(200, 26);
            this.cbGT.TabIndex = 8;
            // 
            // dateNS
            // 
            this.dateNS.CustomFormat = "dd/mm/yyyy";
            this.dateNS.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNS.Location = new System.Drawing.Point(120, 144);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(200, 26);
            this.dateNS.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(120, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(120, 46);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 26);
            this.txtMaNV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã NVGD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Hẹn Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Phiếu Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Độc Giả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dgMuonTra
            // 
            this.dgMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgMuonTra.Location = new System.Drawing.Point(380, 133);
            this.dgMuonTra.Name = "dgMuonTra";
            this.dgMuonTra.Size = new System.Drawing.Size(610, 332);
            this.dgMuonTra.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnCTMT);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(380, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QLTVHVKTQS_s.Properties.Resources.close_321;
            this.btnHuy.Location = new System.Drawing.Point(506, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnCTMT
            // 
            this.btnCTMT.Image = global::QLTVHVKTQS_s.Properties.Resources.Save_as;
            this.btnCTMT.Location = new System.Drawing.Point(361, 19);
            this.btnCTMT.Name = "btnCTMT";
            this.btnCTMT.Size = new System.Drawing.Size(139, 39);
            this.btnCTMT.TabIndex = 4;
            this.btnCTMT.Text = "Chi Tiết Mượn Trả";
            this.btnCTMT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCTMT.UseVisualStyleBackColor = true;
            this.btnCTMT.Click += new System.EventHandler(this.btnCTMT_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLTVHVKTQS_s.Properties.Resources.trash_32;
            this.btnXoa.Location = new System.Drawing.Point(280, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLTVHVKTQS_s.Properties.Resources.Checkmark_32;
            this.btnLuu.Location = new System.Drawing.Point(199, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLTVHVKTQS_s.Properties.Resources.ce;
            this.btnSua.Location = new System.Drawing.Point(118, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLTVHVKTQS_s.Properties.Resources.if_sign_add_299068;
            this.btnThem.Location = new System.Drawing.Point(37, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "MƯỢN TRẢ";
            // 
            // frmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgMuonTra);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuonTra";
            this.Text = "frmMuonTra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuonTra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.DateTimePicker dateNS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCTMT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
    }
}