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
    public partial class FrmMenuUser : Form
    {
        public FrmMenuUser()
        {
            InitializeComponent();
        }

        public FrmMenuUser(String lb1) : this()
        {
            lbuser.Text = lb1;
        }
        private void FrmMenuUser_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm2.Controls.Add(childForm);
            panelChildForm2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDanhSachSanPham frmth = new FrmDanhSachSanPham(lbuser.Text);
            frmth.passControl = new FrmDanhSachSanPham.PassControl(PassData);
            openChildForm(frmth);
           // frmth.Show();
        }
        private void PassData(object sender)
        {
            openChildForm(new FrmGioHang(lbuser.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThongTinCaNhan(lbuser.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmGioHang(lbuser.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                FrmDangNhap Frm = new FrmDangNhap();
                this.Close();
                Frm.Show();
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void lbuser_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDonHangCuaToi(lbuser.Text));
        }
    }
}