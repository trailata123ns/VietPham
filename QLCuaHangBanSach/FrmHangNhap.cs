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
    public partial class FrmHangNhap : Form
    {
        public FrmHangNhap()
        {
            InitializeComponent();
        }
        BLLHangNhap bllhn = new BLLHangNhap();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHangNhap_Load(object sender, EventArgs e)
        {
            dgvQLSach.DataSource = bllhn.getHangNhap();
        }

        private void button1_Click(object sender, EventArgs e)
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
            worksheet.Cells[1, 1] = "Lịch sử nhập hàng";
            worksheet.Cells[3, 1] = "Mã sách";
            worksheet.Cells[3, 2] = "Tên sách";
            worksheet.Cells[3, 3] = "Thể loại";
            worksheet.Cells[3, 4] = "Giá bán";
            worksheet.Cells[3, 5] = "Tác giả";
            worksheet.Cells[3, 6] = "Nhà xuất bản";
            worksheet.Cells[3, 7] = "Số lượng nhập";
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
