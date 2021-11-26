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
    class BLLDanhSachSanPham
    {
        DAL dal = new DAL();
        public DataTable SearchSach(String chuoi, String truong)
        {

            string sql = "SELECT maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach where " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getHinhanh(String maSach)
        {
            String sql = "select anh from Sach where maSach = '" + maSach + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getSach()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable get_GiaBanGiamDan()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach ORDER BY giaBan DESC";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable get_GiaBanTangDan()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach ORDER BY giaBan";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable get_TenSachGiamDan()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach ORDER BY tenSach DESC";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable get_TenSachTangDan()
        {
            String sql = "select maSach,tenSach,theLoai,giaBan,tacGia,nhaXb,soLuong from Sach ORDER BY tenSach";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void updateSoLuongSach(String maSach,int soLuong)
        {
            try
            {
                String sql = "update Sach set soLuong = soLuong-'"+soLuong+"' where maSach = '" + maSach + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable getSoLuong(String maSach)
        {
            String sql = "select soLuong from Sach where maSach = '" + maSach + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getSachLapHoaDon()
        {
            String sql = "select tenSach,giaBan,soLuong,maSach from Sach";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getSachGioHangAd()
        {
            String sql = "select tenSach,giaBan,GioHang.soLuong,Sach.maSach from GioHang inner join Sach on GioHang.maSach = Sach.maSach where maGioHang = "+"'admin'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        
    }
}
