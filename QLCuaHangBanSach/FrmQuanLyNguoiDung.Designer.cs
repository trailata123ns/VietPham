namespace QLCuaHangBanSach
{
    partial class FrmQuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNguoiDung));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvQLnguoidung = new System.Windows.Forms.DataGridView();
            this.userr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndong = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLnguoidung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvQLnguoidung, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvQLnguoidung
            // 
            this.dgvQLnguoidung.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvQLnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLnguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userr,
            this.pass,
            this.maKh,
            this.tenKh,
            this.std,
            this.diaChi,
            this.ngaySinh});
            this.dgvQLnguoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLnguoidung.Location = new System.Drawing.Point(3, 333);
            this.dgvQLnguoidung.Name = "dgvQLnguoidung";
            this.dgvQLnguoidung.Size = new System.Drawing.Size(833, 153);
            this.dgvQLnguoidung.TabIndex = 3;
            this.dgvQLnguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLnguoidung_CellClick);
            // 
            // userr
            // 
            this.userr.DataPropertyName = "userr";
            this.userr.HeaderText = "Username";
            this.userr.Name = "userr";
            this.userr.Width = 80;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Password";
            this.pass.Name = "pass";
            // 
            // maKh
            // 
            this.maKh.DataPropertyName = "maKh";
            this.maKh.HeaderText = "Mã khách hàng";
            this.maKh.Name = "maKh";
            this.maKh.Width = 80;
            // 
            // tenKh
            // 
            this.tenKh.DataPropertyName = "tenKh";
            this.tenKh.HeaderText = "Tên khách hàng";
            this.tenKh.Name = "tenKh";
            this.tenKh.Width = 150;
            // 
            // std
            // 
            this.std.DataPropertyName = "sdt";
            this.std.HeaderText = "Số điện thoại";
            this.std.Name = "std";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 150;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(316, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý người dùng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 244);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.btndong);
            this.panel4.Controls.Add(this.btnthem);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.btnxoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(656, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 244);
            this.panel4.TabIndex = 1;
            // 
            // btndong
            // 
            this.btndong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndong.BackgroundImage")));
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndong.Image = global::QLCuaHangBanSach.Properties.Resources.Exit;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(30, 184);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(111, 36);
            this.btndong.TabIndex = 0;
            this.btndong.Text = " Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Image = global::QLCuaHangBanSach.Properties.Resources.Add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(30, 28);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(111, 34);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = " Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsua.BackgroundImage")));
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Image = global::QLCuaHangBanSach.Properties.Resources.Edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(30, 76);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(111, 34);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = " Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::QLCuaHangBanSach.Properties.Resources.Delete;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(30, 124);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(111, 34);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = " Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.dtp);
            this.panel3.Controls.Add(this.txttenkh);
            this.panel3.Controls.Add(this.txtmakh);
            this.panel3.Controls.Add(this.txtsdt);
            this.panel3.Controls.Add(this.txtdiachi);
            this.panel3.Controls.Add(this.txtuser);
            this.panel3.Controls.Add(this.txtpass);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 244);
            this.panel3.TabIndex = 0;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(433, 136);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(187, 26);
            this.dtp.TabIndex = 5;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(119, 184);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(190, 26);
            this.txttenkh.TabIndex = 4;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(119, 136);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(190, 26);
            this.txtmakh.TabIndex = 4;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(433, 40);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(187, 26);
            this.txtsdt.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(433, 84);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(187, 26);
            this.txtdiachi.TabIndex = 4;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(119, 40);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(190, 26);
            this.txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(119, 84);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(190, 26);
            this.txtpass.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã khách hàng: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 0;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLnguoidung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridView dgvQLnguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn userr;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn std;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}