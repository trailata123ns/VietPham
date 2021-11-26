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
    public partial class FrmNXB : Form
    {
        public FrmNXB()
        {
            InitializeComponent();
        }

        BLLNhaXuatBan bllnxb = new BLLNhaXuatBan();
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmanxb.Text.Equals("") || txttennxb.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            bllnxb.insertNXB(txtmanxb.Text, txttennxb.Text, txtdiachi.Text);
            FrmNXB_Load(sender, e);
        }


        private void FrmNXB_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = bllnxb.getNXB();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmanxb.Text.Equals("") || txttennxb.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            bllnxb.updateNXB(txtmanxb.Text, txttennxb.Text, txtdiachi.Text);
            FrmNXB_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanxb.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            bllnxb.deleteNXB(txtmanxb.Text);
            FrmNXB_Load(sender, e);
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row1 = e.RowIndex;
            txtmanxb.Text = dgvNXB.Rows[row1].Cells[0].Value.ToString();
            txttennxb.Text = dgvNXB.Rows[row1].Cells[1].Value.ToString();
            txtdiachi.Text = dgvNXB.Rows[row1].Cells[2].Value.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(cbb.Text.Equals("Mã nhà xuất bản"))
            {
                try
                {
                    if (txtmanxb.Text.Equals(""))
                        throw new Exception();
                    dgvNXB.DataSource = bllnxb.SearchNXB(txtmanxb.Text, "maNhaxb");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống mã nhà xuất bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else if (cbb.Text =="Tên nhà xuất bản")
            {
                try
                {
                    if (txttennxb.Text.Equals(""))
                        throw new Exception();
                    dgvNXB.DataSource = bllnxb.SearchNXB(txttennxb.Text, "tenNhaxb");
                    Console.Write(txttennxb.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống tên nhà xuất bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            FrmNXB_Load(sender, e);
        }
    }
}
