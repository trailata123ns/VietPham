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
    class BLLKhachHang
    {
        DAL dal = new DAL();

        public DataTable getuser(String user)
        {
            String sql = "SELECT userr From Account Where userr ='" + user + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getMaKh(String maKh)
        {
            String sql = "SELECT maKh From KhachHang Where maKh ='" + maKh + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void insertKh(String makh, String hoten, String sdt, String diaChi,String ngaySinh, String user, String pass)
        {
            try
            {
                DataTable dt1 = getuser(user);
                DataTable dt2 = getMaKh(makh);
                if (dt1.Rows.Count == 0 && dt2.Rows.Count == 0)
                {
                    String sql = "Insert into KhachHang values('" + makh + "',N'" + hoten + "','" + sdt + "',N'" + diaChi + "','" + ngaySinh + "','" + user + "')";
                    dal.ExecuteNonQuerry(sql);
                    sql = "Insert into Account values('" + user + "','" + pass + "')";
                    dal.ExecuteNonQuerry(sql);
                    MessageBox.Show("Thành công !", "Thông báo");
                }
                else if(dt1.Rows.Count > 0) MessageBox.Show("Username không được trùng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Mã khách hàng không được trùng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable getKh()
        {
            try
            {
                String sql = "Select Account.userr,pass,maKh,tenKh,sdt,diaChi,ngaySinh From Account inner join KhachHang on KhachHang.userr = Account.userr ";
                DataTable dt = new DataTable();
                dt = dal.getTable(sql);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void deleteKh(String user,String makh)
        {
            try
            {
                DataTable dt1 = getuser(user);
                DataTable dt2 = getMaKh(makh);
                if (dt1.Rows.Count > 0 && dt2.Rows.Count > 0)
                {
                    String sql = "delete from KhachHang where maKh='"+makh+"'";
                    dal.ExecuteNonQuerry(sql);
                    sql = "delete from Account where userr='" + user + "'";
                    dal.ExecuteNonQuerry(sql);
                    MessageBox.Show("Xóa thành công !", "Thông báo");
                }
                else if (dt1.Rows.Count == 0) MessageBox.Show("Username không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Mã khách hàng không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateKh(String makh, String hoten, String sdt, String diaChi, String ngaySinh, String user, String pass)
        {
            try
            {
                DataTable dt1 = getuser(user);
                DataTable dt2 = getMaKh(makh);
                if (dt1.Rows.Count > 0 && dt2.Rows.Count > 0)
                {
                    String sql = "update KhachHang set tenKh = N'" + hoten + "',sdt = '" + sdt + "',diaChi = N'" + diaChi + "',ngaySinh = '" + ngaySinh + "',userr = '" + user + "' where maKh = '" + makh + "'";
                    dal.ExecuteNonQuerry(sql);
                    sql = "update Account set pass = '" + pass + "' where userr = '" + user + "'";
                    dal.ExecuteNonQuerry(sql);
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                else if (dt1.Rows.Count == 0) MessageBox.Show("Username không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Mã khách hàng không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable getThongTin(String lb)
        {
            try
            {
                String sql = "Select pass,maKh,tenKh,sdt,diaChi,ngaySinh From Account inner join KhachHang on KhachHang.userr = Account.userr where Account.userr = '" + lb + "'";
                DataTable dt = new DataTable();
                dt = dal.getTable(sql);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable gettenKh(String maKh)
        {
            String sql = "select tenKh from KhachHang where maKh = '"+maKh+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
