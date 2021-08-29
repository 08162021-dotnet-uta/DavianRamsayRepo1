-- DDL = data definition language
use master;
go

-- CREATE
create database StoreApplicationDB;
go

--drop database StoreApplicationDB;
--go

use StoreApplicationDB;
go

create schema Store;
go

create schema Customer;
go


create table Customer.Customer
(
    -- char, nchar, varchar, ncvarchar
    -- tinyint, smallint, int, bigint, money, decimal, numerical
    CustomerId tinyint not null identity(1,1)
    ,Name nvarchar(100) not null
    ,Active bit not null
);

create table Store.Store
(
    StoreId tinyint not null identity(1,1)
    ,Name nvarchar(100) not null
    ,Active bit not null
);

create table Store.Product
(
    ProductId tinyint not null identity(1,1)
    ,Name nvarchar(100) not null
    ,Price money not null
    ,Active bit not null
);

create table Store.[Order]
(
    OrderId smallint not null identity(1,1)
    ,CustomerId tinyint not null
    ,StoreId tinyint not null
	,OrderDate datetime2(7) not null
    ,Active bit not null
);

create table Store.OrderProduct
(
    OrderProductId smallint not null identity(1,1)
    ,OrderId smallint not null
    ,ProductId smallint not null
    ,Active bit not null
);
go

-- ALTER
alter table Customer.Customer
    add constraint PK_Customer primary key (CustomerId);

alter table Store.Store
    add constraint PK_Store primary key (StoreId);

alter table Store.[Order]
    add constraint PK_Order primary key (OrderId);

alter table Store.OrderProduct
    add constraint PK_OrderProduct primary key (OrderProductId);

alter table Store.Product
    add constraint PK_Product primary key (ProductId);

alter table Store.[Order]
    add constraint FK_Order_Customer foreign key (CustomerId) references Customer.Customer(CustomerId);

alter table Store.[Order]
    add constraint FK_Order_Store foreign key (StoreId) references Store.Store(StoreId);

alter table Customer.Customer
    add Active bit not null;







---new alter on 27 Aug 2021
alter table Customer.Customer
    add constraint DF_Customer default (1) for Active;

alter table Store.Store
    add constraint DF_Store default (1) for Active;

alter table Store.[Order]
    add constraint DF_Order default (1) for Active;

alter table Store.Product
    add constraint DF_Product default (1) for Active;


alter table Store.OrderProduct
    add constraint DF_OrderProduct default (1) for Active;


alter table Store.[Order]
    add constraint CK_Order check(OrderDate <= getdate());
-- DROP
--drop database StoreApplicationDB;
--drop schema Customer;
--drop table Customer.Customer;

-- TRUNCATE
--truncate table Customer.Customer;

--Stored Procedure
--normally use sp for any stored procedure
create procedure SP_AddCustomer(@name nvarchar(100))
as
begin
	@declare @result nvarchar(100);
	select @result = [Name]
	from Customer.Customer
	where [Name] = @name

	if (@result is null)
	begin
		insert into Customer.Customer([Name])
		values(@name)
	end 
end

	insert into Customer.Customer
	values (@name)
end