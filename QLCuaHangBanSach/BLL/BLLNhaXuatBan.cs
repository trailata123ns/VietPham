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
    class BLLNhaXuatBan
    {
        DAL dal = new DAL();
        public DataTable getNXB()
        {
            String sql = "select * from NhaXuatBan";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable gettenNXB()
        {
            String sql = "select tenNhaxb from NhaXuatBan";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void insertNXB(String manxb, String tennxb, String diaChi)
        {
            try
            {
                String sql = "Insert into NhaXuatBan values('" + manxb + "',N'" + tennxb + "',N'" + diaChi + "')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // MessageBox.Show("Đăng ký thành công !", "Thông báo");
        }

        public void deleteNXB(String manxb)
        {
            try
            {
                String sql = "delete from NhaXuatBan where maNhaxb = '" + manxb + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void updateNXB(String manxb, String tennxb, String diachi)
        {
            try
            {
                String sql = "update NhaXuatBan set tenNhaxb = N'" + tennxb + "',diaChi = N'" + diachi + "' where maNhaxb = '" + manxb + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable SearchNXB(String chuoi, String truong)
        {
            string sql = "SELECT * from NhaXuatBan WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.getTable(sql);
            return dt;
        }
    }
}
