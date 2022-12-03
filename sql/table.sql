-- Create database
CREATE DATABASE [SupermarketManagement]
GO
USE [SupermarketManagement]
GO

-- Create tables
CREATE TABLE Position (
	position_id INT IDENTITY(1,1),
	name NVARCHAR(100) NOT NULL,
	salary INT NOT NULL,
	CONSTRAINT Position_pk PRIMARY KEY (position_id),
	CONSTRAINT Position_pk_check_salary CHECK (salary > 0),
)
GO

CREATE TABLE Employee (
	employee_id INT IDENTITY(1,1),
	name NVARCHAR(100) NOT NULL,
	phone VARCHAR(10) NOT NULL,
	position_id INT NOT NULL,
	CONSTRAINT Employee_pk PRIMARY KEY (employee_id),
	CONSTRAINT Employee_fk_Position_position_id
		FOREIGN KEY (position_id) REFERENCES Position(position_id)
)
GO

CREATE TABLE Account (
	username VARCHAR(100),
	password VARCHAR(100) NOT NULL,
	employee_id INT NOT NULL,
	CONSTRAINT Account_pk PRIMARY KEY (username),
	CONSTRAINT Account_fk_Employee_employee_id 
		FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
ON DELETE CASCADE
)
GO

CREATE TABLE Customer (
	customer_phone VARCHAR(10),
	name NVARCHAR(100) NOT NULL,
	birthday DATE,
	gender NVARCHAR(3),
	point INT NOT NULL,
	CONSTRAINT Customer_pk PRIMARY KEY (customer_phone),
	CONSTRAINT Customer_chk_point CHECK (point >= 0)
)
GO

CREATE TABLE Warehouse (
	warehouse_id INT IDENTITY(1,1),
	name NVARCHAR(100) NOT NULL,
	address NVARCHAR(100),
	CONSTRAINT Warehouse_pk PRIMARY KEY (warehouse_id),
)
GO

CREATE TABLE Category (
	category_id INT IDENTITY (1, 1),
	name NVARCHAR(100),
	CONSTRAINT Category_pk PRIMARY KEY (category_id),
)
GO

CREATE TABLE Product (
	product_id INT IDENTITY(1,1),
	name NVARCHAR(100) NOT NULL,
	quantity INT NOT NULL,
	price INT NOT NULL,
	mfg_date DATE NOT NULL, -- Ngày sản xuất
	exp_date DATE NOT NULL, -- Hạn sử dụng
	available BIT NOT NULL, 
	category_id INT,
	warehouse_id INT,
	CONSTRAINT Product_pk PRIMARY KEY (product_id),
	CONSTRAINT Product_fk_Category_category_id
		FOREIGN KEY (category_id) REFERENCES Category(category_id),
	CONSTRAINT Product_fk_Kho_warehouse_id
		FOREIGN KEY (warehouse_id) REFERENCES Warehouse(warehouse_id),
	CONSTRAINT Product_chk_price CHECK (price >= 0), -- quà tặng: giá = 0
	CONSTRAINT Product_chk_quantity CHECK (quantity >= 0),
	CONSTRAINT Product_chk_exp_date CHECK (exp_date > mfg_date),
)
GO

CREATE TABLE Company (
	company_id INT IDENTITY(1,1),
	name NVARCHAR(100) NOT NULL,
	address NVARCHAR(100) NOT NULL,
	phone VARCHAR(10) NOT NULL,
	CONSTRAINT Company_pk PRIMARY KEY (company_id),
)
GO

CREATE TABLE Import (
	import_id INT IDENTITY (1, 1),
	company_id INT,
	product_id INT,
	import_date DATETIME,
	quantity INT NOT NULL,
	price INT NOT NULL,
	available BIT,
	CONSTRAINT Import_pk PRIMARY KEY (import_id),
	CONSTRAINT Import_fk_Company_company_id 
		FOREIGN KEY (company_id) REFERENCES Company(company_id),
	CONSTRAINT Import_fk_Product_product_id 
		FOREIGN KEY (product_id) REFERENCES Product(product_id),
	CONSTRAINT Import_chk_quantity CHECK (quantity > 0),
	CONSTRAINT Import_chk_price CHECK (price > 0),
)
GO

CREATE TABLE Bill (
	bill_id INT IDENTITY(1,1),
	employee_id INT,
	customer_phone VARCHAR(10),
	created DATETIME NOT NULL,
	discount INT NOT NULL,
	total INT NOT NULL,
	available BIT NOT NULL,
	CONSTRAINT Bill_pk PRIMARY KEY (bill_id),
	CONSTRAINT Bill_fk_Employee_employee_id 
		FOREIGN KEY (employee_id) REFERENCES Employee(employee_id),
	CONSTRAINT Bill_fk_Customer_customer_phone
		FOREIGN KEY (customer_phone) REFERENCES Customer(customer_phone),
)
GO

CREATE TABLE BillInfo (
	bill_id INT,
	product_id INT,
	quantity INT NOT NULL,
	price INT NOT NULL,
	CONSTRAINT BillInfo_pk PRIMARY KEY (bill_id, product_id),
	CONSTRAINT BillInfo_fk_Bill_bill_id
		FOREIGN KEY (bill_id) REFERENCES Bill(bill_id),
	CONSTRAINT BillInfo_fk_Product_product_id
		FOREIGN KEY (product_id) REFERENCES Product(product_id),
	CONSTRAINT BillInfo_chk_quantity CHECK (quantity > 0),
	CONSTRAINT BillInfo_chk_price CHECK (price >= 0), -- quà tặng: giá = 0 
)
GO