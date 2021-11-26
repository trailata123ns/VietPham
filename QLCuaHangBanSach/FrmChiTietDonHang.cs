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
    public partial class FrmChiTietDonHang : Form
    {
        public FrmChiTietDonHang()
        {
            InitializeComponent();
        }
        String maDonHang;
        public FrmChiTietDonHang(String maDonHang):this()
        {
            this.maDonHang = maDonHang; 
        }
        BLLDonHang blldh = new BLLDonHang();

        private void FrmChiTietDonHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = blldh.getChiTietDonHang(maDonHang);

            float Tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Tong += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            txtTongTien.Text = Tong.ToString();
            label6.Text = maDonHang;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
