namespace QLCuaHangBanSach
{
    partial class FrmDanhSachSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbsapxep = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbtimkiem = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbsapxep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // cbbsapxep
            // 
            this.cbbsapxep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbsapxep.FormattingEnabled = true;
            this.cbbsapxep.Items.AddRange(new object[] {
            "Sắp xếp theo giá tăng dần",
            "Sắp xếp theo giá giảm dần",
            "Sắp xếp theo tên sách A->Z",
            "Sắp xếp theo tên sách Z->A"});
            this.cbbsapxep.Location = new System.Drawing.Point(0, 66);
            this.cbbsapxep.Name = "cbbsapxep";
            this.cbbsapxep.Size = new System.Drawing.Size(229, 27);
            this.cbbsapxep.TabIndex = 0;
            this.cbbsapxep.Text = "Sắp xếp theo:";
            this.cbbsapxep.TextChanged += new System.EventHandler(this.cbbsapxep_TextChanged);
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.theLoai,
            this.giaBan,
            this.tacGia,
            this.nhaXb,
            this.soLuong});
            this.dgvDanhSachSanPham.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(0, 91);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(636, 298);
            this.dgvDanhSachSanPham.TabIndex = 1;
            this.dgvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellClick);
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã sách";
            this.maSach.Name = "maSach";
            this.maSach.Width = 50;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 110;
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
            this.giaBan.Width = 80;
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác giả";
            this.tacGia.Name = "tacGia";
            // 
            // nhaXb
            // 
            this.nhaXb.DataPropertyName = "nhaXb";
            this.nhaXb.HeaderText = "Nhà xuất bản";
            this.nhaXb.Name = "nhaXb";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng tồn";
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnxem);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnhienthi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 94);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = global::QLCuaHangBanSach.Properties.Resources.Delete;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(700, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "Đóng    ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnxem
            // 
            this.btnxem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxem.BackgroundImage")));
            this.btnxem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxem.Image = global::QLCuaHangBanSach.Properties.Resources.Price_list;
            this.btnxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxem.Location = new System.Drawing.Point(252, 22);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(141, 52);
            this.btnxem.TabIndex = 0;
            this.btnxem.Text = "Xem giỏ hàng   ";
            this.btnxem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Image = global::QLCuaHangBanSach.Properties.Resources.Add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(456, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(133, 52);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm vào giỏ  ";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhienthi.BackgroundImage")));
            this.btnhienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhienthi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhienthi.Image = global::QLCuaHangBanSach.Properties.Resources.List;
            this.btnhienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhienthi.Location = new System.Drawing.Point(56, 22);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(114, 52);
            this.btnhienthi.TabIndex = 0;
            this.btnhienthi.Text = "      Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.cbbtimkiem);
            this.panel3.Controls.Add(this.btntimkiem);
            this.panel3.Location = new System.Drawing.Point(639, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 150);
            this.panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(18, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Nhập dữ liệu cần tìm";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // cbbtimkiem
            // 
            this.cbbtimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbtimkiem.FormattingEnabled = true;
            this.cbbtimkiem.Items.AddRange(new object[] {
            "Tên sách",
            "Thể loại",
            "Tác giả"});
            this.cbbtimkiem.Location = new System.Drawing.Point(18, 51);
            this.cbbtimkiem.Name = "cbbtimkiem";
            this.cbbtimkiem.Size = new System.Drawing.Size(170, 27);
            this.cbbtimkiem.TabIndex = 1;
            this.cbbtimkiem.Text = "Tên sách";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntimkiem.BackgroundImage")));
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntimkiem.Image = global::QLCuaHangBanSach.Properties.Resources.Search;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(18, 3);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(170, 36);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "      Tìm kiếm theo";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(639, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 148);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(839, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDanhSachSanPham);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDanhSachSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachSanPham";
            this.Load += new System.EventHandler(this.FrmDanhSachSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbsapxep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbtimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXb;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
    }
}