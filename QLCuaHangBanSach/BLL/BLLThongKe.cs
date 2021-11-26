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
    class BLLThongKe
    {
        DAL dal = new DAL(); 
        public DataTable doanhthungay(int nam, int thang, int ngay)
        {
            String sql = "select sum(tongTien) from DonHangAd where year(ngayLap) = '" + nam + "' and month(ngayLap) = '" + thang + "' and day(ngayLap) = '" + ngay + "' and trangThai = "+"N'Đã xác nhận'" ;
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable doanhthuthang(int nam, int thang)
        {
            String sql = "select sum(tongTien) from DonHangAd where year(ngayLap) = '" + nam + "' and month(ngayLap) = '" + thang + "' and trangThai = " + "N'Đã xác nhận'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        ///
        public DataTable tongsoluong(DateTime Start, DateTime End)
        {
            String start = Start.ToString("yyyy-MM-dd");
            String end = End.ToString("yyyy-MM-dd");
            String sql = "select sum(soLuong) from DonHangAd inner join ChiTietDonHang on ChiTietDonHang.maDonHang=DonHangAd.maDonHang where ngayLap>='" + start + "' and ngayLap<='" + end + "' and trangThai = " + "N'Đã xác nhận'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable tongdoanhthu(DateTime Start, DateTime End)
        {
            String start = Start.ToString("yyyy-MM-dd");
            String end = End.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            String sql = "select sum(tongTien) from DonHangAd where ngayLap>='" + start + "' and ngayLap<='" + end + "' and trangThai = " + "N'Đã xác nhận'";
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable tongsoluong_2(int nam, String thang, String ngay)
        {
            String sql = "";
            if (thang == "all") sql = "select sum(soLuong) from DonHangAd inner join ChiTietDonHang on ChiTietDonHang.maDonHang=DonHangAd.maDonHang  where year(ngayLap)='" + nam + "' and trangThai = " + "N'Đã xác nhận'";
            else if (ngay == "all") sql = "select sum(soLuong) from DonHangAd inner join ChiTietDonHang on ChiTietDonHang.maDonHang=DonHangAd.maDonHang where year(ngayLap)='" + nam + "' and month(ngayLap)='" + int.Parse(thang) + "' and trangThai = " + "N'Đã xác nhận'";
            else sql = "select sum(soLuong) from DonHangAd inner join ChiTietDonHang on ChiTietDonHang.maDonHang=DonHangAd.maDonHang where year(ngayLap)='" + nam + "' and month(ngayLap)='" + int.Parse(thang) + "' and day(ngayLap)='" + int.Parse(ngay) + "' and trangThai = " + "N'Đã xác nhận'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable tongdoanhthu_2(int nam, String thang, String ngay)
        {
            DataTable dt = new DataTable();
            String sql = "";
            if (thang == "all") sql = "select sum(tongTien) from DonHangAd where year(ngayLap)='" + nam + "' and trangThai = " + "N'Đã xác nhận'";
            else if (ngay == "all") sql = "select sum(tongTien) from DonHangAd where year(ngayLap)='" + nam + "' and month(ngayLap)='" + int.Parse(thang) + "' and trangThai = " + "N'Đã xác nhận'";
            else sql = "select sum(tongTien) from DonHangAd where year(ngayLap)='" + nam + "' and month(ngayLap)='" + int.Parse(thang) + "' and day(ngayLap)='" + int.Parse(ngay) + "' and trangThai = " + "N'Đã xác nhận'";
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getHoadon1(DateTime Start,DateTime End)
        {
            String start = Start.ToString("yyyy-MM-dd");
            String end = End.ToString("yyyy-MM-dd");
            String sql = "select maDonHang,maKh,ngayLap,tongTien from DonHangAd where ngayLap>='" + start + "' and ngayLap<='" + end + "' and trangThai = " + "N'Đã xác nhận'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable getHoadon2(int nam, String thang, String ngay)
        {
            DataTable dt = new DataTable();
            String sql = "";
            if (thang == "all") sql = "select maDonHang,maKh,ngayLap,tongTien from DonHangAd where year(ngayLap)='" + nam + "' and trangThai = " + "N'Đã xác nhận'";
            else if (ngay == "all") sql = "select maDonHang,maKh,ngayLap,tongTien from DonHangAd where year(ngayLap)='" + nam + "' and month(ngayLap)='" + int.Parse(thang) + "' and trangThai = " + "N'Đã xác nhận'";
            else sql = "select maDonHang,maKh,ngayLap,tongTien from DonHangAd where year(ngayLap)='" + nam + "' and month(ngayLap)='" + int.Parse(thang) + "' and day(ngayLap)='" + int.Parse(ngay) + "' and trangThai = " + "N'Đã xác nhận'";
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
