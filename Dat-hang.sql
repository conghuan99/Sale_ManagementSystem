use master
go
if db_id('QLBH') is not null
drop database QLBH;
go
create database QLBH
go

use QLBH
go

create table NHANVIEN
(
	MaNV int,
	TenNV nvarchar(30),
	DiaChi nvarchar(30),
	sdt char(10),
	ChucVu nvarchar(20),
	constraint pk_NV primary key (MaNV)
)

create table MATHANG
(
	MaMH int,
	TenMH nvarchar(30),
	SLTon int,
	SLToiDa int,
	SLToiThieu int,
	SLHangLoiToiDa int,
	Loai int,
	constraint pk_MH primary key (MaMH)
)

create table LOAIHANG
(
	MaLoai int,
	TenLoai nvarchar(20),
	constraint pk_Loai primary key (MaLoai)
)

create table DONDATHANG
(
	MaDDH char(5),
	HoTenKH nvarchar(30),
	DiaChi nvarchar(30),
	sdt char(10),
	NgayLap date,
	NVGH int,
	NVBH int,
	ThuQuy int,
	TinhTrang nvarchar(50),
	constraint pk_DDH primary key (MaDDH)
)

create table CHITIETDDH
(
	MaDDH char(5),
	MaMH int,
	SoLuong int,
	DonGia int,
	constraint pk_CTDDH primary key (MADDH,MaMH)
)

create table HDTHANHTOANTHE
(
	MaHDTTT char(10),
	MADDH CHAR(5),
	SoTien int,
	ChuSoHuu nvarchar(40),
	TinhTrangTT nvarchar(20),
	constraint pk_HDTTT primary key (MaHDTTT)
)

alter table MATHANG add constraint fk_MH_LoaiMH foreign key (Loai) references LOAIHANG (MaLoai)
alter table DONDATHANG add constraint fk_DDH_NV_1 foreign key (NVBH) references NHANVIEN (MaNV)
alter table DONDATHANG add constraint fk_DDH_NV_2 foreign key (NVGH) references NHANVIEN (MaNV)
alter table DONDATHANG add constraint fk_DDH_NV_3 foreign key (ThuQuy) references NHANVIEN (MaNV)
alter table CHITIETDDH add constraint fk_CTDDH_DDH foreign key (MaDDH) references DONDATHANG (MaDDH)
alter table CHITIETDDH add constraint fk_CTDDH_MH foreign key (MaMH) references MATHANG (MaMH)
alter table HDTHANHTOANTHE add constraint fk_HDTTT_DDH foreign key (MADDH) references DONDATHANG (MaDDH)

insert into NHANVIEN values (1,N'Phạm Quang Hùng',N'Hồ chí Minh','1900561270',N'Bán hàng')
insert into NHANVIEN values (2,N'Nguyễn Huy',N'Hồ chí Minh','0931245632',N'Giao hàng')
insert into NHANVIEN values (3,N'Hồ Thị Lan',N'Đà Nẵng','0932456345',N'Giao hàng')
insert into NHANVIEN values (4,N'Võ Đức',N'Hồ chí Minh','0932874875',N'Bán hàng')
insert into NHANVIEN values (5,N'Nguyễn Văn Phú',N'Hồ chí Minh','0965234874',N'Thủ quỹ')
insert into NHANVIEN values (6,N'Võ Công Huân',N'Quảng Nam','0355234800',N'Thủ quỹ')
insert into NHANVIEN values (7,N'Lê Tấn Phong',N'Hồ chí Minh','0365224873',N'Thủ quỹ')


insert into LOAIHANG values (1,N'Thực phẩm')
insert into LOAIHANG values (2,N'Hàng gia dụng')
insert into LOAIHANG values (3,N'Hàng điện tử')

insert into MATHANG values (1,N'Gà rán',20,50,10,5,1)
insert into MATHANG values (2,N'Dao',20,50,10,5,2)
insert into MATHANG values (3,N'Gạo',20,50,10,5,1)
insert into MATHANG values (4,N'Dây điện',20,50,10,5,3)

insert into DONDATHANG values ('DH001',N'An',N'Hồ Chí Minh','0321422543','2020-07-07',3,4,5,N'Đã thanh toán')
insert into DONDATHANG values ('DH002',N'Bình',N'Hồ Chí Minh','0923667443','2020-07-21',2,1,5,N'Đã thanh toán')
insert into DONDATHANG values ('DH003',N'Hải',N'Hồ Chí Minh','0923556489','2020-07-13',3,1,null,N'Đang giao - Chưa Thanh Toán')
insert into DONDATHANG values ('DH004',N'Hải',N'Hồ Chí Minh','0923766489','2020-07-13',3,1,5,N'Đang giao - Đã Thanh Toán')
insert into DONDATHANG values ('DH005',N'Huân',N'Quảng Nam','0927887332','2020-07-19',2,4,5,N'Đã thanh toán')
insert into DONDATHANG values ('DH006',N'Luyện',N'Hà Nội','0935887312','2020-07-09',2,4,null,N'Chưa thanh toán')
insert into DONDATHANG values ('DH007',N'Phương',N'Hồ Chí Minh','0327887002','2020-09-19',2,4,null,N'Chưa thanh toán')

insert into CHITIETDDH values ('DH001',1,2,30000)
insert into CHITIETDDH values ('DH001',2,1,15000)
insert into CHITIETDDH values ('DH002',3,10,14000)
insert into CHITIETDDH values ('DH003',1,5,30000)
insert into CHITIETDDH values ('DH004',1,4,30000)
insert into CHITIETDDH values ('DH004',4,2,12000)
insert into CHITIETDDH values ('DH005',4,1,12000)
insert into CHITIETDDH values ('DH006',3,1,14000)
insert into CHITIETDDH values ('DH006',2,1,15000)
insert into CHITIETDDH values ('DH007',4,5,12000)

INSERT INTO HDTHANHTOANTHE VALUES ('HDTTT001', 'DH002', 90000, N'Nguyễn Văn An', N'Đã Thanh Toán');
INSERT INTO HDTHANHTOANTHE VALUES ('HDTTT002', 'DH005', 12000, N'Võ Công Huân', N'Đã Thanh Toán');