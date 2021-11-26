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
    public partial class FrmGioHang : Form
    {
        public FrmGioHang()
        {
            InitializeComponent();
        }
        String maKh;
        public FrmGioHang(String username):this()
        {
            maKh = bllgh.getMaKh(username).Rows[0][0].ToString();
        }

        BLLGioHang bllgh = new BLLGioHang();
        int row1;
        private void PassData1(object sender)
        {
            dataGridView1.DataSource = bllgh.getGioHang(maKh);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCapNhatSoLuong frm = new FrmCapNhatSoLuong(maKh,dataGridView1.Rows[row1].Cells[0].Value.ToString());
            frm.passControl = new FrmCapNhatSoLuong.PassControl(PassData1);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGioHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  bllgh.getGioHang(maKh);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row1 = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bllgh.deleteGioHang(dataGridView1.Rows[row1].Cells[0].Value.ToString(), maKh);
            FrmGioHang_Load(sender, e);
        }
        private void PassData(object sender)
        {
            for(int i=0;i<dataGridView1.Rows.Count - 1;i++)
            {
                bllgh.deleteGioHangByStatus(dataGridView1.Rows[i].Cells[0].Value.ToString(), maKh);
            }
            dataGridView1.DataSource = bllgh.getGioHang(maKh);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Boolean stt,check = false;
            for (int i=0;i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals("True"))
                {
                    stt = true;
                    check = true;
                }
                else stt = false;
                bllgh.updateStatus(dataGridView1.Rows[i].Cells[0].Value.ToString(), maKh, stt);
            }
            if (check)
            {
                FrmDonHangUser frm = new FrmDonHangUser(maKh);
                frm.passControl = new FrmDonHangUser.PassControl(PassData);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng nào","Thông báo");
                return;
            }
        }    
    }
}
