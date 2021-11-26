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
    public partial class FrmQuanLyHoaDon : Form
    {
        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        BLLQuanLyHoaDon bllhd = new BLLQuanLyHoaDon();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            bllhd.deleteHoadon(mahd);
            FrmQuanLyHoaDon_Load(sender, e);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbb.Text.Equals("Mã hóa đơn"))
            {
                try
                {
                    if (textBox1.Text.Equals(""))
                        throw new Exception();
                    dataGridView1.DataSource = bllhd.SearchHoadon(textBox1.Text, "maDonHang");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống ô dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbb.Text == "Ngày lập")
            {
                try
                {
                    if (textBox1.Text.Equals("") )
                       throw new Exception();
                 
                     dataGridView1.DataSource = bllhd.SearchHoadon(textBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống ô dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập dữ liệu cần tìm")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập dữ liệu cần tìm";
                textBox1.ForeColor = Color.Silver;
            }
        }
        String mahd = "";
        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            mahd = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllhd.getHoadon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuanLyHoaDon_Load(sender, e);
        }

        private void btnxoaall_Click(object sender, EventArgs e)
        {
            //bllhd.deleteallHoadon();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmChiTietDonHang frm = new FrmChiTietDonHang(dataGridView1.Rows[i].Cells[0].Value.ToString());
            frm.Show();
        }
    }
}
