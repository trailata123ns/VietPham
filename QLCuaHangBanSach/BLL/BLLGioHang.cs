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
    class BLLGioHang
    {
        DAL dal = new DAL();
        public DataTable getGioHang(String makh)
        {
            String sql = "select GioHang.maSach,tenSach,GioHang.soLuong,giaBan,GioHang.soLuong*giaBan as thanhTien,statuss from GioHang inner join Sach on GioHang.maSach = Sach.maSach where maGioHang = '"+makh+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getChiTietDonHang(String maKh)
        {
            String sql = "select tenSach,GioHang.soLuong,giaBan,GioHang.soLuong*giaBan as thanhTien,Sach.maSach from GioHang inner join Sach on GioHang.maSach = Sach.maSach where statuss = 'True' and maGioHang = '" + maKh + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void updateStatus(String maSach, String maGioHang,Boolean stt)
        {
            try
            {
                String sql = "update GioHang set statuss = '" + stt + "' where maSach = '" + maSach + "' and maKh = '" + maGioHang + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void insertGioHang(String maGioHang, String maKh, String maSach,int soLuong,Boolean statuss)
        {
            try
            {
                String sql = "Insert into GioHang values('" + maGioHang + "','" + maKh + "','" +maSach + "','" + soLuong + "','" + statuss + "')";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // MessageBox.Show("Đăng ký thành công !", "Thông báo");
        }

        public DataTable getMaKh(String user)
        {
            String sql = "select maKh from KhachHang where userr = '"+user+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void updateSoLuongGioHang(String maSach,String maGioHang,int soLuong)
        {
            try
            {
                String sql = "update GioHang set soLuong = "+soLuong.ToString()+" where maSach = '" + maSach + "' and maKh = '"+maGioHang+"'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void deleteGioHang(String maSach,String maGioHang)
        {
            try
            {
                String sql = "delete GioHang where maSach = '" + maSach + "' and maKh = '" + maGioHang + "'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void deleteGioHangByStatus(String maSach, String maGioHang)
        {
            try
            {
                String sql = "delete GioHang where maSach = '" + maSach + "' and maKh = '" + maGioHang + "' and statuss = 'True'";
                dal.ExecuteNonQuerry(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void deleteGioHang(String maGioHang)
        {
            try
            {
                String sql = "delete GioHang where maKh = '" + maGioHang + "'";
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
