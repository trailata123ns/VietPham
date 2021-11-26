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
    public partial class FrmLapHoaDon : Form
    {
        public FrmLapHoaDon()
        {
            InitializeComponent();
        }
        BLLDanhSachSanPham bllds = new BLLDanhSachSanPham();
        BLLGioHang bllgh = new BLLGioHang();
        BLLDonHang blldh = new BLLDonHang();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLapHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllds.getSachLapHoaDon();
            dataGridView2.DataSource = bllds.getSachGioHangAd();
            float tong = 0;
            for(int a=0; a < dataGridView2.Rows.Count-1;a++)
            {
                tong += float.Parse(dataGridView2.Rows[a].Cells[1].Value.ToString()) * float.Parse(dataGridView2.Rows[a].Cells[2].Value.ToString());
            }
            textBox1.Text = tong.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource != null)
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không. Nếu thoát thì đơn hàng hiện tại sẽ bị hủy !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    delete();
                    this.Close();
                }
                else if (dlr == DialogResult.No)
                    return;
            }
            else this.Close();
        }
        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataTable dt = bllds.getHinhanh(dataGridView1.Rows[i].Cells[3].Value.ToString());
            try
            {
                string s = dt.Rows[0][0].ToString();
                ptb.Image = Image.FromFile(s);
            }
            catch (Exception)
            {
                MessageBox.Show("Dòng bạn chọn không có dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số lượng mua", "Thông báo");
                return;
            }
            if(i < 0 || i>= dataGridView1.Rows.Count)
                MessageBox.Show("Dòng bạn chọn không có dữ liệu", "Thông báo");
            else
            {
                bllgh.insertGioHang("admin", "admin", dataGridView1.Rows[i].Cells[3].Value.ToString(), int.Parse(textBox2.Text), true);
                FrmLapHoaDon_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                bllgh.deleteGioHang(dataGridView2.Rows[j].Cells[3].Value.ToString(),"admin");
                FrmLapHoaDon_Load(sender, e);
            
        }
        int j;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            j = e.RowIndex;
        }

        private void delete()
        {
            bllgh.deleteGioHang("admin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource != null)
            {
                int maDonHang;
                DataTable dt = blldh.getMaxMaDonHang();
                if (dt.Rows[0][0].ToString().Equals(""))
                    maDonHang = 1;
                else maDonHang = int.Parse(dt.Rows[0][0].ToString()) + 1;
                blldh.insertDonHangAd(maDonHang, "admin", float.Parse(textBox1.Text), "Đã xác nhận", dateTimePicker1.Value.ToShortDateString());
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    blldh.insertChiTietDonHang(maDonHang, dataGridView2.Rows[i].Cells[3].Value.ToString(), int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
                    bllds.updateSoLuongSach(dataGridView2.Rows[i].Cells[3].Value.ToString(), int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
                }
                DialogResult dlr = MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    // khởi tạo excel
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    // khởi tạo workbook
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    // khởi tạo worksheet
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    app.Visible = true;
                    // đổ dữ liệu
                    worksheet.Cells[1, 1] = "Hóa đơn";
                    worksheet.Cells[4, 1] = "Tên sách";
                    worksheet.Cells[4, 2] = "Giá bán";
                    worksheet.Cells[4, 3] = "Số lượng";
                    worksheet.Cells[4, 4] = "Thành tiền";
                    int a = dataGridView2.Rows.Count;
                    int i;
                    for (i = 0; i < a - 1; i++)
                    {
                        worksheet.Cells[i + 5, 1] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        worksheet.Cells[i + 5, 2] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                        worksheet.Cells[i + 5, 3] = dataGridView2.Rows[i].Cells[2].Value.ToString();
                        worksheet.Cells[i + 5, 4] = float.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString())*int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());

                    }
                    worksheet.Cells[3, 4] = dateTimePicker1.Value.ToShortDateString();
                    worksheet.Cells[3, 1] = "Ngày lập:";
                    worksheet.Cells[5+i, 1] = "Tổng tiền:";
                    worksheet.Cells[5+i, 4] = textBox1.Text;
                    worksheet.Range["A1"].ColumnWidth = 20;
                    worksheet.Range["B1"].ColumnWidth = 15;
                    worksheet.Range["C1"].ColumnWidth = 15;
                    worksheet.Range["D1"].ColumnWidth = 20;
                    worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
                    worksheet.Range["A1", "G1"].Font.Size = 20;
                    worksheet.Range["A2", "G100"].Font.Size = 14;
                    worksheet.Range["A1", "D2"].MergeCells = true;
                    worksheet.Range["A3", "C3"].MergeCells = true;
                    
                    worksheet.Range["A1", "D1"].Font.Bold = true;
                    worksheet.Range["A1", "D1"].Font.ColorIndex = 3;
                    worksheet.Range["A4", "D4"].Font.Bold = true;
                    worksheet.Range["A1", "D1"].HorizontalAlignment = 3;

                    worksheet.Range["A"+(5+i), "C"+(5+i)].MergeCells = true;
                    worksheet.Range["A1", "D" + (4 + i+1)].Borders.LineStyle = 1;
                }
                else MessageBox.Show("Thanh toán thành công", "Thông báo");
                
                delete();
                FrmLapHoaDon_Load(sender, e);
            }
            else
                MessageBox.Show("Bạn chưa có hàng trong đơn hàng", "Thông báo");
        }
    }
}
