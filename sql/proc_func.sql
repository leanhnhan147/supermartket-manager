USE [SupermarketManagement]
GO

----------------------------- Vị trí -----------------------------
-- Thêm vị trí
CREATE PROC [dbo].[proc_Position_Add]
	@name NVARCHAR(100),
	@salary INT
AS
    INSERT INTO Position (name, salary) 
    VALUES (@name, @salary) 
GO

-- Xóa vị trí
CREATE PROC [dbo].[proc_Position_Delete]
	@position_id INT
AS
	DELETE FROM Position 
	WHERE position_id = @position_id
GO

-- Chính sửa vị trí
CREATE PROC [dbo].[proc_Position_Update]
	@position_id INT,
	@name NVARCHAR(100),
	@salary INT
AS
    UPDATE Position SET name = @name, salary = @salary
    WHERE position_id = @position_id
GO

--
CREATE FUNCTION [dbo].[func_Position_GetAll]()
RETURNS TABLE
AS
	RETURN (
		SELECT * 
		FROM [dbo].[Position]
	)
GO

----------------------------- Nhân viên -----------------------------
-- Thêm nhân viên
CREATE PROC [dbo].[proc_Employee_Add]
	@name NVARCHAR(100), 
	@phone VARCHAR(10),
	@position_id INT
AS
    INSERT INTO Employee (name, phone, position_id) 
    VALUES (@name, @phone, @position_id)
GO

-- Xóa nhân viên
CREATE PROC [dbo].[proc_Employee_Delete]
	@employee_id INT
AS
    DELETE FROM Employee 
    WHERE employee_id = @employee_id
GO

-- Chỉnh sửa nhân viên
CREATE PROC [dbo].[proc_Employee_Update]
	@employee_id INT,
	@name NVARCHAR(100),
	@phone VARCHAR(10),
	@position_id INT
AS
	UPDATE Employee SET name = @name, phone = @phone, position_id = @position_id
	WHERE employee_id = @employee_id
GO

--
CREATE FUNCTION [dbo].[func_Employee_GetAll]()
RETURNS TABLE
AS
	RETURN (
		SELECT E.employee_id, E.name, phone, P.position_id, P.name position_name
		FROM [dbo].[Employee] E JOIN [dbo].[Position] P
		ON E.position_id = P.position_id
	)
GO

----------------------------- Tài khoản -----------------------------
-- Thêm tài khoản
CREATE PROC [dbo].[proc_Account_Add]
	@username VARCHAR(100), 
	@password VARCHAR(100),
	@employee_id INT
