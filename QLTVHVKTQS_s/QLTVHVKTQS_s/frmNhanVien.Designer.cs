namespace QLTVHVKTQS_s
{
    partial class frmNhanVien
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.dateNS);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(109, 248);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 26);
            this.txtSDT.TabIndex = 9;
            // 
            // cbGT
            // 
            this.cbGT.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(109, 196);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(200, 26);
            this.cbGT.TabIndex = 8;
            // 
            // dateNS
            // 
            this.dateNS.CustomFormat = "dd/mm/yyyy";
            this.dateNS.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNS.Location = new System.Drawing.Point(109, 149);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(200, 26);
            this.dateNS.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(109, 100);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(109, 51);
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
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // dgNhanVien
            // 
            this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgNhanVien.Location = new System.Drawing.Point(366, 145);
            this.dgNhanVien.Name = "dgNhanVien";
            this.dgNhanVien.Size = new System.Drawing.Size(631, 332);
            this.dgNhanVien.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(366, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(512, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Họ Tên",
            "Giới Tính"});
            this.comboBox1.Location = new System.Drawing.Point(385, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(341, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(165, 26);
            this.txtTimKiem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // btnTK
            // 
            this.btnTK.Image = global::QLTVHVKTQS_s.Properties.Resources.system_search_32;
            this.btnTK.Location = new System.Drawing.Point(512, 19);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(93, 39);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLTVHVKTQS_s.Properties.Resources.trash_32;
            this.btnXoa.Location = new System.Drawing.Point(260, 19);
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
            this.btnLuu.Location = new System.Drawing.Point(179, 19);
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
            this.btnSua.Location = new System.Drawing.Point(98, 19);
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
            this.btnThem.Location = new System.Drawing.Point(17, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgNhanVien);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.ShowInTaskbar = false;
            this.Text = "Nhân Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.DateTimePicker dateNS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
    }
}

