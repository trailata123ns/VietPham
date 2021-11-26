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
    class BLLHangNhap
    {
        DAL dal = new DAL();
        public DataTable getHangNhap()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from HangNhap";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getMaSach(String maSach)
        {
            String sql = "select * from HangNhap where maSach = '"+maSach+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void insertHangNhap(String maSach, String tenSach, String theLoai, float giaBan, String tacGia, String nhaXb, int soLuong, String anh)
        {
            try
            {
                String sql = "Insert into HangNhap values('" + maSach + "',N'" + tenSach + "',N'" + theLoai + "','" + giaBan + "',N'" + tacGia + "',N'" + nhaXb + "','" + soLuong + "','" + anh + "')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void updateSach(String maSach,int soLuong)
        {
            try
            {
                String sql = "update HangNhap set soLuong = soLuong+ '"+soLuong+"' where maSach = '" + maSach + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
