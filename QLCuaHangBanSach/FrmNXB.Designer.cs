namespace QLCuaHangBanSach
{
    partial class FrmNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNXB));
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.maNhaxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(171, 124);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(269, 26);
            this.txtdiachi.TabIndex = 4;
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(171, 28);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(269, 26);
            this.txtmanxb.TabIndex = 4;
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(171, 72);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(269, 26);
            this.txttennxb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhà xuất bản: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhà xuất bản: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.cbb);
            this.panel4.Controls.Add(this.btnTimkiem);
            this.panel4.Controls.Add(this.btndong);
            this.panel4.Controls.Add(this.btnhienthi);
            this.panel4.Controls.Add(this.btnthem);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.btnxoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(506, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 194);
            this.panel4.TabIndex = 1;
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "Mã nhà xuất bản",
            "Tên nhà xuất bản"});
            this.cbb.Location = new System.Drawing.Point(168, 55);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(134, 27);
            this.cbb.TabIndex = 3;
            this.cbb.Text = "Mã nhà xuất bản";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.BackgroundImage")));
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Image = global::QLCuaHangBanSach.Properties.Resources.Search;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(168, 16);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(134, 34);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "    Tìm kiếm theo:";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btndong
            // 
            this.btndong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndong.BackgroundImage")));
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndong.Image = global::QLCuaHangBanSach.Properties.Resources.Exit;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(191, 142);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(111, 36);
            this.btndong.TabIndex = 0;
            this.btndong.Text = "   Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhienthi.BackgroundImage")));
            this.btnhienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhienthi.Image = global::QLCuaHangBanSach.Properties.Resources.Refresh;
            this.btnhienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhienthi.Location = new System.Drawing.Point(30, 20);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(111, 34);
            this.btnhienthi.TabIndex = 0;
            this.btnhienthi.Text = "  Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Image = global::QLCuaHangBanSach.Properties.Resources.Add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(30, 62);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(111, 34);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsua.BackgroundImage")));
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Image = global::QLCuaHangBanSach.Properties.Resources.Edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(30, 102);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(111, 34);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::QLCuaHangBanSach.Properties.Resources.Delete;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(30, 142);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(111, 34);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 194);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txtdiachi);
            this.panel3.Controls.Add(this.txtmanxb);
            this.panel3.Controls.Add(this.txttennxb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 194);
            this.panel3.TabIndex = 0;
            // 
            // dgvNXB
            // 
            this.dgvNXB.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhaxb,
            this.tenNhaxb,
            this.diaChi});
            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNXB.Location = new System.Drawing.Point(3, 283);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(833, 203);
            this.dgvNXB.TabIndex = 3;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // maNhaxb
            // 
            this.maNhaxb.DataPropertyName = "maNhaxb";
            this.maNhaxb.HeaderText = "Mã nhà xuất bản";
            this.maNhaxb.Name = "maNhaxb";
            this.maNhaxb.Width = 200;
            // 
            // tenNhaxb
            // 
            this.tenNhaxb.DataPropertyName = "tenNhaxb";
            this.tenNhaxb.HeaderText = "Tên nhà xuất bản";
            this.tenNhaxb.Name = "tenNhaxb";
            this.tenNhaxb.Width = 300;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 280;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvNXB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 489);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhà xuất bản";
            // 
            // FrmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(839, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNXB";
            this.Load += new System.EventHandler(this.FrmNXB_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.Button btnhienthi;
    }
}