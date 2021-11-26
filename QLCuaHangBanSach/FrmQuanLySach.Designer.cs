namespace QLCuaHangBanSach
{
    partial class FrmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLySach));
            this.dgvQLSach = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbtenNxb = new System.Windows.Forms.ComboBox();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtHinhanh = new System.Windows.Forms.TextBox();
            this.btnChontep = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLSach
            // 
            this.dgvQLSach.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvQLSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQLSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.theLoai,
            this.giaBan,
            this.tacGia,
            this.nhaXb,
            this.soLuong});
            this.dgvQLSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLSach.Location = new System.Drawing.Point(0, 317);
            this.dgvQLSach.Name = "dgvQLSach";
            this.dgvQLSach.Size = new System.Drawing.Size(839, 172);
            this.dgvQLSach.TabIndex = 0;
            this.dgvQLSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSach_CellClick);
            this.dgvQLSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSach_CellContentClick);
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã sách";
            this.maSach.Name = "maSach";
            this.maSach.Width = 80;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 150;
            // 
            // theLoai
            // 
            this.theLoai.DataPropertyName = "theLoai";
            this.theLoai.HeaderText = "Thể loại";
            this.theLoai.Name = "theLoai";
            // 
            // giaBan
            // 
            this.giaBan.DataPropertyName = "giaBan";
            this.giaBan.HeaderText = "Giá bán";
            this.giaBan.Name = "giaBan";
            this.giaBan.Width = 90;
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác giả";
            this.tacGia.Name = "tacGia";
            this.tacGia.Width = 120;
            // 
            // nhaXb
            // 
            this.nhaXb.DataPropertyName = "nhaXb";
            this.nhaXb.HeaderText = "Nhà xuất bản";
            this.nhaXb.Name = "nhaXb";
            this.nhaXb.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng tồn";
            this.soLuong.Name = "soLuong";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbtenNxb);
            this.panel1.Controls.Add(this.ptb);
            this.panel1.Controls.Add(this.txtTensach);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.txtHinhanh);
            this.panel1.Controls.Add(this.btnChontep);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMasach);
            this.panel1.Controls.Add(this.txtTheloai);
            this.panel1.Controls.Add(this.txtGiaban);
            this.panel1.Controls.Add(this.txtTacgia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 243);
            this.panel1.TabIndex = 2;
            // 
            // cmbtenNxb
            // 
            this.cmbtenNxb.FormattingEnabled = true;
            this.cmbtenNxb.Location = new System.Drawing.Point(105, 188);
            this.cmbtenNxb.Name = "cmbtenNxb";
            this.cmbtenNxb.Size = new System.Drawing.Size(188, 27);
            this.cmbtenNxb.TabIndex = 6;
            // 
            // ptb
            // 
            this.ptb.Location = new System.Drawing.Point(399, 88);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(200, 148);
            this.ptb.TabIndex = 5;
            this.ptb.TabStop = false;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(105, 52);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(188, 26);
            this.txtTensach.TabIndex = 4;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(414, 18);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(185, 26);
            this.txtSoluong.TabIndex = 4;
            // 
            // txtHinhanh
            // 
            this.txtHinhanh.Location = new System.Drawing.Point(414, 55);
            this.txtHinhanh.Name = "txtHinhanh";
            this.txtHinhanh.Size = new System.Drawing.Size(185, 26);
            this.txtHinhanh.TabIndex = 4;
            // 
            // btnChontep
            // 
            this.btnChontep.Location = new System.Drawing.Point(318, 94);
            this.btnChontep.Name = "btnChontep";
            this.btnChontep.Size = new System.Drawing.Size(75, 28);
            this.btnChontep.TabIndex = 0;
            this.btnChontep.Text = "Chọn tệp";
            this.btnChontep.UseVisualStyleBackColor = true;
            this.btnChontep.Click += new System.EventHandler(this.btnChontep_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(105, 18);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(188, 26);
            this.txtMasach.TabIndex = 4;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(105, 86);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(188, 26);
            this.txtTheloai.TabIndex = 4;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(105, 120);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(188, 26);
            this.txtGiaban.TabIndex = 4;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(105, 154);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(188, 26);
            this.txtTacgia.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(314, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng tồn: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(314, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hình ảnh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.cbb);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnHienthi);
            this.panel2.Location = new System.Drawing.Point(622, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 240);
            this.panel2.TabIndex = 3;
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại",
            "Tác giả",
            "Nhà xuất bản"});
            this.cbb.Location = new System.Drawing.Point(31, 164);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(162, 27);
            this.cbb.TabIndex = 1;
            this.cbb.Text = "Mã sách";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExport.Image = global::QLCuaHangBanSach.Properties.Resources.Open_folder;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(56, 93);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 32);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "   Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QLCuaHangBanSach.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(115, 53);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 32);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::QLCuaHangBanSach.Properties.Resources.Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(115, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QLCuaHangBanSach.Properties.Resources.Edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(12, 53);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 32);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.BackgroundImage")));
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Image = global::QLCuaHangBanSach.Properties.Resources.Search;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(31, 129);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(162, 29);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = " Tìm kiếm theo:";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDong.BackgroundImage")));
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Image = global::QLCuaHangBanSach.Properties.Resources.Exit;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(65, 197);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 32);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "   Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.Đóng_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHienthi.BackgroundImage")));
            this.btnHienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHienthi.Image = global::QLCuaHangBanSach.Properties.Resources.Refresh;
            this.btnHienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienthi.Location = new System.Drawing.Point(12, 13);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(89, 32);
            this.btnHienthi.TabIndex = 0;
            this.btnHienthi.Text = "    Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(335, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Sách";
            // 
            // FrmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(839, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQLSach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLySach";
            this.Load += new System.EventHandler(this.FrmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtTheloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.TextBox txtHinhanh;
        private System.Windows.Forms.Button btnChontep;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXb;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.ComboBox cmbtenNxb;
    }
}