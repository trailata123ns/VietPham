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
    class BLLQuanLySach
    {
        DAL dal = new DAL();
        public DataTable getSach()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void insertSach(String maSach, String tenSach, String theLoai, float giaBan, String tacGia, String nhaXb, int soLuong,String anh)
        {
            try
            {
                    String sql = "Insert into Sach values('" + maSach + "',N'" + tenSach+ "',N'" + theLoai + "','" + giaBan + "',N'" + tacGia + "',N'" + nhaXb + "','"+soLuong+"','"+anh+"')";
                    dal.ExecuteNonQuerry(sql);   
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           // MessageBox.Show("Đăng ký thành công !", "Thông báo");
        }

        public void deleteSach(String maSach)
        {
            try
            {
                String sql = "delete from Sach where maSach = '" + maSach + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable getHinhanh(String maSach)
        {
            String sql = "select anh from Sach where maSach = '"+maSach+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void updateSach(String maSach, String tenSach, String theLoai, float giaBan, String tacGia, String nhaXb, int soLuong, String anh)
        {
            try
            {
                String sql = "update Sach set tenSach = N'" + tenSach + "',theLoai = N'" + theLoai + "',giaBan = '" + giaBan + "',tacGia = N'" + tacGia + "',nhaXb = N'" + nhaXb + "',soLuong = '" + soLuong + "',anh = '" + anh + "' where maSach = '" + maSach + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable SearchSach(String chuoi, String truong)
        {
  
            string sql = "SELECT maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach where " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.getTable(sql);
            return dt;
        }


    }
}
