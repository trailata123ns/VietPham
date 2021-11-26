use master
go 
create database QLCuaHangSach
go
use QLCuaHangSach
create table Account
(
	userr varchar(30) primary key,
	pass varchar(30)
)
insert into Account values('admin','123456')

create table KhachHang
(
	maKh varchar(30) primary key,
	tenKh varchar(30) not null,
	sdt varchar(30),
	diaChi varchar(30),
	ngaySinh DateTime,
	userr varchar(30) not null
)

create table HangNhap
(
	maSach varchar(30) primary key,
	tenSach nvarchar(30) not null,
	theLoai nvarchar(30) not null,
	giaBan float not null,
	tacGia nvarchar(30),
	nhaXb nvarchar(30),
	soLuong int not null,
	anh varchar(100) not null
)
create table Sach
(
	maSach varchar(30) primary key,
	tenSach nvarchar(30) not null,
	theLoai nvarchar(30) not null,
	giaBan float not null,
	tacGia nvarchar(30),
	nhaXb nvarchar(30),
	soLuong int not null,
	anh varchar(100) not null
)

create table NhaXuatBan
(
	maNhaxb varchar(30) primary key,
	tenNhaxb nvarchar(30) not null,
	diaChi nvarchar(30)
)

create table GioHang
(
	maGioHang varchar(30) not null,
	maKh varchar(30) not null,
	maSach varchar(30) not null,
	soLuong int,
	statuss bit,
	constraint pk primary key(maGioHang,maSach)
)



create table DonHang
(
	maDonHang int primary key,
	maKh varchar(30) not null,
	tongTien float not null,
	trangThai nvarchar(30) not null,
	ngayLap datetime
)

create table ChiTietDonHang
(
	maDonHang int not null,
	maSach varchar(30) not null,
	soLuong int,
	constraint pk2 primary key(maDonHang,maSach)
)


create table DonHangUser
(
	maDonHang int primary key,
	maKh varchar(30) not null,
	tongTien float not null,
	trangThai nvarchar(30) not null,
	ngayLap datetime
)

create table DonHangAd
(
	maDonHang int primary key,
	maKh varchar(30) not null,
	tongTien float not null,
	trangThai nvarchar(30) not null,
	ngayLap datetime
)
















