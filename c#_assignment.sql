-- create database storedb
use storedb

create table Category(
	CategoryID int identity(1,1) primary key,
	CategoryName nvarchar(200),
	FatherID int references Category(CategoryID),
)

create table Product(
	ProductID int identity(1,1) primary key,
	ProductName nvarchar(200),
	Description nvarchar(2000),
	CostPrice int,
	Price int, 
	Quantity int, 
	CategoryID int references Category(CategoryID)
)

create table Invoice(
	InvoiceID int identity(1,1) primary key,
	CreatedDate Datetime,
	TotalPrice int, 

)

create table ProductInInvoice(
	InvoiceID int references Invoice(InvoiceID),
	ProductID int references Product(ProductID),
	Quantity int,
	Price int
	primary key (InvoiceID, ProductID)
)

select * from category where FatherID is null
select count(*) from category;
select * from Category;
insert into Category values(N'Thực phẩm', null);
insert into Category values(N'Tiêu dùng', null);
insert into Category values(N'Đồ ăn liền', 1);
insert into Category values(N'Trái cây', 1);
insert into Category values(N'Tươi sống', 1);
insert into Category values(N'Nhập khẩu', 4);
insert into Category values(N'Trái cây việt', 4);