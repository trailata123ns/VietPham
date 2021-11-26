using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanSach
{
    public partial class FrmThongTinCaNhan : Form
    {
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }

        BLLKhachHang bllkh = new BLLKhachHang();
        public FrmThongTinCaNhan(String user) : this()
        {
            txtuser2.Text = user;
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bllkh.getThongTin(txtuser2.Text);
            txtpass2.Text = dt.Rows[0][0].ToString();
            txtMaKh.Text = dt.Rows[0][1].ToString();
            txtTenKh.Text = dt.Rows[0][2].ToString();
            txtSdt.Text = dt.Rows[0][3].ToString();
            txtDiachi.Text = dt.Rows[0][4].ToString();
            dtpNgaysinh.Text = dt.Rows[0][5].ToString();
            txtuser2.Enabled = false;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaKh.Text.Equals("") || txtTenKh.Text.Equals("") || txtuser2.Text.Equals("") || txtpass2.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            else if (txtpass2.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có 6 ký tự trở lên");
                return;
            }
            else
            {
                bllkh.updateKh(txtMaKh.Text, txtTenKh.Text, txtSdt.Text, txtDiachi.Text, dtpNgaysinh.Text, txtuser2.Text, txtpass2.Text);
                FrmThongTinCaNhan_Load(sender, e);
            }
        }
    }
}
