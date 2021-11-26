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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void loadcombobox()
        {
            for (int i = 2022; i >= 1990; i--)
            {
                cbb5nam1.Items.Add(i);
            }
            cbb5thang1.Items.Add("all");
            for (int i = 1; i <= 12; i++)
            {
                cbb5thang1.Items.Add(i);
            }
        }

        BLLThongKe blltk = new BLLThongKe();

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            loadcombobox();            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn5thongke1_Click(object sender, EventArgs e)
        {
            
            if (rdbtimetuychon.Checked == true)
            {
                dataGridView1.DataSource = blltk.getHoadon1(dtpstart.Value, dtpend.Value);
                DataTable dt = blltk.tongsoluong(dtpstart.Value, dtpend.Value);
                if (dt.Rows[0][0].ToString() == "")
                {
                    txt5soluongsp.Text = "0";
                    txt5tongdoanhthu.Text = "0";
                    return;
                }
                txt5soluongsp.Text = dt.Rows[0][0].ToString();
                dt = blltk.tongdoanhthu(dtpstart.Value, dtpend.Value);
                txt5tongdoanhthu.Text = dt.Rows[0][0].ToString();
                
            }
            else if (rdbtimecodinh.Checked == true)
            {
                dataGridView1.DataSource = blltk.getHoadon2(int.Parse(cbb5nam1.Text), cbb5thang1.Text, cbb5ngay1.Text);
                DataTable dt = blltk.tongsoluong_2(int.Parse(cbb5nam1.Text), cbb5thang1.Text, cbb5ngay1.Text);
                if (dt.Rows[0][0].ToString() == "")
                {
                    txt5soluongsp.Text = "0";
                    txt5tongdoanhthu.Text = "0";
                    return;
                }
                txt5soluongsp.Text = dt.Rows[0][0].ToString();
                dt = blltk.tongdoanhthu_2(int.Parse(cbb5nam1.Text), cbb5thang1.Text, cbb5ngay1.Text);
                txt5tongdoanhthu.Text = dt.Rows[0][0].ToString();
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thời gian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbb5thang1_TextChanged_1(object sender, EventArgs e)
        {
            if (cbb5thang1.Text == "all")
            {
                cbb5ngay1.Items.Clear();
                cbb5ngay1.Text = "all";
            }
            else if (cbb5thang1.Text == "4" || cbb5thang1.Text == "6" || cbb5thang1.Text == "9" || cbb5thang1.Text == "11")
            {
                cbb5ngay1.Text = "all";
                cbb5ngay1.Items.Clear();
                cbb5ngay1.Items.Add("all");
                for (int i = 1; i <= 30; i++)
                    cbb5ngay1.Items.Add(i);
            }
            else if (cbb5thang1.Text == "2")
            {
                cbb5ngay1.Text = "all";
                cbb5ngay1.Items.Clear();
                cbb5ngay1.Items.Add("all");
                int nam = int.Parse(cbb5nam1.Text);
                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                {
                    for (int i = 1; i <= 29; i++)
                        cbb5ngay1.Items.Add(i);
                }
                else
                    for (int i = 1; i <= 28; i++)
                        cbb5ngay1.Items.Add(i);
            }
            else
            {
                cbb5ngay1.Text = "all";
                cbb5ngay1.Items.Clear();
                cbb5ngay1.Items.Add("all");
                for (int i = 1; i <= 31; i++)
                    cbb5ngay1.Items.Add(i);
            }
        }
    }
}
