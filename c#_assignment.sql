-- create database storedb
use storedb

SET XACT_ABORT ON
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
	BusinessPartner nvarchar(100),
	InvoiceType int
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

select * from Product
select * from Invoice where (CreatedDate 
between '1998-01-01' and '2020-03-26') and (invoiceType in (-1,1))
select * from ProductInInvoice
insert into Invoice values()
insert into ProductInInvoice values(2,2,10,1900)
drop table invoice
Drop table ProductInInvoice
drop table Product

begin tran
	insert into Invoice values ('2000-06-22','duc',0)
	insert into ProductInInvoice values(4,1,1,1)
commit;