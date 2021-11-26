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
    public partial class FrmDanhSachSanPham : Form
    {
        public FrmDanhSachSanPham()
        {
            InitializeComponent();
        }
        String maKh;
        public FrmDanhSachSanPham(String username):this()
        {
           maKh = bllgh.getMaKh(username).Rows[0][0].ToString();
        }
        BLLDanhSachSanPham bllds = new BLLDanhSachSanPham();
        BLLGioHang bllgh = new BLLGioHang();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập dữ liệu cần tìm")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập dữ liệu cần tìm";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            FrmDanhSachSanPham_Load(sender, e);
        }

        private void FrmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSachSanPham.DataSource = bllds.getSach();
        }

        public delegate void PassControl(object sender);
        public PassControl passControl;
        private void btnxem_Click(object sender, EventArgs e)
        { 
            if (passControl != null)
            {
               // this.Close();
                passControl(sender);
            }
        }
        int row1;
        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row1 = e.RowIndex;
            DataTable dt = bllds.getHinhanh(dgvDanhSachSanPham.Rows[row1].Cells[0].Value.ToString());
            try
            {
                string s = dt.Rows[0][0].ToString();
                pictureBox1.Image = Image.FromFile(s);
            }
            catch (Exception)
            {
                MessageBox.Show("Dòng bạn chọn không có dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbbtimkiem.Text.Equals("Tên sách"))
            {
                try
                {
                    if (textBox1.Text.Equals(""))
                        throw new Exception();
                    dgvDanhSachSanPham.DataSource = bllds.SearchSach(textBox1.Text, "tenSach");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống ô dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbbtimkiem.Text.Equals("Thể loại"))
            {
                try
                {
                    if (textBox1.Text.Equals(""))
                        throw new Exception();
                    dgvDanhSachSanPham.DataSource = bllds.SearchSach(textBox1.Text, "theLoai");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống ô dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbbtimkiem.Text.Equals("Tác giả"))
            {
                try
                {
                    dgvDanhSachSanPham.DataSource = bllds.SearchSach(textBox1.Text, "tacGia");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống ô dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbsapxep_TextChanged(object sender, EventArgs e)
        {
            if (cbbsapxep.Text == "Sắp xếp theo giá tăng dần")
            {
                dgvDanhSachSanPham.DataSource = bllds.get_GiaBanTangDan();
            }
            else if (cbbsapxep.Text == "Sắp xếp theo giá giảm dần")
            {
                dgvDanhSachSanPham.DataSource = bllds.get_GiaBanGiamDan();
            }
            else if (cbbsapxep.Text == "Sắp xếp theo tên sách A->Z")
            {
                dgvDanhSachSanPham.DataSource = bllds.get_GiaBanTangDan();
            }
            else if (cbbsapxep.Text == "Sắp xếp theo tên sách Z->A")
            {
                dgvDanhSachSanPham.DataSource = bllds.get_GiaBanGiamDan();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dgvDanhSachSanPham.Rows[row1].Cells[6].Value.ToString()) >= 1)
            {
                bllgh.insertGioHang(maKh, maKh, dgvDanhSachSanPham.Rows[row1].Cells[0].Value.ToString(), 1, true);
                MessageBox.Show("Thêm hàng thành công", "Thông báo");
            }
            else
                MessageBox.Show("Số lượng sách không đủ", "Thông báo");
            
            
            FrmDanhSachSanPham_Load(sender, e);
            //dgvDanhSachSanPham.Rows[row1].Cells[0].Value.ToString();
        }
    }
}
