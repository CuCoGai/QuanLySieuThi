CREATE DATABASE BANHANGSIEUTHI
USE BANHANGSIEUTHI
GO
CREATE TABLE LoaiHang
(
	MaLoai int identity primary key,
	DienGiai ntext
)
CREATE TABLE HangHoa
(
	MaLoai int not null references LoaiHang(MaLoai),
	MaHang int identity primary key,
	TenHang nvarchar(100),
	DonViTinh nvarchar(20),
	TenNhaSanXuat ntext,
	Gia money
)
CREATE TABLE KhachHang
(
	MaKh int identity primary key,
	TenKh nvarchar(100),
	DiaChi nvarchar(100),
	SoDienThoai varchar(20)
)
CREATE TABLE NhanVien
(
	MaNv int identity primary key,
	TenNv nvarchar(100),
	DiaChi nvarchar(100),
	MaChucVu int references ChucVu(MaChucVu),
	HeSoLuong float,
	GioiTinh bit,
	NgaySinh datetime
)
CREATE TABLE ChucVu
(
	MaChucVu int identity primary key,
	ChucVu nvarchar(100),
	QuyenTruyCap int
)
CREATE TABLE DoiTac
(
	MaDoiTac int identity primary key,
	TenDoiTac nvarchar(100),
	DiaChi nvarchar(100),
	SoDienThoai varchar(20),
	Website varchar(100),
	NguoiDaiDien nvarchar(100),
	SdtNguoiDaiDien varchar(20)
)
CREATE TABLE PhieuNhap
(
	MaPhieu int identity primary key,
	MaHienThi varchar(20),
	MaNv int references NhanVien(MaNv),
	MaDoiTac int references DoiTac(MaDoiTac),
	NgayNhap datetime,
	TienHang money,
	ThueVat money,
	TongTien money
)
CREATE TABLE PhieuXuat
(
	MaPhieu int identity primary key,
	MaHienThi varchar(20),
	MaNv int references NhanVien(MaNv),
	MaKh int references KhachHang(MaKh),
	NgayXuat datetime,
	TienHang money,
	ChietKhau money,
	TongTien money
)
CREATE TABLE ChiTietNhap
(
	MaPhieu int references PhieuNhap(MaPhieu) primary key,
	MaLoai int references LoaiHang(MaLoai),
	MaHang int references HangHoa(MaHang),
	SoLuong bigint,
	GiaNhap money,
	NgaySx datetime,
	HanSd datetime
)
CREATE TABLE ChiTietXuat 
(
	MaPhieu int references PhieuXuat(MaPhieu) primary key ,
	MaLoai int references LoaiHang(MaLoai),
	MaHang int references HangHoa(MaHang) ,
	SoLuong bigint,
	GiaXuat money
)