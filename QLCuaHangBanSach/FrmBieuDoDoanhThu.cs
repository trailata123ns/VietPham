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
    public partial class FrmBieuDoDoanhThu : Form
    {
        public FrmBieuDoDoanhThu()
        {
            InitializeComponent();
        }
        BLLThongKe blltk = new BLLThongKe();
        private void loadcombobox()
        {
            for (int i = 2022; i >= 1990; i--)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
            }
        }
        private void BieuDoDoanhThu_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void fillchart_ngay(int nam, int thang)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "ngày";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chart1.Series["doanh thu"].Points.Clear();
            DataTable dt = new DataTable();
            float doanhthu = 0;
            int n = 0;
            if (comboBox2.Text == "4" || comboBox2.Text == "6" || comboBox2.Text == "9" || comboBox2.Text == "11")
                n = 30;
            else if (comboBox2.Text == "2")

                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                    n = 29;
                else
                    n = 28;
            else n = 31;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = n;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            for (int i = 1; i <= n; i++)
            {
                doanhthu = 0;
                dt = blltk.doanhthungay(nam, thang, i);
                if (dt.Rows[0][0].ToString() != "") doanhthu = float.Parse(dt.Rows[0][0].ToString());
                chart1.Series["doanh thu"].Points.AddXY(i.ToString(), doanhthu.ToString());
            }
        }

        private void fillchart_thang(int nam)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chart1.Series["doanh thu"].Points.Clear();
            DataTable dt = new DataTable();
            float doanhthu = 0;
            int n = 12;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 12;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            for (int i = 1; i <= n; i++)
            {
                doanhthu = 0;
                dt = blltk.doanhthuthang(nam, i);
                if (dt.Rows[0][0].ToString() != "") doanhthu = float.Parse(dt.Rows[0][0].ToString());
                chart1.Series["doanh thu"].Points.AddXY(i.ToString(), doanhthu.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ngày tháng", "error");
                return;
            }
            if (radioButton1.Checked)
            {
                fillchart_ngay(int.Parse(comboBox1.Text),int.Parse(comboBox2.Text));
            }
            else
            {
                fillchart_thang(int.Parse(comboBox1.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
