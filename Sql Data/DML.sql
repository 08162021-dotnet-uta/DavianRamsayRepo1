--DML = data manipulation language 
use StoreApplicationDB
go

--INSERT
insert into Customer.Customer([Name])
values ('fred'), ('Tyler'), ('Cory');

--select statements for data
select Name, Active 
from Customer.Customer;


insert into Store.Product([Name], Price)
values ('computer', 500), ('monitor', 200);

---Select statement
select Name, Price, Active
from Store.Product;


insert into Store.Store([Name])
values ('Grocery Store'), ('Athletic Store'), ('OnlineStore');


--UPDATE
update Customer.Customer
set Name = "Naivad"
where name = "Davian";


--DELETE
delete Customer.Customer
where Name = "Davian";

--SELECT
---order of execution (in select statement)
---from
---where
---group by
---HAVING ---having is the filter for groups
---select
---order by 

--report on all current customer
select [Name]
from Customer.Customer
where Active =1;

---create report on most sold products (at least 100 sold)
---ProductOrder(count(productid))
select ProductId
from Store.OrderProduct
group by ProductId
having count(ProductId) > 99;


--SETS - 2 major types, namely 
--JOIN = ability to relate/compose 2 or more tables based on indexes/keys---definitions in book

--Question 
--which customer bought a monitor
--Ans: customer, order, product, order product
select Name
from Store.Product as sp
inner join Store.OrderProduct as sop on sop.ProductId = sp.ProductId
left join Store.[Order] as so on so.OrderId = sop.OrderId
left join Customer.Customer as cc on cc.CustomerId = so.CustomerId
where sp.Name = 'monitor'

---example of an inner join


--UNION = ability to relate/compose 2 or more table based on datatypes