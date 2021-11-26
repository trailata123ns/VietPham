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
    public partial class FrmQuanLyNguoiDung : Form
    {
        BLLKhachHang bllkhachhang = new BLLKhachHang();
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            dgvQLnguoidung.DataSource = bllkhachhang.getKh();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text.Equals("") || txttenkh.Text.Equals("") || txtuser.Text.Equals("") || txtpass.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            else if (txtpass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có 6 ký tự trở lên");
                return;
            }
            bllkhachhang.insertKh(txtmakh.Text, txttenkh.Text, txtsdt.Text, txtdiachi.Text, dtp.Value.ToShortDateString(), txtuser.Text, txtpass.Text);
            FrmQuanLyNguoiDung_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text.Equals("") || txttenkh.Text.Equals("") || txtuser.Text.Equals("") || txtpass.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            else if (txtpass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có 6 ký tự trở lên");
                return;
            }
            bllkhachhang.updateKh(txtmakh.Text, txttenkh.Text, txtsdt.Text, txtdiachi.Text, dtp.Value.ToShortDateString(), txtuser.Text, txtpass.Text);
            FrmQuanLyNguoiDung_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text.Equals("")|| txtuser.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            bllkhachhang.deleteKh(txtuser.Text, txtmakh.Text);
            FrmQuanLyNguoiDung_Load(sender, e);
        }

        private void dgvQLnguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row1 = e.RowIndex;

            txtuser.Text = dgvQLnguoidung.Rows[row1].Cells[0].Value.ToString();
            txtpass.Text = dgvQLnguoidung.Rows[row1].Cells[1].Value.ToString();
            txtmakh.Text = dgvQLnguoidung.Rows[row1].Cells[2].Value.ToString();
            txttenkh.Text = dgvQLnguoidung.Rows[row1].Cells[3].Value.ToString();
            txtsdt.Text = dgvQLnguoidung.Rows[row1].Cells[4].Value.ToString();
            dtp.Text = dgvQLnguoidung.Rows[row1].Cells[6].Value.ToString();
            txtdiachi.Text = dgvQLnguoidung.Rows[row1].Cells[5].Value.ToString();

        }

       
    }
}
