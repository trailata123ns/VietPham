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
    public partial class FrmCapNhatSoLuong : Form
    {
        public FrmCapNhatSoLuong()
        {
            InitializeComponent();
        }

        private String maKh, maSach;
        public FrmCapNhatSoLuong(String maKh,String maSach):this()
        {
            this.maKh = maKh;
            this.maSach = maSach;
        }
        BLLGioHang bllgh = new BLLGioHang();
        BLLDanhSachSanPham bllds = new BLLDanhSachSanPham();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCapNhatSoLuong_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals(""))
                    throw new Exception();
                int soluong = int.Parse(textBox1.Text);
                if (soluong > 0 && int.Parse(bllds.getSoLuong(maSach).Rows[0][0].ToString()) >= soluong)
                {
                    bllgh.updateSoLuongGioHang(maSach, maKh, soluong);
                }
                else
                {
      
                    MessageBox.Show("Số lượng sách không đủ", "Thông báo");
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0", "Error");
            }
            catch(Exception )
            {
                MessageBox.Show("Không được bỏ trống số lượng", "Error");
            }
            if (passControl != null)
            {
                // this.Close();
                passControl(sender);
            }
            this.Close();
        }
        public delegate void PassControl(object sender);
        public PassControl passControl;

    }
}
