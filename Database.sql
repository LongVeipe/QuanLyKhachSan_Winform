create database QuanLyKhachSan
go

use QuanLyKhachSan
go

-- >>> TẠO CÁC BẢNG CÓ TRONG CƠ SỞ DỮ LIỆU <<<

-- Tạo bảng Account
create table Account
(
	IdAccount int identity primary key,
	Username varchar(30) not null unique,
	Password varchar(30) not null,
	TypeAccount bit not null, -- 1. Quản lý | 0. Nhân viên
	IdEmployee int
)
go

-- Tạo bảng Employee
create table Employee
(
	IdEmployee int identity primary key,
	Cmnd varchar(20) not null unique,
	Name nvarchar(30) not null,
	Address nvarchar(60),
	Phone varchar(20)
)
go

-- Tạo bảng Customer
create table Customer
(
	IdCustomer int identity primary key,
	Cmnd varchar(20) not null unique,
	Name nvarchar(30) not null,
	Phone varchar(20)
)
go

-- Tạo bảng SizeRoom
create table SizeRoom
(
	IdSizeRoom int identity primary key,
	SizeRoom int not null
)
go

-- Tạo bảng PriceRoom
create table PriceRoom
(
	IdSizeRoom int,
	TypeRoom bit not null, -- 1. VIP | 0. Thường
	Price money not null

	constraint PriceRoom_PK primary key (IdSizeRoom, TypeRoom)
)
go

-- Tạo bảng Room
create table Room
(
	IdRoom int identity primary key,
	Name nvarchar(20) not null unique,
	IdSizeRoom int,
	TypeRoom bit not null, -- 1. VIP | 0. Thường
	Price money,
	Status bit default 0, -- 1. Bận | 0. Trống
)
go

-- Tạo bảng Service
create table Service
(
	IdService int identity primary key,
	Name nvarchar(20) not null unique,
	Price money not null
)
go

-- Tạo bảng Bill
create table Bill
(
	IdBill int identity primary key,
	IdCustomer int,
	IdRoom int,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	TotalPrice money,
	Status bit not null default 0 -- 1. Đã thanh toán | 0. Chưa thanh toán
)
go

-- Tạo bảng DetailService
create table DetailService
(
	IdBill int,
	IdService int,
	Count int not null

	constraint DetailService_PK primary key (IdBill, IdService)
)
go

-- >> TẠO CÁC RÀNG BUỘC KHÓA NGOẠI <<

-- Tạo khóa ngoại Account.IdEmployy tham chiếu Employee.IdEmployee
alter table Account add constraint Account_Employee_FK foreign key (IdEmployee) references Employee(IdEmployee)

-- Tạo khóa ngoại PriceRoom.IdSizeRoom tham chiếu SizeRoom.IdSizeRoom
alter table PriceRoom add constraint PriceRoom_SizeRoom_FK foreign key (IdSizeRoom) references SizeRoom(IdSizeRoom)

-- Tạo khóa ngoại Room.IdSizeroom tham chiếu SizeRoom.IdSizeRoom
alter table Room add constraint Room_SizeRoom_FK foreign key (IdSizeRoom) references SizeRoom(IdSizeRoom)

-- Tạo khóa ngoại Bill.IdCustomer tham chiếu Customer.IdCustomer
alter table Bill add constraint Bill_Customer_FK foreign key (IdCustomer) references Customer(Idcustomer)

-- Tạo khóa ngoại Bill.IdRoom tham chiếu Room.IdRoom
alter table Bill add constraint Bill_Room_FK foreign key (IdRoom) references Room(IdRoom)

-- Tạo khóa ngoại DetailService.IdBill tham chiếu Bill.IdBill
alter table DetailService add constraint DetailService_Bill_FK foreign key (IdBill) references Bill(Idbill)

-- Tạo khóa ngoại DetailService.IdService tham chiếu Service.IdService
alter table DetailService add constraint DetailService_Service_FK foreign key (IdService) references Service(IdService)

go

-- >> THÊM TÀI KHOẢN ADMIN <<
insert into Employee (Cmnd,Name,Address,Phone) values ('11111111',N'Quản Trị Viên',N'Chưa xác định','11111111')
insert into Account (Username,Password,TypeAccount,IdEmployee) values ('admin','admin',1,1)

go

-- >> TẠO STORED PROCEDURE <<
create proc USP_Login
@userName nvarchar(30), @passWord varchar(30)
as
begin
	select * from Account where Username = @userName and Password = @passWord
end
go

create Proc MonthProceeds
@year varchar(4), @month varchar(2)
as
begin
	select Day(DateCheckOut) as Ngay, sum(TotalPrice) as Total
	from Bill
	where MONTH(DateCheckOut) = @month and YEAR(DateCheckOut) = @year
	group by DateCheckOut
	order by 1 asc
end
go

create Proc YearProceeds
@year varchar(4)
as
begin
	select MONTH(DateCheckOut) as Thang, sum(TotalPrice) as Total
	from Bill
	where YEAR(DateCheckOut) = @year
	group by MONTH(DateCheckOut)
	order by 1 asc
end
go