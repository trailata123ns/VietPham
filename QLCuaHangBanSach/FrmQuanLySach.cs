using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLCuaHangBanSach
{
    public partial class FrmQuanLySach : Form
    {
        public FrmQuanLySach()
        {
            
            InitializeComponent();
        }
        BLLQuanLySach bllqlsach = new BLLQuanLySach();
        BLLHangNhap bllhn = new BLLHangNhap();
        private void Đóng_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChontep_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog a = new OpenFileDialog();
                a.Filter = a.Filter = "JPG file(*.jpg)|*jpg|All files(*.*)|*.*";
                a.FilterIndex = 1;
                a.RestoreDirectory = true;
                if (a.ShowDialog() == DialogResult.OK)
                {
                    ptb.ImageLocation = a.FileName;
                    txtHinhanh.Text = a.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        BLLNhaXuatBan bllnxb = new BLLNhaXuatBan();
        private void hienthi()
        {
            dgvQLSach.DataSource = bllqlsach.getSach();
            DataTable dt = new DataTable();
            dt = bllnxb.gettenNXB();
            cmbtenNxb.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cmbtenNxb.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMasach.Text.Equals("") || txtTensach.Text.Equals("") || txtTheloai.Text.Equals("") || txtGiaban.Text.Equals("") || txtSoluong.Text.Equals("") || txtHinhanh.Text.Equals(""))
                {
                    throw new Exception();
                }
                float giaban = float.Parse(txtGiaban.Text);
                int soluong = int.Parse(txtSoluong.Text);
                bllqlsach.insertSach(txtMasach.Text, txtTensach.Text, txtTheloai.Text, giaban, txtTacgia.Text, cmbtenNxb.Text, soluong, txtHinhanh.Text);
                if (bllhn.getMaSach(txtMasach.Text).Rows.Count == 0)
                    bllhn.insertHangNhap(txtMasach.Text, txtTensach.Text, txtTheloai.Text, giaban, txtTacgia.Text, cmbtenNxb.Text, soluong, txtHinhanh.Text);
                else bllhn.updateSach(txtMasach.Text, int.Parse(txtSoluong.Text));
                hienthi();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception )
            {
                MessageBox.Show("Không được để trống các trường", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        private void FrmQuanLySach_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasach.Text.Equals(""))
                    throw new Exception();
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    bllqlsach.deleteSach(txtMasach.Text);
                    hienthi();
                }
                else if (dlr == DialogResult.No)
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống mã sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row1 = e.RowIndex;
               if(row1 < 0)
                {
                    MessageBox.Show("Dòng bạn chọn không có dữ liệu");
                     return;
                }
            
                txtMasach.Text = dgvQLSach.Rows[row1].Cells[0].Value.ToString();
                txtTensach.Text = dgvQLSach.Rows[row1].Cells[1].Value.ToString();
                txtTheloai.Text = dgvQLSach.Rows[row1].Cells[2].Value.ToString();
                txtGiaban.Text = dgvQLSach.Rows[row1].Cells[3].Value.ToString();
                txtTacgia.Text = dgvQLSach.Rows[row1].Cells[4].Value.ToString();
                cmbtenNxb.Text = dgvQLSach.Rows[row1].Cells[5].Value.ToString();
                txtSoluong.Text = dgvQLSach.Rows[row1].Cells[6].Value.ToString();
                DataTable dt = bllqlsach.getHinhanh(txtMasach.Text);
                try
                {
                    txtHinhanh.Text = dt.Rows[0][0].ToString();
                    ptb.Image = Image.FromFile(txtHinhanh.Text);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Dòng bạn chọn không có dữ liệu","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasach.Text.Equals("") || txtTensach.Text.Equals("") || txtTheloai.Text.Equals("") || txtGiaban.Text.Equals("") || txtSoluong.Text.Equals("") || txtHinhanh.Text.Equals(""))
                {
                    throw new Exception();
                }
                float giaban = float.Parse(txtGiaban.Text);
                int soluong = int.Parse(txtSoluong.Text);
                bllqlsach.updateSach(txtMasach.Text, txtTensach.Text, txtTheloai.Text, giaban, txtTacgia.Text, cmbtenNxb.Text, soluong, txtHinhanh.Text);
                hienthi();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống các trường", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(cbb.Text == "Mã sách")
            {
                try
                {
                    if (txtMasach.Text.Equals(""))
                        throw new Exception();
                
                    dgvQLSach.DataSource = bllqlsach.SearchSach(txtMasach.Text, "maSach");
                }
                catch(Exception)
                {
                    MessageBox.Show("Không được để trống mã sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbb.Text == "Tên sách")
            {
                try
                {
                    if (txtTensach.Text.Equals(""))
                        throw new Exception();
           
                    dgvQLSach.DataSource = bllqlsach.SearchSach(txtTensach.Text, "tenSach");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống tên sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbb.Text == "Thể loại")
            {
                try
                {
                    if (txtTheloai.Text.Equals(""))
                        throw new Exception();
                    dgvQLSach.DataSource = bllqlsach.SearchSach(txtTheloai.Text, "theLoai");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống thể loại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbb.Text == "Tác giả")
            {
                try
                {
                    if (txtTacgia.Text.Equals(""))
                        throw new Exception();
                    dgvQLSach.DataSource = bllqlsach.SearchSach(txtTacgia.Text, "tacGia");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống tác giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbb.Text == "Nhà xuất bản")
            {
                try
                {
                    if (cmbtenNxb.Text.Equals(""))
                        throw new Exception();
                    dgvQLSach.DataSource = bllqlsach.SearchSach(cmbtenNxb.Text, "nhaXb");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không được để trống nhà xuất bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvQLSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
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
            worksheet.Cells[1, 1] = "Danh sách sản phẩm";
            worksheet.Cells[3, 1] = "Mã sách";
            worksheet.Cells[3, 2] = "Tên sách";
            worksheet.Cells[3, 3] = "Thể loại";
            worksheet.Cells[3, 4] = "Giá bán";
            worksheet.Cells[3, 5] = "Tác giả";
            worksheet.Cells[3, 6] = "Nhà xuất bản";
            worksheet.Cells[3, 7] = "Số lượng tồn";
            int a = dgvQLSach.Rows.Count;
            int i;
            for (i = 0; i < a - 1; i++)
            {
                worksheet.Cells[i + 4, 1] = dgvQLSach.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 4, 2] = dgvQLSach.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 4, 3] = dgvQLSach.Rows[i].Cells[2].Value.ToString();
                worksheet.Cells[i + 4, 4] = dgvQLSach.Rows[i].Cells[3].Value.ToString();
                worksheet.Cells[i + 4, 5] = dgvQLSach.Rows[i].Cells[4].Value.ToString();
                worksheet.Cells[i + 4, 6] = dgvQLSach.Rows[i].Cells[5].Value.ToString();
                worksheet.Cells[i + 4, 7] = dgvQLSach.Rows[i].Cells[6].Value.ToString();
            }

            worksheet.Range["A1"].ColumnWidth = 14;
            worksheet.Range["B1"].ColumnWidth = 25;
            worksheet.Range["C1"].ColumnWidth = 20;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 25;
            worksheet.Range["F1"].ColumnWidth = 25;
            worksheet.Range["G1"].ColumnWidth = 22;
            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G100"].Font.Size = 18;
            worksheet.Range["A1", "G2"].MergeCells = true;
            // worksheet.Range["B" + (dem + 6), "E" + (dem + 6)].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A1", "G1"].Font.ColorIndex = 3;
            worksheet.Range["A4", "G4"].Font.Bold = true;
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            // worksheet.Range["B" + (dem + 6), "E" + (dem + 6)].HorizontalAlignment = 3;
            // kẻ bảng
            worksheet.Range["A1", "G" + (3 + i)].Borders.LineStyle = 1;
        }


        
    }
}
