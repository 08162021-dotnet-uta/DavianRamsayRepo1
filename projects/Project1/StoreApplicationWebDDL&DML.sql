CREATE DATABASE StoreApplicationWebApp
USE StoreApplicationWebApp

CREATE TABLE Customer
(
  CustomerId INT PRIMARY KEY IDENTITY (1,1),
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  Email VARCHAR(60) NOT NULL
);

DROP TABLE Customer
ALTER TABLE Customer
ADD Password VARCHAR(30) NOT NULL

CREATE TABLE [Order]
(
  OrderId INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
  OrderDate DATETIME NOT NULL DEFAULT GETDATE(),
  CustomerId INT NOT NULL REFERENCES Customer(CustomerId) ON DELETE CASCADE,
  StoreId INT NOT NULL REFERENCES Store(StoreId) ON DELETE CASCADE,
);


CREATE TABLE Store
(
  StoreId INT PRIMARY KEY IDENTITY (1,1),
  Location VARCHAR(100) NOT NULL
);


CREATE TABLE Product
(
  ProductId INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
  ProductName VARCHAR(50) NOT NULL,
  Price DECIMAL (19,2) NOT NULL,
  ProductDescription VARCHAR(100) NOT NULL,
);

ALTER TABLE Product ADD PRIMARY KEY(ProductId)




CREATE TABLE OrderProduct
(
  OrderProductId UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
  OrderId INT NOT NULL REFERENCES [Order](OrderId) ON DELETE CASCADE,
  ProductId INT NOT NULL REFERENCES Product(ProductId) ON DELETE CASCADE,
  ProductQuantity INT NOT NULL,
);

CREATE TABLE Inventory
(
  InventoryId INT IDENTITY (1,1) NOT NULL,
  StoreId INT NOT NULL REFERENCES Store(StoreId) ON DELETE CASCADE,
  ProductsId INT NOT NULL REFERENCES Product(ProductId) ON DELETE CASCADE,
);







--SELECTS
SELECT *
FROM Customer
SELECT *
FROM Product
SELECT *
FROM [Order]
SELECT *
FROM Store
SELECT *
FROM OrderProduct
SELECT *
FROM Inventory


---INSERTS 

----CUSTOMERS 
SELECT *
FROM Customer

INSERT INTO Customer
  (FirstName, LastName, Email, [Password])
VALUES('Davian', 'Ramsay', 'davianramsay@gmail.com', '123456');

INSERT INTO Customer
  (FirstName, LastName, Email, [Password])
VALUES
  ('Kimberly', 'Browne', 'sistakimberly@gmail.com', '123456');

INSERT INTO Customer
  (Firstname, LastName, Email, [Password])
VALUES
  ('Keisha', 'Ramsay', 'kshramsay@gmail.com', '123456');

INSERT INTO Customer
  (FirstName, LastName, Email, [Password])
VALUES
  ('Tori', 'Williams-Ramsay', 'toriswilliams14@gmail.com', '123456');


---PRODUCTS 
SELECT *
FROM Product

INSERT INTO Product
  (ProductName, Price, ProductDescription)
VALUES
  ('IPhone', '25.55', 'Mobile Phone');

INSERT INTO Product
  (ProductName, Price, ProductDescription)
VALUES
  ('Galaxy Note 20 Ultra', 35, 'Mobile Phone');



---STORES
SELECT *
FROM Store
INSERT INTO Store
  (Location)
VALUES
  ('Princess Street');



--ORDER
SELECT *
FROM [Order]

INSERT INTO [Order]
  (CustomerId, StoreId)
VALUES
  (2, 1);



--ORDERPRODUCT
SELECT *
FROM OrderProduct
INSERT INTO OrderProduct
  (OrderId, ProductId, ProductQuantity)
VALUES(11, 1, 2);