AS
BEGIN
	-- Thêm Account
    INSERT INTO [dbo].[Account] (username, password, employee_id) 
    VALUES (@username, @password, @employee_id)

	-- Tạo login
	DECLARE @createLogin NVARCHAR (400)
	DECLARE @createUser NVARCHAR (400)

	SET @createLogin = 'CREATE LOGIN ' + @username + ' WITH PASSWORD = ''' + @password + ''', DEFAULT_DATABASE = SupermarketManagement, CHECK_POLICY = OFF, CHECK_EXPIRATION = OFF;'
	SET @createUser = 'CREATE USER ' + @username + ' FOR LOGIN ' + @username
	EXEC (@createLogin)
	EXEC (@createUser)

	-- Lấy Role ID tương ứng với Username
	DECLARE @statement VARCHAR(200)
	DECLARE @roleID INT

	SELECT @roleID = Position.position_id
	FROM Position JOIN Employee ON Position.position_id = Employee.position_id
				JOIN Account ON Employee.employee_id = Account.employee_id
	WHERE Account.username LIKE @username

	-- Phân quyền
	IF (@roleID = 1)	-- Giám đốc
	BEGIN
		EXEC master ..sp_addsrvrolemember @username, N'sysadmin'
	END
	ELSE IF (@roleID = 2) -- quản lý
	BEGIN
		EXEC sp_addrolemember 'db_Manager' , @username
	END
	ELSE IF (@roleID = 3) -- thu ngân
	BEGIN
		EXEC sp_addrolemember 'db_Cashier ' , @username
	END
	ELSE IF (@roleID = 4)	-- Thủ kho
	BEGIN
		EXEC sp_addrolemember 'db_WarehouseKeeper' , @username
	END
END
GO

-- Xóa tài khoản
CREATE PROC [dbo].[proc_Account_Delete]
   @username VARCHAR(100)
AS
   DELETE FROM Account
   WHERE username = @username
GO

-- Chỉnh sửa tài khoản
CREATE PROC [dbo].[proc_Account_Update]
	@username VARCHAR(100),
	@password VARCHAR(100)
AS
	UPDATE Account SET password = @password
	WHERE username = @username
GO

--
CREATE FUNCTION [dbo].[func_Account_GetAll]()
RETURNS TABLE
AS
	RETURN (
		SELECT username, password, A.employee_id, E.name employee_name
		FROM Account A, Employee E
		WHERE A.employee_id = E.employee_id
	)
GO

--
CREATE FUNCTION [dbo].[func_Account_GetAccount](@username VARCHAR(100))
RETURNS TABLE
AS
	RETURN (
		SELECT username, password, A.employee_id, E.name 'name', P.name 'position_name'
		FROM Account A, Employee E, Position P
		WHERE 
			username = @username AND 
			A.employee_id = E.employee_id AND
			P.position_id = E.position_id
	)
GO
----------------------------- Khách hàng -----------------------------
-- Thêm khách hàng
CREATE PROC [dbo].[proc_Customer_Add]
	@customer_phone VARCHAR(10),
	@name NVARCHAR(100),
	@birthday DATE,
	@gender NVARCHAR(3)
AS
    INSERT INTO Customer (customer_phone, name, birthday, gender, point)
    VALUES (@customer_phone, @name, @birthday, @gender, 0)
GO

-- Xóa khách hàng
CREATE PROC [dbo].[proc_Customer_Delete]
	@customer_phone VARCHAR(10)
AS
    DELETE FROM Customer
    WHERE customer_phone = @customer_phone
GO

-- Chỉnh sửa khách hàng
CREATE PROC [dbo].[proc_Customer_Update]
	@customer_phone VARCHAR(10),
	@name NVARCHAR(100),
	@birthday DATE,
	@gender NVARCHAR(3),
	@point INT
AS
	UPDATE Customer SET name = @name, birthday = @birthday, gender = @gender, point = @point
	WHERE customer_phone = @customer_phone
GO

--
CREATE FUNCTION [dbo].[func_Customer_GetAll]()
RETURNS TABLE 
AS
	RETURN (
		SELECT * 
		FROM Customer
	)
GO

-- Tìm khách hàng
CREATE FUNCTION [dbo].[func_Customer_FindByPhone](@phone VARCHAR(10))
RETURNS TABLE
AS
	RETURN (
		SELECT * 
		FROM [dbo].[func_Customer_GetAll]()
		WHERE customer_phone = @phone
	)
GO

----------------------------- Kho hàng -----------------------------
-- Thêm kho hàng
CREATE PROC [dbo].[proc_Warehouse_Add]
	@name NVARCHAR(100), 
	@address NVARCHAR(100)
AS
    INSERT INTO Warehouse (name, address)
    VALUES (@name, @address)
GO

-- Xóa kho hàng
CREATE PROC [dbo].[proc_Warehouse_Delete] 
	@warehouse_id INT
AS
    DELETE FROM Warehouse 
    WHERE warehouse_id = @warehouse_id
GO

-- Chỉnh sửa kho hàng
CREATE PROC [dbo].[proc_Warehouse_Update]
	@warehouse_id INT,
	@name NVARCHAR(100),
	@address NVARCHAR(100)
AS
    UPDATE Warehouse SET name = @name, address = @address 
    WHERE warehouse_id = @warehouse_id
GO

--
CREATE FUNCTION [dbo].[func_Warehouse_GetAll]()
RETURNS TABLE
AS 
	RETURN (
		SELECT * 
		FROM Warehouse
	)
GO

----------------------------- Danh mục hàng -----------------------------
-- Thêm danh mục hàng
CREATE PROC [dbo].[proc_Category_Add]
	@name NVARCHAR(100)
AS
	INSERT INTO Category (name)	
	VALUES (@name)
GO

-- Xóa danh mục hàng
CREATE PROC [dbo].[proc_Category_Delete]
   @category_id INT
AS
   DELETE FROM Category
   WHERE category_id = @category_id
GO

-- Chỉnh sửa danh mục hàng
CREATE PROC [dbo].[proc_Category_Update]
	@category_id INT,
	@name NVARCHAR(100)
AS
	UPDATE Category SET name = @name
	WHERE category_id = @category_id
GO

--
CREATE FUNCTION [dbo].[func_Category_GetAll]()
RETURNS TABLE
AS
   RETURN (
      SELECT * 
	  FROM Category
   )
GO

----------------------------- Hàng hóa -----------------------------
-- Thêm hàng hóa
CREATE PROC [dbo].[proc_Product_Add]  
	@name NVARCHAR(100), 
	@quantity INT, 
	@price INT, 
	@mfg_date DATE,  
	@exp_date DATE,  
	@category_id INT,
	@warehouse_id INT
AS
    INSERT INTO Product (name, quantity, price, mfg_date, exp_date, available, category_id, warehouse_id)
    VALUES (@name, @quantity, @price, @mfg_date, @exp_date, 1, @category_id, @warehouse_id)
GO

-- Xóa hàng hóa
CREATE PROC [dbo].[proc_Product_Delete]
   @product_id INT
AS
   UPDATE Product SET available = 0
   WHERE product_id = @product_id
GO

-- Chỉnh sửa hàng hóa
CREATE PROC [dbo].[proc_Product_Update]  
	@product_id INT,
	@name NVARCHAR(100), 
	@quantity INT, 
	@price INT, 
	@mfg_date DATE,  
	@exp_date DATE,  
	@category_id INT,
	@warehouse_id INT
AS
	UPDATE Product
	SET 
		name = @name,
		quantity = @quantity,
		price = @price,
		mfg_date = @mfg_date,
		exp_date = @exp_date,
		category_id = @category_id,
		warehouse_id = @warehouse_id
	WHERE product_id = @product_id
GO

--
CREATE FUNCTION [dbo].[func_Product_GetAll]()
RETURNS TABLE
AS 
	RETURN (
		SELECT 
			P.product_id, 
			P.name, 
			quantity, 
			price, 
			mfg_date, 
			exp_date, 
			P.category_id, 
			C.name category_name, 
			P.warehouse_id, 
			W.name warehouse_name
		FROM Product P, Category C, Warehouse W
		WHERE P.category_id = C.category_id AND 
				P.warehouse_id = W.warehouse_id AND
				P.available = 1
	)
GO

-- Tìm hàng hóa
CREATE FUNCTION [dbo].[func_Product_FindByName] (@keyword NVARCHAR(100))
RETURNS TABLE
AS
	RETURN (
		SELECT * 
		FROM func_Product_GetAll()
		WHERE name LIKE '%'+ @keyword + '%'
	)
GO

----------------------------- Công ty -----------------------------
-- Thêm công ty
CREATE PROC [dbo].[proc_Company_Add]
	@name NVARCHAR(100),
	@address NVARCHAR(100),
	@phone VARCHAR(10)
AS
    INSERT INTO Company (name, address, phone)
    VALUES (@name, @address, @phone)
GO

-- Xóa công ty
CREATE PROC [dbo].[proc_Company_Delete]
	@company_id INT
AS
    DELETE FROM Company
    WHERE company_id = @company_id
GO

-- Chỉnh sửa công ty
CREATE PROC [dbo].[proc_Company_Update]
	@company_id INT,
	@name NVARCHAR(100),
	@address NVARCHAR(100),
	@phone VARCHAR(10)
AS
    UPDATE Company SET name = @name, address = @address, phone = @phone
    WHERE company_id = @company_id
GO

-- 
CREATE FUNCTION func_Company_GetAll()
RETURNS TABLE
AS
	RETURN (
		SELECT * 
		FROM Company
	)
GO

----------------------------- Cung cấp -----------------------------
-- Thêm cung cấp
CREATE PROC [dbo].[proc_Import_Add]
	@company_id INT,
	@product_id INT,
	@import_date DATETIME,
	@quanttiy INT,
	@price INT
AS	
	INSERT INTO Import (company_id, product_id, import_date, quantity, price, available) 
	VALUES (@company_id, @product_id, @import_date, @quanttiy, @price, 1)
GO

-- Xóa cung cấp
CREATE PROC [dbo].[proc_Import_Delete]
	@import_id INT
AS
	UPDATE Import SET available = 0
	WHERE import_id = @import_id
GO

--
CREATE FUNCTION [dbo].[func_Import_GetAll]()
RETURNS TABLE 
AS
	RETURN (
		SELECT 
			I.import_id,
			I.import_date, 
			I.product_id, 
			P.name product_name, 
			I.company_id, 
			C.name company_name, 
			I.quantity, 
			I.price
		FROM Import I, Product P, Company C
		WHERE I.product_id = P.product_id AND I.company_id = C.company_id AND I.available = 1
	)
GO

----------------------------- Hóa đơn -----------------------------
-- Thêm hóa đơn
CREATE PROC [dbo].[proc_Bill_Add]
	@employee_id INT,
	@customer_phone VARCHAR(10),
	@discount INT
AS
BEGIN
	DECLARE @phone VARCHAR(10)
	IF @customer_phone = ''
		SET @phone = NULL
	ELSE
		SET @phone = @customer_phone
    INSERT INTO Bill (employee_id, customer_phone, created, discount, total, available)
    VALUES (@employee_id, @phone, GETDATE(), @discount, -@discount, 1)
END
GO

-- Xóa hóa đơn
CREATE PROC [dbo].[proc_Bill_Delete]
	@bill_id INT
AS
	UPDATE Bill SET available = 0
	WHERE bill_id = @bill_id
GO

--
-- Làm tròn hóa đơn
CREATE PROC [dbo].[proc_Bill_RoundTotal]
	@bill_id INT
AS
BEGIN
	DECLARE @old_total INT,
			@new_total INT,
			@remainder INT

	SELECT @old_total = total FROM [dbo].[Bill] WHERE bill_id = @bill_id

	SET @remainder = @old_total % 1000
	IF @remainder >= 500
		SET @new_total = @old_total - @remainder + 1000
	ELSE
		SET @new_total = @old_total - @remainder

	UPDATE [dbo].[Bill] SET total = @new_total WHERE bill_id = @bill_id
END
GO

--
CREATE FUNCTION [dbo].[func_Bill_GetAll]()
RETURNS TABLE 
AS 
RETURN (
	SELECT * FROM Bill
)
GO

----------------------------- Hóa đơn chi tiết-----------------------------
-- Thêm hóa đơn chi tiết
CREATE PROC [dbo].[proc_BillInfo_Add]
	@bill_id INT,
	@product_id INT,
	@quantity INT,
	@price INT
	AS
		INSERT INTO BillInfo (bill_id, product_id, quantity, price)
		VALUES (@bill_id, @product_id, @quantity, @price)
GO

-- Tính tổng tiền của hóa đơn chi tiết
CREATE FUNCTION [dbo].[func_BillInfo_CalcTotal](@quantity INT, @price INT)
RETURNS INT
AS
BEGIN 
	DECLARE @total INT
	SET @total = @quantity * @price
	RETURN @total
END
GO

-- Tích điểm cho khách hàng khi mua hàng thành công
CREATE PROC [dbo].[proc_Customer_AccumulatePoints]
	@customer_phone VARCHAR(10) , 
	@bill_id INT
AS
BEGIN
	DECLARE @old_point INT,
		@plus_point INT
	SELECT @old_point = point FROM [dbo].[Customer] WHERE customer_phone = @customer_phone

	SELECT @plus_point = (total + discount) / 100 FROM [dbo].[Bill] WHERE bill_id = @bill_id

	UPDATE [dbo].[Customer] SET point = @old_point + @plus_point WHERE customer_phone = @customer_phone
END
GO

-- Lấy ra Hóa đơn mới nhất vừa được tạo
CREATE FUNCTION [dbo].[func_Bill_GetNewestBillId]()
RETURNS INT 
AS 
BEGIN
	DECLARE @max_id INT
	SELECT @max_id = MAX(bill_id) FROM Bill
	RETURN @max_id
END
GO




-- Thống kê doanh thu theo ngày
CREATE FUNCTION [dbo].[func_Statistic_Sale_ByDate] ( @Date int, @Month int, @Year int)
RETURNS Table
AS RETURN
	SELECT NGAY,THANG,NAM, Sum(Total) AS TotalByDate, count(bill_id) as TongSoDon
	FROM
		(SELECT *, MONTH(Bill.created) AS THANG,Year(Bill.created) AS NAM, DAY(Bill.created) AS NGAY FROM Bill 
		where MONTH(Bill.created)=@Month and DAY(Bill.created)=@Date and Year(Bill.created)=@Year) AS DATECOLUM
	GROUP BY NGAY,THANG,NAM
GO
--Hiển thị tất cả hóa đơn theo ngày
CREATE FUNCTION [dbo].[func_Bill_Find_ByDateMonthYear](@Date int, @Month int, @Year int)
RETURNS TABLE
AS RETURN
	SELECT B.bill_id, E.name, B.customer_phone, B.created, B.discount, B.total
	FROM Bill B JOIN Employee E ON	B.employee_id = E.employee_id
	WHERE MONTH(B.created)=@Month and DAY(B.created)=@Date and Year(B.created)=@Year
GO

CREATE FUNCTION [dbo].[func_Statistic_Sale_ByMonth]()
RETURNS Table
AS RETURN
	(SELECT Month,Year, Sum(Total) AS TotalByMonth
	FROM
	(SELECT *, MONTH(Bill.created) AS Month,Year(Bill.created) AS Year
	FROM Bill) AS MonthTable
	GROUP BY Month,Year)
GO

CREATE FUNCTION [dbo].[func_Statistic_Sale_ByYear]()
RETURNS TABLE
AS
RETURN(SELECT Year, Sum(total) AS TotalByYear
FROM
	(SELECT *, Year(Bill.created) AS Year FROM Bill) AS YearTable
	GROUP BY Year)
GO

-- Tìm Khách hàng chi tiêu nhiều nhất tháng
Create FUNCTION [dbo].[func_Customer_FindMaxSpending](@Month INT, @Year INT)
RETURNS TABLE
AS
	RETURN
		SELECT customer_phone, SUM(total) total
		FROM  Bill
		WHERE YEAR(Bill.created) = @Year AND MONTH(Bill.created) = @Month AND customer_phone IS NOT NULL
		GROUP BY customer_phone
		HAVING SUM(total) = (
			SELECT MAX(total) 
			FROM (
				SELECT customer_phone, SUM(total) total
				FROM Bill
				WHERE YEAR(Bill.created) = @Year AND MONTH(Bill.created) = @Month AND customer_phone IS NOT NULL
				GROUP BY customer_phone
			) AS Q
		)
GO


-- Thống kê số mặt hàng đã bán trong tháng	
CREATE FUNCTION [dbo].[func_Product_SoldByMonth] (@month INT, @year INT)
RETURNS TABLE
AS
	RETURN 
		SELECT P.product_id, P.name, SUM(BI.quantity) sold
		FROM Bill B JOIN BillInfo BI ON B.bill_id = BI.bill_id
		JOIN Product P ON P.product_id = BI.product_id
		WHERE MONTH(B.created) = @month AND YEAR(B.created) = @year
		GROUP BY P.product_id, P.name
GO

-- Tìm công ty cung cấp hàng nhiều nhất tháng/năm
CREATE FUNCTION [dbo].[func_Company_Find_TopSupply](@month INT, @year INT)
RETURNS TABLE
AS
RETURN
	SELECT  Company.company_id, Company.name, TotalImport = SUM(Import.quantity)
	FROM Company, Import 
	WHERE Company.company_id = Import.company_id AND MONTH(Import.import_date)= @month AND YEAR(Import.import_date) = @year
	GROUP BY Company.company_id, Company.name
	HAVING SUM(Import.quantity) = (
		SELECT MAX(TotalImport)
		FROM (	
			SELECT TotalImport = SUM(quantity)
			FROM Company, Import 
			WHERE Company.company_id = Import.company_id AND MONTH(Import.import_date) = @month AND YEAR(Import.import_date) = @year
			GROUP BY Company.company_id
		) AS Q
	)
GO

-- View Hóa Đơn
Create or alter View view_BILL_BILLINFO
AS
	SELECT dbo.Bill.bill_id, dbo.Bill.created AS Ngaytao, dbo.Employee.name AS TenNhanVien, dbo.Bill.customer_phone AS SDTKhachHang, dbo.Bill.discount AS GiamGia, dbo.Product.name AS TenSanPham, dbo.BillInfo.quantity AS SoLuong, dbo.BillInfo.price As DonGia
	FROM  dbo.Bill INNER JOIN
		dbo.BillInfo ON dbo.Bill.bill_id = dbo.BillInfo.bill_id INNER JOIN
		dbo.Product ON dbo.Product.product_id = dbo.BillInfo.product_id INNER JOIN
		dbo.Employee ON Employee.employee_id = Bill.employee_id
GO

-- 