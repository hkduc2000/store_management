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

select * from category where FatherID=7
select count(*) from category;
select * from Category;

select * from Product;
insert into Product values('Product1', N'Đây là product test thứ 1', 1000, 1500, 10,1)
insert into Product values('Product2', N'Đây là product test thứ 2', 1000, 1500, 10,8)



Drop table ProductInInvoice
drop table Product