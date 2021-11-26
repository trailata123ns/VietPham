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
    public partial class FrmMenuAd : Form
    {
        public FrmMenuAd()
        {
            InitializeComponent();
        }

     
        private void FrmMenuAd_Load(object sender, EventArgs e)
        {
            Setpanel();
        }
        #region setpanel
        private void Setpanel()
        {
            panelquanli.Visible = false;
            panelthongke.Visible = false;
        }

        private void hidepanel()
        {
            if(panelquanli.Visible == true) panelquanli.Visible = false;
            if (panelthongke.Visible == true) panelthongke.Visible = false;
        }

        private void showpanel(Panel pn)
        {
            if (pn.Visible == false)
            {
                hidepanel();
                pn.Visible = true;
            }
            else pn.Visible = false;
        }
        #endregion
        #region btnQuanLy

        private void btnqlnxb_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyHoaDon());
            hidepanel();
        }
        #endregion
        #region btnThongKe
        private void btnthongke_Click(object sender, EventArgs e)
        {
            showpanel(panelthongke);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThongKe());
            hidepanel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBieuDoDoanhThu());
            hidepanel();
        }
        #endregion
       

        private Form activeForm = null;
        private void openChildForm (Form childForm)
        {
            if(activeForm != null)  activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNXB());
            hidepanel();
        }

        private void btndangxuat_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                hidepanel();
                FrmDangNhap Frm = new FrmDangNhap();
                this.Hide();
                Frm.Show();
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmLapHoaDon());
            hidepanel();
        }

        private void btnql_Click_1(object sender, EventArgs e)
        {
            showpanel(panelquanli);
        }

        private void btnqlsach_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLySach()); 
        }

        private void btnqlnguoidung_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyNguoiDung());
            
        }

        private void btnqldonhang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyDonHang());
            
        }

        private void btnqlhoadon_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyHoaDon());
            
        }

        private void btnNxb_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNXB());
            
        }

        private void btnthongke_Click_1(object sender, EventArgs e)
        {
            showpanel(panelthongke);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmThongKe());
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmBieuDoDoanhThu());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHangNhap());
            
        }

        private void btnqlsach_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
