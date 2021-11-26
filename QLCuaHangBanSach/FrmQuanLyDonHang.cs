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
    public partial class FrmQuanLyDonHang : Form
    {
        public FrmQuanLyDonHang()
        {
            InitializeComponent();
        }
        BLLDonHang blldh = new BLLDonHang();
        BLLQuanLyHoaDon bllhd = new BLLQuanLyHoaDon();
        BLLKhachHang bllkh = new BLLKhachHang();
        private void FrmQuanLyDonHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = blldh.getDonHang();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i;


        private void button1_Click(object sender, EventArgs e)
        {
            blldh.updateTrangThai(dataGridView1.Rows[i].Cells[0].Value.ToString(),"Đã xác nhận");
            blldh.updateTrangThai1(dataGridView1.Rows[i].Cells[0].Value.ToString(), "Đã xác nhận");
            blldh.updateTrangThai2(dataGridView1.Rows[i].Cells[0].Value.ToString(), "Đã xác nhận");
            FrmQuanLyDonHang_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blldh.deleteDonHang(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //blldh.deleteDonHangUser(dataGridView1.Rows[i].Cells[0].Value.ToString());
            FrmQuanLyDonHang_Load(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmChiTietDonHang frm = new FrmChiTietDonHang(dataGridView1.Rows[i].Cells[0].Value.ToString());
            frm.Show();
        }
    }
}
