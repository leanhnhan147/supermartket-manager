USE [SupermarketManagement]
GO

--6.a. Tự động cập nhật tổng hóa đơn và giảm số lượng hàng tương ứng trong kho khi thêm một chi tiết hóa đơn
CREATE TRIGGER tr_BillInfo_Add
ON BillInfo
AFTER INSERT
AS 
BEGIN
	DECLARE @bill_id INT, 
			@product_id INT, 
			@quantity INT, 
			@price INT, 
			@old_total INT, 
			@old_quantity INT

	-- Lấy thông tin từ billInfo vừa được insert vào database
	SELECT @bill_id = bill_id, 
		@product_id = product_id,
		@quantity = quantity, 
		@price = price 
	FROM inserted

	-- Lấy ra thông tin total cũ
	SELECT @old_total = total 
	FROM dbo.Bill WHERE bill_id = @bill_id

	-- Lấy ra số lượng hàng trong kho của sản phẩm vừa được thêm vào
	SELECT @old_quantity = quantity 
	FROM dbo.Product WHERE product_id = @product_id

	BEGIN TRANSACTION
	-- Cập nhật lại tổng giá trị của hóa đơn
	UPDATE Bill SET total = @old_total + (@quantity * @price) WHERE bill_id = @bill_id

	-- Giảm số sản phẩm trong kho tương ứng
	UPDATE Product SET quantity = @old_quantity - @quantity WHERE product_id = @product_id 
	COMMIT
END
GO

-- 6c. Tự động cập nhật điểm của khách hàng khi mua hàng thành công (nếu có trừ điểm tích lũy)
CREATE TRIGGER tr_Bill_Add
ON Bill
AFTER INSERT
AS
BEGIN
	DECLARE @bill_id INT,
		@discount INT,
		@customer_phone VARCHAR(10)
	
	-- Lấy ra id hóa đơn vừa được thêm vào
	SELECT @bill_id = bill_id, @discount = discount, @customer_phone = customer_phone FROM inserted

	-- Trừ điểm tích lũy cho khách hàng
	IF @customer_phone IS NOT NULL
		UPDATE [dbo].[Customer] SET point = point - @discount WHERE customer_phone = @customer_phone
END
GO

-- Tự động tăng số lượng sản phẩm khi nhập hàng mới 
CREATE TRIGGER tr_Import_Add
ON Import
AFTER INSERT
AS
BEGIN
	DECLARE @product_id INT,
			@quantity INT
	SELECT @product_id = product_id, @quantity = quantity FROM inserted

	UPDATE [dbo].[Product] 
	SET quantity = quantity + @quantity 
	WHERE product_id = @product_id
END
GO


-- Tự động giảm số lượng sản phẩm khi xóa nhập hàng
CREATE TRIGGER tr_Import_Delete
ON Import
AFTER UPDATE
AS
BEGIN
	DECLARE @product_id INT,
			@quantity INT
	SELECT @product_id = product_id, @quantity = quantity FROM deleted

	UPDATE [dbo].[Product] 
	SET quantity = quantity - @quantity 
	WHERE product_id = @product_id
END
GO