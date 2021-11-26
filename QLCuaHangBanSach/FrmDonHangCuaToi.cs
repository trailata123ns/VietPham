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
    public partial class FrmDonHangCuaToi : Form
    {
        public FrmDonHangCuaToi()
        {
            InitializeComponent();
        }
        String maKh;
        BLLGioHang bllgh = new BLLGioHang();
        public FrmDonHangCuaToi(String maKh):this()
        {
            this.maKh = bllgh.getMaKh(maKh).Rows[0][0].ToString();
        }
        BLLDonHang blldh = new BLLDonHang();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDonHangCuaToi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = blldh.getDonHangUser(maKh);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (dataGridView1.Rows[i].Cells[3].Value.ToString().Equals("Đã xác nhận"))
                blldh.deleteDonHangUser(dataGridView1.Rows[i].Cells[0].Value.ToString());
           else MessageBox.Show("Không được xóa đơn hàng chưa xác nhận", "Thông báo");
           FrmDonHangCuaToi_Load(sender, e);

        }

        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[i].Cells[3].Value.ToString().Equals("Chờ xác nhận"))
            {
                DataTable dt = blldh.getSachInChiTietDonHang(dataGridView1.Rows[i].Cells[0].Value.ToString());
                for(int i = 0;i<dt.Rows.Count;i++)
                {
                    blldh.updateSoLuongSach(dt.Rows[i][0].ToString(), int.Parse(dt.Rows[i][1].ToString()));
                }
                blldh.deleteDonHangUser(dataGridView1.Rows[i].Cells[0].Value.ToString());
                blldh.deleteDonHang(dataGridView1.Rows[i].Cells[0].Value.ToString());
                FrmDonHangCuaToi_Load(sender,e);
               
            }
            else MessageBox.Show("Đơn hàng đã được xác nhận. Không được hủy...!", "Thông báo");
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmChiTietDonHang frm = new FrmChiTietDonHang(dataGridView1.Rows[i].Cells[0].Value.ToString());
            frm.Show();
        }
    }
}
