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
    class BLLDonHang
    {
        DAL dal = new DAL();

        public void insertDonHangUser(int maDonHang, String maKh, float tongTien, String trangThai, String ngayLap)
        {
            try
            {
                String sql = "Insert into DonHangUser values('" + maDonHang + "','" + maKh + "','" + tongTien + "',N'" + trangThai + "','" + ngayLap + "')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void insertDonHangAd(int maDonHang, String maKh, float tongTien, String trangThai, String ngayLap)
        {
            try
            {
                String sql = "Insert into DonHangAd values('" + maDonHang + "','" + maKh + "','" + tongTien + "',N'" + trangThai + "','" + ngayLap + "')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void insertDonHang(int maDonHang,String maKh,float tongTien, String trangThai,String ngayLap)
        {
            try
            {
                String sql = "Insert into DonHang values('"+maDonHang+"','" + maKh + "','" + tongTien + "',N'" + trangThai +"','"+ngayLap+"')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void insertChiTietDonHang(int maDonHang, String maSach,int soLuong)
        {
            try
            {
                String sql = "Insert into ChiTietDonHang values('" + maDonHang + "','" + maSach + "','" + soLuong + "')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable getDonHang()
        {
            String sql = "select * from DonHang";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getDonHangUser(String maKh)
        {
            String sql = "select maDonHang,tongTien,ngayLap,trangThai from DonHangUser where maKh = '"+maKh+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getChiTietDonHang()
        {
            String sql = "select tenSach,giaBan,ChiTietDonHang.soLuong,giaBan*ChiTietDonHang.soLuong as thanhTien from ChiTietDonHang inner join Sach on ChiTietDonHang.maSach = Sach.maSach";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getMaxMaDonHang()
        {
            String sql = "select MAX(maDonHang) from ChiTietDonHang";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void deleteDonHang(String maDonHang)
        {
            try
            {
                String sql = "delete from DonHang where maDonHang = '" + maDonHang + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void deleteDonHangUser(String maDonHang)
        {
            try
            {
                String sql = "delete from DonHangUser where maDonHang = '" + maDonHang + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable getSachInChiTietDonHang(String maDonHang)
        {
            String sql = "select maSach,soLuong from ChiTietDonHang where maDonHang = '"+maDonHang+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void updateSoLuongSach(String maSach, int soLuong)
        {
            try
            {
                String sql = "update Sach set soLuong = soLuong+'" + soLuong + "' where maSach = '" + maSach + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        public DataTable getChiTietDonHang(String maDonHang)
        {
            String sql = "select tenSach,giaBan,ChiTietDonHang.soLuong,giaBan*ChiTietDonHang.soLuong as thanhTien from ChiTietDonHang inner join Sach on ChiTietDonHang.maSach = Sach.maSach where maDonHang = '"+maDonHang+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void updateTrangThai1(String maDonHang,String trangthai)
        {
            try
            {
                String sql = "update DonHangUser set trangThai = N'" + trangthai + "' where maDonHang = '" + maDonHang+"'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void updateTrangThai(String maDonHang,String trangthai)
        {
            try
            {
                String sql = "update DonHang set trangThai =  N'"+trangthai+"' where maDonHang = '" + maDonHang + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void updateTrangThai2(String maDonHang, String trangthai)
        {
            try
            {
                String sql = "update DonHangAd set trangThai = N'" + trangthai + "' where maDonHang = '" + maDonHang + "'";
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
