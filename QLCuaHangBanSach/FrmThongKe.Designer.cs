namespace QLCuaHangBanSach
{
    partial class FrmThongKe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt5tongdoanhthu = new System.Windows.Forms.TextBox();
            this.txt5soluongsp = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.cbb5ngay1 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbb5thang1 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cbb5nam1 = new System.Windows.Forms.ComboBox();
            this.rdbtimecodinh = new System.Windows.Forms.RadioButton();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.rdbtimetuychon = new System.Windows.Forms.RadioButton();
            this.btn5thongke1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(312, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 383);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.txt5tongdoanhthu);
            this.panel4.Controls.Add(this.txt5soluongsp);
            this.panel4.Controls.Add(this.label35);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(237, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 383);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonHang,
            this.maKh,
            this.ngayLap,
            this.tongTien});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 271);
            this.dataGridView1.TabIndex = 14;
            // 
            // maDonHang
            // 
            this.maDonHang.DataPropertyName = "maDonHang";
            this.maDonHang.HeaderText = "Mã đơn hàng";
            this.maDonHang.Name = "maDonHang";
            this.maDonHang.Width = 120;
            // 
            // maKh
            // 
            this.maKh.DataPropertyName = "maKh";
            this.maKh.HeaderText = "Mã khách hàng";
            this.maKh.Name = "maKh";
            this.maKh.Width = 110;
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.Width = 150;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.Name = "tongTien";
            this.tongTien.Width = 170;
            // 
            // txt5tongdoanhthu
            // 
            this.txt5tongdoanhthu.BackColor = System.Drawing.Color.LightGray;
            this.txt5tongdoanhthu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt5tongdoanhthu.Enabled = false;
            this.txt5tongdoanhthu.Location = new System.Drawing.Point(159, 59);
            this.txt5tongdoanhthu.Name = "txt5tongdoanhthu";
            this.txt5tongdoanhthu.Size = new System.Drawing.Size(104, 19);
            this.txt5tongdoanhthu.TabIndex = 13;
            this.txt5tongdoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt5soluongsp
            // 
            this.txt5soluongsp.BackColor = System.Drawing.Color.LightGray;
            this.txt5soluongsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt5soluongsp.Enabled = false;
            this.txt5soluongsp.Location = new System.Drawing.Point(222, 19);
            this.txt5soluongsp.Name = "txt5soluongsp";
            this.txt5soluongsp.Size = new System.Drawing.Size(41, 19);
            this.txt5soluongsp.TabIndex = 12;
            this.txt5soluongsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.LightGray;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.Location = new System.Drawing.Point(18, 59);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(146, 19);
            this.label35.TabIndex = 11;
            this.label35.Text = "Tổng doanh thu (vnđ): ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.LightGray;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label34.Location = new System.Drawing.Point(18, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(209, 19);
            this.label34.TabIndex = 10;
            this.label34.Text = "Tổng số lượng sản phẩm đã bán: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.cbb5ngay1);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.cbb5thang1);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.cbb5nam1);
            this.panel3.Controls.Add(this.rdbtimecodinh);
            this.panel3.Controls.Add(this.dtpend);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.dtpstart);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.rdbtimetuychon);
            this.panel3.Controls.Add(this.btn5thongke1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 383);
            this.panel3.TabIndex = 2;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label33.Location = new System.Drawing.Point(33, 270);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 19);
            this.label33.TabIndex = 31;
            this.label33.Text = "Ngày:";
            // 
            // cbb5ngay1
            // 
            this.cbb5ngay1.FormattingEnabled = true;
            this.cbb5ngay1.Location = new System.Drawing.Point(94, 270);
            this.cbb5ngay1.Name = "cbb5ngay1";
            this.cbb5ngay1.Size = new System.Drawing.Size(56, 27);
            this.cbb5ngay1.TabIndex = 30;
            this.cbb5ngay1.Text = "all";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label32.Location = new System.Drawing.Point(33, 235);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 19);
            this.label32.TabIndex = 29;
            this.label32.Text = "Tháng:";
            // 
            // cbb5thang1
            // 
            this.cbb5thang1.FormattingEnabled = true;
            this.cbb5thang1.Location = new System.Drawing.Point(95, 232);
            this.cbb5thang1.Name = "cbb5thang1";
            this.cbb5thang1.Size = new System.Drawing.Size(55, 27);
            this.cbb5thang1.TabIndex = 28;
            this.cbb5thang1.Text = "all";
            this.cbb5thang1.TextChanged += new System.EventHandler(this.cbb5thang1_TextChanged_1);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label31.Location = new System.Drawing.Point(33, 196);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 19);
            this.label31.TabIndex = 27;
            this.label31.Text = "Năm:";
            // 
            // cbb5nam1
            // 
            this.cbb5nam1.FormattingEnabled = true;
            this.cbb5nam1.Location = new System.Drawing.Point(95, 192);
            this.cbb5nam1.Name = "cbb5nam1";
            this.cbb5nam1.Size = new System.Drawing.Size(55, 27);
            this.cbb5nam1.TabIndex = 26;
            this.cbb5nam1.Text = "2020";
            // 
            // rdbtimecodinh
            // 
            this.rdbtimecodinh.AutoSize = true;
            this.rdbtimecodinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtimecodinh.Location = new System.Drawing.Point(9, 163);
            this.rdbtimecodinh.Name = "rdbtimecodinh";
            this.rdbtimecodinh.Size = new System.Drawing.Size(140, 23);
            this.rdbtimecodinh.TabIndex = 25;
            this.rdbtimecodinh.TabStop = true;
            this.rdbtimecodinh.Text = "Thời gian cố định";
            this.rdbtimecodinh.UseVisualStyleBackColor = true;
            // 
            // dtpend
            // 
            this.dtpend.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(102, 97);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(103, 25);
            this.dtpend.TabIndex = 24;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label30.Location = new System.Drawing.Point(20, 101);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 19);
            this.label30.TabIndex = 23;
            this.label30.Text = "Đến ngày: ";
            // 
            // dtpstart
            // 
            this.dtpstart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstart.Location = new System.Drawing.Point(102, 55);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(103, 25);
            this.dtpstart.TabIndex = 22;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label29.Location = new System.Drawing.Point(20, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 19);
            this.label29.TabIndex = 21;
            this.label29.Text = "Từ ngày: ";
            // 
            // rdbtimetuychon
            // 
            this.rdbtimetuychon.AutoSize = true;
            this.rdbtimetuychon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtimetuychon.Location = new System.Drawing.Point(9, 15);
            this.rdbtimetuychon.Name = "rdbtimetuychon";
            this.rdbtimetuychon.Size = new System.Drawing.Size(148, 23);
            this.rdbtimetuychon.TabIndex = 20;
            this.rdbtimetuychon.TabStop = true;
            this.rdbtimetuychon.Text = "Thời gian tùy chọn";
            this.rdbtimetuychon.UseVisualStyleBackColor = true;
            // 
            // btn5thongke1
            // 
            this.btn5thongke1.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Button_Background;
            this.btn5thongke1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn5thongke1.Image = global::QLCuaHangBanSach.Properties.Resources.Best;
            this.btn5thongke1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5thongke1.Location = new System.Drawing.Point(66, 329);
            this.btn5thongke1.Name = "btn5thongke1";
            this.btn5thongke1.Size = new System.Drawing.Size(108, 37);
            this.btn5thongke1.TabIndex = 19;
            this.btn5thongke1.Text = "  Thống kê";
            this.btn5thongke1.UseVisualStyleBackColor = true;
            this.btn5thongke1.Click += new System.EventHandler(this.btn5thongke1_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(839, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt5tongdoanhthu;
        private System.Windows.Forms.TextBox txt5soluongsp;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cbb5ngay1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbb5thang1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cbb5nam1;
        private System.Windows.Forms.RadioButton rdbtimecodinh;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton rdbtimetuychon;
        private System.Windows.Forms.Button btn5thongke1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
    }
}