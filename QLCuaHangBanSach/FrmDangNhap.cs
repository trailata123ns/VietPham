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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        BLLDangNhap bllDangNhap = new BLLDangNhap();
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser1.Text == "Username")
            {
                txtuser1.Text = "";
                txtuser1.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser1.Text == "")
            {
                txtuser1.Text = "Username";
                txtuser1.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass1.Text == "Password")
            {
                txtpass1.Text = "";
                txtpass1.ForeColor = Color.Black;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass1.Text == "")
            {
                txtpass1.Text = "Password";
                txtpass1.ForeColor = Color.Silver;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String user = txtuser1.Text;
            String pass = txtpass1.Text;
            DataTable dt = new DataTable();
            dt = bllDangNhap.getAccount(user);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Username không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String pas = dt.Rows[0][0].ToString().Trim();
            if (pas != "" && pas.Equals(pass) && user == "admin")
            {
                this.Hide();
                FrmMenuAd frmMenuAd = new FrmMenuAd();
                frmMenuAd.Show();
            }
            else if (pas != "" && pas.Equals(pass))
            {
                FrmMenuUser frm = new FrmMenuUser(txtuser1.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frmdk = new FrmDangKy();
            this.Hide();
            frmdk.Show();
        }
    }
}
