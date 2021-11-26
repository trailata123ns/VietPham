using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;

namespace QLCuaHangBanSach
{
    class BLLQuanLyHoaDon
    {
        DAL dal = new DAL();
        public DataTable getHoadon()
        {
            String sql = "select maDonHang,maKh,ngayLap,tongTien from DonHangAd where trangThai = "+"N'Đã xác nhận'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void deleteHoadon(String maHoadon)
        {
            try
            {
                String sql = "delete from DonHangAd where maDonHang = '" + maHoadon+ "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        public DataTable SearchHoadon(String chuoi, String truong)
        {
            string sql = "SELECT * from DonHangAd WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.getTable(sql);
            return dt;
        }

        public DataTable SearchHoadon(String chuoi)
        {
            String[] str = chuoi.Split('-');
            string sql = "SELECT * from DonHangAd WHERE year(ngayLap) = "+str[0]+ " and month(ngayLap) = "+str[1]+" and day(ngayLap) = "+str[2];
            DataTable dt = dal.getTable(sql);
            return dt;
        }
    }
}
