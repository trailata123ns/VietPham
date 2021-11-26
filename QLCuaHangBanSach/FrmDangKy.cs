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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        BLLKhachHang bllkhachhang = new BLLKhachHang();

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap= new FrmDangNhap();
            frmDangNhap.Show();
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
            bllkhachhang.insertKh(txtMaKh.Text, txtTenKh.Text, txtSdt.Text, txtDiachi.Text, dtpNgaysinh.Value.ToShortDateString(), txtuser2.Text, txtpass2.Text);
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            //Console.Write(dtpNgaysinh.Value);
        }
    }
}
