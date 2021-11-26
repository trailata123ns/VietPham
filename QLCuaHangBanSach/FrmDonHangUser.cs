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
    public partial class FrmDonHangUser : Form
    {
        public FrmDonHangUser()
        {
            InitializeComponent();
        }
        String maKh;
        public FrmDonHangUser(String maKh):this()
        {
            this.maKh = maKh;
        }
        BLLGioHang bllgh = new BLLGioHang();
        BLLDonHang blldh = new BLLDonHang();
        BLLDanhSachSanPham bllds = new BLLDanhSachSanPham();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChiTietDonHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllgh.getChiTietDonHang(maKh);
            float Tong = 0;
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                Tong += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            txtTongTien.Text = Tong.ToString();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            int maDonHang = 0;
            DataTable dt = blldh.getMaxMaDonHang();
            if (dt.Rows[0][0].ToString().Equals(""))
                maDonHang = 1;
            else maDonHang = int.Parse(dt.Rows[0][0].ToString()) + 1;
            String status = "Chờ xác nhận";
            blldh.insertDonHang(maDonHang,maKh, float.Parse(txtTongTien.Text),status,dateTimePicker1.Value.ToShortDateString());
            blldh.insertDonHangUser(maDonHang, maKh, float.Parse(txtTongTien.Text), status, dateTimePicker1.Value.ToShortDateString());
            blldh.insertDonHangAd(maDonHang, maKh, float.Parse(txtTongTien.Text), status, dateTimePicker1.Value.ToShortDateString());
            for (int i=0;i < dataGridView1.Rows.Count - 1;i++)
            {
                blldh.insertChiTietDonHang(maDonHang, dataGridView1.Rows[i].Cells[4].Value.ToString(), int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                bllds.updateSoLuongSach(dataGridView1.Rows[i].Cells[4].Value.ToString(), int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            if (passControl != null)
            {
                // this.Close();
                passControl(sender);
            }
            MessageBox.Show("Đặt hàng thành công đang chờ xác nhận", "Thông báo");
            this.Close();
        }

        public delegate void PassControl(object sender);
        public PassControl passControl;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
