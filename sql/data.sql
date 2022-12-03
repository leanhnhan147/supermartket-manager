USE [SupermarketManagement]
GO

-- Vị trí
EXEC [dbo].[proc_Position_Add] N'Giám đốc', 100000000
EXEC [dbo].[proc_Position_Add] N'Quản lý', 10000000
EXEC [dbo].[proc_Position_Add] N'Thu ngân', 5000000
EXEC [dbo].[proc_Position_Add] N'Thủ kho', 5000000

-- Nhân viên
EXEC [dbo].[proc_Employee_Add] N'SuperAdmin', '123456789', 1
EXEC [dbo].[proc_Employee_Add] N'Manager', '0947502205', 2
EXEC [dbo].[proc_Employee_Add] N'Cashier', '0947502205', 3
EXEC [dbo].[proc_Employee_Add] N'WarehouseKeeper', '0947502205', 4

EXEC [dbo].[proc_Employee_Add] N'Huỳnh Tiến Dĩ', '20110246', 2
EXEC [dbo].[proc_Employee_Add] N'Lê Anh Nhân', '20110689', 2
EXEC [dbo].[proc_Employee_Add] N'Lê Anh Hùng', '20110145', 2
EXEC [dbo].[proc_Employee_Add] N'Trần Văn Quảng', '20110160', 2

-- Tài khoản
EXEC [dbo].[proc_Account_Add] 'giamdoc', 'giamdoc', 1
EXEC [dbo].[proc_Account_Add] 'quanly', 'quanly', 2 
EXEC [dbo].[proc_Account_Add] 'thungan', 'thungan', 3 
EXEC [dbo].[proc_Account_Add] 'thukho', 'thukho', 4 

-- Kho hàng
EXEC proc_Warehouse_Add N'Kho 1', N'Khu A - Tầng 1'
EXEC proc_Warehouse_Add N'Kho 2', N'Khu B - Tầng 1'
EXEC proc_Warehouse_Add N'Kho 3', N'Khu C - Tầng 1'
EXEC proc_Warehouse_Add N'Kho 4', N'Khu B - Tầng 2'
EXEC proc_Warehouse_Add N'Kho 5', N'Khu A - Tầng 2'
EXEC proc_Warehouse_Add N'Kho 6', N'Khu C - Tầng 2'

-- Danh mục hàng
EXEC proc_Category_Add N'Rau củ'
EXEC proc_Category_Add N'Trái cây'

EXEC proc_Category_Add N'Thịt'
EXEC proc_Category_Add N'Thủy hải sản'

EXEC proc_Category_Add N'Gia vị - Chế biến'
EXEC proc_Category_Add N'Đồ ăn vặt'

EXEC proc_Category_Add N'Thực phẩm đông lạnh'
EXEC proc_Category_Add N'Thực phẩm trữ mát'

EXEC proc_Category_Add N'Sữa - Các sản phẩm từ sữa'
EXEC proc_Category_Add N'Thức uống'

EXEC proc_Category_Add N'Sản phẩm cho bé'
EXEC proc_Category_Add N'Chăm sóc nhà cửa'

-- Hàng hóa
EXEC proc_Product_Add N'Cải ngọt bông', 100, 23000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Rau mồng tơi', 100, 32000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Cải thìa', 100, 32000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Su su quả', 100, 16000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Cải bó xôi', 100, 43000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Bắp cải tím organic', 100, 34000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Cải thảo Đà Lạt', 100, 42000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Bắp cải trắng', 100, 19000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Xà lách lô lô xanh', 100, 58000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Rau muống', 100, 34000, '2022-1-1', '2023-1-1', 1, 1

EXEC proc_Product_Add N'Ngò rí', 100, 86000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Khoai tây', 100, 25000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Khoai lang', 100, 28000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Mướp hương', 100, 48000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Cà chua đỏ', 100, 21000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Củ cải trắn', 100, 13000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Dưa leo', 100, 23000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Cà rốt', 100, 17000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Hành tây', 100, 17000, '2022-1-1', '2023-1-1', 1, 1
EXEC proc_Product_Add N'Măng tây xanh', 100, 160000, '2022-1-1', '2023-1-1', 1, 1

EXEC proc_Product_Add N'Thanh long ruột đỏ', 100, 18000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Đu đủ vàng', 100, 39000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Xoài cát', 100, 68000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Thanh long ruột trắng', 100, 18000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Chuối sứ', 100, 17000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Bưởi da xanh', 100, 85000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Dưa lưới', 100, 55000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Dưa hấu', 100, 35000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Dưa hấu không hạt', 100, 72000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Ổi Ruby', 100, 35000, '2022-1-1', '2023-1-1', 2, 1

EXEC proc_Product_Add N'Thơm', 100, 18000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Kiwi', 100, 220000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Cam', 100, 55000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Chanh dây', 100, 16000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Quýt', 100, 38000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Táo Dazzle New Zealand', 100, 82000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Bưởi năm roi', 100, 45000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Lê đường', 100, 39000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Mãng cầu na', 100, 38000, '2022-1-1', '2023-1-1', 2, 1
EXEC proc_Product_Add N'Lựu', 100, 30000, '2022-1-1', '2023-1-1', 2, 1

EXEC proc_Product_Add N'Ba chỉ bò', 100, 110000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Ba chỉ heo', 100, 132000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Sườn non heo', 100, 150000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Ba rọi rút sườn', 100, 125000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Sườn heo que', 100, 68000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Khoan giò heo', 100, 97000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Ba chỉ hun khói', 100, 81000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Nạc dăm heo', 100, 135000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Ba chỉ bò cuộn', 100, 120000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Ức gà Phile', 100, 120000, '2022-1-1', '2023-1-1', 3, 2

EXEC proc_Product_Add N'Đùi gà góc tư', 100, 70000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Chân gà rút xương', 100, 100000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Bò lúc lắc', 100, 50000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Ba rọi heo', 100, 65000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'Cánh gà', 100, 43000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'̀Bít tết đùi bò Úc', 100, 118000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'̀Vịt nguyên con', 100, 200000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'̀Mề gà tươi', 100, 50000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'̀Lòng gà', 100, 38000, '2022-1-1', '2023-1-1', 3, 2
EXEC proc_Product_Add N'̀Xương gà', 100, 31000, '2022-1-1', '2023-1-1', 3, 2

EXEC proc_Product_Add N'Sò điệp Nhật', 100, 200000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sò đỏ Nhất', 100, 140000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sò lông', 100, 220000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sò lụa', 100, 240000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sò huyết', 100, 270000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sò mai', 100, 300000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sashimi sò đỏ Canada', 100, 145000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Sashimi sò điệp Nhật', 100, 150000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Ốc Bulot Pháp', 100, 290000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Ốc vòi voi', 100, 450000, '2022-1-1', '2023-1-1', 4, 2

EXEC proc_Product_Add N'Tôm hùm Alaska', 100, 355000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Tôm thẻ rim', 100, 145000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Tôm thẻ sống', 100, 120000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Tôm sốt thái', 100, 230000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Tôm sú', 100, 350000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Tôm tít', 100, 550000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Tôm càng xanh', 100, 362000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Mực ống', 100, 350000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Bạch tuộc', 100, 350000, '2022-1-1', '2023-1-1', 4, 2
EXEC proc_Product_Add N'Bào ngư', 100, 200000, '2022-1-1', '2023-1-1', 4, 2

EXEC proc_Product_Add N'Gia vị Bún bò huế', 100, 16000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị thiệt nướng xá xíu', 100, 13000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị Ngũ Vị Barona', 100, 13000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị hủ tiếu nam vang Barona', 100, 15000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị nướng muối ớt Barona', 100, 13000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị nêm lâu kim chi', 100, 11000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị chiến nước nắm Barona', 100, 15000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị bò kho Barano', 100, 13000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị cá kho riềng Barona', 100, 12000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị thịt kho tầu Barona', 100, 12000, '2022-1-1', '2023-1-1', 5, 3

EXEC proc_Product_Add N'Gia vị canh chua Barona', 100, 13000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị xào sả ớt Barona', 100, 13000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị xào chưa ngọt', 100, 12000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Gia vị Rôti Barona', 100, 11000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Dầu ô liu', 100, 100000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Dầu cá hồi', 100, 43000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Dầu ăn cái lân', 100, 58000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Dầu Cooking Oil', 100, 85000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Dầu hương mè', 100, 65000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Dầu hào chay', 100, 20000, '2022-1-1', '2023-1-1', 5, 3

EXEC proc_Product_Add N'Dầu hào Cholimex', 100, 20000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Nước nắm chay Ông chà và', 100, 17000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Nước màu thốt nốt', 100, 12000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột tẩm khô', 100, 10000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột làm bánh Hot Cake', 100, 85000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột chiên giòn', 100, 9000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột dứa tự nhiên', 100, 110000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột làm bánh xèo', 100, 32000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột bào hoa ký', 100, 10000, '2022-1-1', '2023-1-1', 5, 3
EXEC proc_Product_Add N'Bột bánh cuốn', 100, 26000, '2022-1-1', '2023-1-1', 5, 3

EXEC proc_Product_Add N'Bánh quy Chocochip', 100, 79000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh quy lạt Soda Cracker', 100, 50000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh cốm bún gạo lá dứa', 100, 14000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh Yến Mạch Socola', 100, 45000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh gạo nướng An', 100, 18000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh gạo Nhật vị Shouyu mật ong', 100, 16000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh xốp Super Star Triple Choco', 100, 16000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh trứng tươi phô mai', 100, 35000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh Trứng Kem Sầu Riêng TiPo', 100, 40000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh trừng tươi Karo', 100, 36000, '2022-1-1', '2023-1-1', 6, 3

EXEC proc_Product_Add N'Bánh snack tôm cay Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack Tôm cay đặc biệt Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack pho mát miếng Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack bắp phô mai Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack bắp ngọt Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack phồng mực Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack hành Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack khoai tây Oishi', 100, 7000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị mực lăn muối ớt Poca', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị bò lúc lắc Poca', 100, 11000, '2022-1-1', '2023-1-1', 6, 3

EXEC proc_Product_Add N'Bánh snack vị mực cay đặc biệt Poca', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack bí đỏ Poca', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị gà quay Poca', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị tảo biển OStar', 100, 12000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị kim chi OStar', 100, 12000, '2022-1-1', '2023-1-1', 6, 3

EXEC proc_Product_Add N'Bánh snack vị phô mai Slide', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị tự nhiên Slide', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị gá nướng Slide', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị thịt nướng Slide', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị tảo biển Lays', 100, 11000, '2022-1-1', '2023-1-1', 6, 3

EXEC proc_Product_Add N'Bánh snack vị tự nhiên Lays', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị bò Wagpy Lays', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị sườn BBQ Lays', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị gà cay phô mai Lays', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị bò nướng Texas Lays', 100, 11000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị vịt quay Peke', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị cua xào ớt Peke', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị truyền thống Peke', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị rong biển Peke', 100, 28000, '2022-1-1', '2023-1-1', 6, 3
EXEC proc_Product_Add N'Bánh snack vị kem chua hành Peke', 100, 28000, '2022-1-1', '2023-1-1', 6, 3

EXEC proc_Product_Add N'Kem Hộp vani sốt socola Walls', 100, 110000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem Hộp chocolate chip Walls', 100, 75000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem Hộp chuối, việt quất Walls', 100, 75000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem Hộp vani sốt dâu Walls', 100, 75000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem sầu riêng Thái Walls', 100, 19000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem trà sữa trân châu Walls', 100, 16000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem đậu đen nước cốt dừa Walls', 100, 15000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem dừa non Walls', 100, 14000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem khai môn dẻo Walls', 100, 13000, '2022-1-10', '2023-1-10', 7, 4
EXEC proc_Product_Add N'Kem Topten Vanila Walls', 100, 12000, '2022-1-10', '2023-1-10', 7, 4

EXEC proc_Product_Add N'Kem hộp khoai môn Vitamilk', 100, 70000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp đậu xanh khoai môn dứa Vitamilk', 100, 70000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp trân châu đường đen Vitamilk', 100, 63000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp trân châu hoàng kim phô mai Vitamilk', 100, 63000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp dâu Vitamilk', 100, 48000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp dứa Vitamilk', 100, 48000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp cốm dứa Vitamilk', 100, 48000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp đậu xanh Vitamilk', 100, 48000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp khoai môn dứa Vitamilk', 100, 48000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Kem hộp sầu riêng Vitamilk', 100, 48000, '2022-1-15', '2023-1-15', 7, 4

EXEC proc_Product_Add N'Thịt ba rọi Mỹ đông lạnh', 100, 100000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Gấu bò Mỹ đông lạnh', 100, 120000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Thịt chóp vai bò Mỹ đông lạnh', 100, 250000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Thịt nướng đông lạnh', 100, 250000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Thịt xay nấm kim châm', 100, 250000, '2022-1-15', '2023-1-15', 7, 4

EXEC proc_Product_Add N'Nghêu lụa động lạnh Mama Food', 100, 37000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Cá hố cắt khúc đông lạnh Mama Food', 100, 27000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Cá bống đục đông lạnh Mama Food', 100, 27000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Cá saba tẩm rau đông lạnh Mama Food', 100, 59000, '2022-1-15', '2023-1-15', 7, 4
EXEC proc_Product_Add N'Cá saba tẩm sa tế đông lạnh Mama Food', 100, 59000, '2022-1-15', '2023-1-15', 7, 4

EXEC proc_Product_Add N'Bò viên Cầu tre', 100, 100000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò Real hải sản Cầu tre', 100, 75000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò da xốp nhân thịt Cầu tre', 100, 71000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò nhân thịt Cầu tre', 100, 71000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Phô mai da xốp nhân tôm mayonnaise Cầu tre', 100, 70000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Nem Real kiểu Hà Nội nhân Cầu tre', 100, 68000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò đặc biệt nhân thịt Cầu tre', 100, 68000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò da xốp Tôm và thịt Cầu Cầu tre', 100, 70000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò nhân thịt  Cầu tre', 100, 62000, '2022-2-1', '2023-2-1', 8, 4
EXEC proc_Product_Add N'Chả giò rế Hải sản Cầu tre', 100, 69000, '2022-2-1', '2023-2-1', 8, 4

EXEC proc_Product_Add N'Thùng 48 bịch sữa tươi có đường Vinamilk Happy Star 220ml', 100, 336000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 hộp sữa tươi nguyên chất không đường Vinamilk 100% Organic 180ml', 100, 500000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 hộp sữa tươi tiệt trùng ít đường Vinamilk Green Farm 180ml', 100, 378000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 hộp sữa tươi tiệt trùng có đường Vinamilk Green Farm 180ml', 100, 378000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 12 hộp sữa tươi có đường Vinamilk 1 lít', 100, 336000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 12 hộp sữa tươi không đường Vinamilk 1 lít', 100, 336000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 bịch sữa dinh dưỡng socola Vinamilk A&D3 220ml', 100, 325000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 bịch sữa dinh dưỡng ít đường Vinamilk 220ml', 100, 325000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 bịch sữa dinh dưỡng không đường Vinamilk A&D3 220ml', 100, 325000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thùng 48 hộp sữa dinh dưỡng có đường Vinamilk ADM 180ml', 100, 325000, '2022-2-10', '2023-2-10', 9, 5

EXEC proc_Product_Add N'Bột thức uống lúa mạch Milo Active Go hũ 400g', 100, 73000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Bột thức uống lúa mạch 3in1 Milo Active Go bịch 330g', 100, 54000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thức uống dinh dưỡng Ovaltine hũ 400g', 100, 66000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Bột thức uống lúa mạch vị chocolate Ovaltine hộp 285g', 100, 47000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Bột ca cao Nestlé Hot Choco Original hộp 240g', 100, 85000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Ngũ cốc dinh dưỡng nguyên cám NutiFood Diabet Care bịch 400g', 100, 58000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Ngũ cốc dinh dưỡng Yumfood gói 500g', 100, 62000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Thực phẩm bổ sung yến mạch gạo lứt Yumfood gói 210g', 100, 42000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Bột ca cao nguyên chất CacaoMi Original hộp 217g', 100, 66000, '2022-2-10', '2023-2-10', 9, 5
EXEC proc_Product_Add N'Bột ca cao nguyên chất CacaoMi Premium hộp 217g', 100, 70000, '2022-2-10', '2023-2-10', 9, 5

EXEC proc_Product_Add N'6 chai nước ngọt có ga Coca Cola Zero 390ml', 100, 32000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 chai nước ngọt có ga Coca Cola Zero 390ml', 100, 128000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Coca Cola Light 320ml', 100, 235000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Coca Cola 235ml', 100, 190000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 chai nước ngọt Coca Cola 300ml', 100, 120000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 chai nước ngọt Coca Cola nguyên bản chai 1.5 lít', 100, 115000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'12 chai nước ngọt có ga Coca Cola Zero 390ml', 100, 90000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 lon nước ngọt Coca Cola Light 320ml', 100, 60000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 lon nước ngọt Coca Cola Zero 320ml', 100, 60000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 lon nước ngọt Coca Cola 320ml', 100, 60000, '2022-2-20', '2023-2-20', 10, 5

EXEC proc_Product_Add N'6 lon nước ngọt Pepsi không calo vị chanh 320ml', 100, 45000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 lon nước ngọt Pepsi không calo 320ml', 100, 45000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Pepsi không calo 320ml', 100, 180000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Pepsi không calo vị chanh 320ml', 100, 180000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 chai nước ngọt Pepsi Cola 390ml', 100, 36000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 chai nước ngọt Pepsi Cola 390ml', 100, 145000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Pepsi Cola 320ml', 100, 230000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Pepsi Cola Sleek 245ml', 100, 190000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 chai nước ngọt Pepsi không calo 390ml', 100, 160000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 lon nước ngọt Pepsi Cola 320ml', 100, 60000, '2022-2-20', '2023-2-20', 10, 5

EXEC proc_Product_Add N'Thùng 12 chai nước ngọt Mirinda hương xá xị 1.5 lít', 100, 180000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 12 chai nước ngọt Mirinda hương cam 1.5 lít', 100, 180000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 chai nước ngọt Mirinda hương xá xị 390ml', 100, 36000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 chai nước ngọt có ga Mirinda vị soda kem việt quất chai 390m', 100, 36000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'6 chai nước ngọt Mirinda hương cam 390ml', 100, 36000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Nước ngọt Mirinda vị soda kem chai 1.5 lít', 100, 16000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 chai nước ngọt Mirinda hương cam 390ml', 100, 145000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'Thùng 24 lon nước ngọt Mirinda vị soda kem 320ml', 100, 230000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'12 chai nước ngọt Mirinda hương cam 390ml', 100, 90000, '2022-2-20', '2023-2-20', 10, 5
EXEC proc_Product_Add N'12 chai nước ngọt Mirinda hương xá xị 390ml', 100, 90000, '2022-2-20', '2023-2-20', 10, 5

EXEC proc_Product_Add N'Tã quần Bobby Extra Soft Dry size XL 50 miếng (cho bé 12 - 17kg)', 100, 296000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby Extra Soft Dry size M 60 miếng (cho bé 6 - 11kg)', 100, 282000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby Extra Soft Dry size S 70 miếng (cho bé 4 - 8kg)', 100, 282000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby Extra Soft Dry size L 56 miếng (cho bé 9 - 13kg)', 100, 282000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby Extra Soft Dry size XXL 46 miếng (cho bé trên 16kg)', 100, 282000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby size L 52 miếng (cho bé 9 - 13kg)', 100, 266000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby size M 60 miếng (cho bé 6 - 11kg)', 100, 266000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby size XXL 44 miếng (cho bé 15 - 25kg)', 100, 266000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby size XL 48 miếng (cho bé 12 - 17kg)', 100, 266000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Tã quần Bobby size L 38 miếng (cho bé 9 - 13kg)', 100, 198000, '2022-1-1', '2023-1-1', 11, 6

EXEC proc_Product_Add N'Ly mag mag có ống hút Pigeon màu xanh 200ml', 100, 125000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Bộ bát đĩa tập ăn Pigeon Mini', 100, 78000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Dụng cụ hứng sữa mẹ Pigeon 110ml', 100, 122000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Ly mag mag núm vú Pigeon 180ml', 100, 82000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Miếng đệm phễu hút sữa silicone Pigeon vừa', 100, 71000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Miếng đệm phễu hút sữa silicone Pigeon lớn', 100, 71000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Cây súc rửa núm vú Pigeon', 100, 48000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Bình tập ăn Pigeon 240ml', 100, 38000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Bình tập ăn Pigeon 120ml', 100, 36000, '2022-1-1', '2023-1-1', 11, 6
EXEC proc_Product_Add N'Kim băng Pigeon nhỏ 9 cái (giao màu ngẫu nhiên)', 100, 26000, '2022-1-1', '2023-1-1', 11, 6

EXEC proc_Product_Add N'Nồi inox 304 Elmich Tri-Max 2353733 20c', 100, 370000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Bộ 3 nồi inox 430 3 đáy Duxton DG3868-3DK 16/20/24cm', 100, 360000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Nồi nhôm Kim Hằng Bạch Đằng KHG9217 26cm', 100, 360000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Nồi inox đáy liền Elmich Trimax 18cm', 100, 350000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Nồi inox 304 nắp kính Elmich Tri-Max 2353731 16cm', 100, 320000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Chảo chống dính đáy từ HappyCall Titanium 26cm', 100, 320000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Chảo nhôm chống dính Sunhouse Calistar SBDS-30 30cm', 100, 219000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Chảo chống dính HappyCall Solar Diamond 26cm', 100, 300000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Chảo chống dính đáy từ HappyCall Titanium 24cm', 100, 300000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Chảo bầu quantum chống dính Kim Hằng 36cm', 100, 290000, '2022-1-1', '2023-1-1', 12, 6

EXEC proc_Product_Add N'Ly cao thuỷ tinh Luminarc Fillon 240ml', 100, 9000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Bộ bình ly thuỷ tinh Luminarc ARC Blue 5ps 350ml', 100, 143000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Bộ bình ly thuỷ tinh Luminarc Rotterdam Blue 5pcs 350ml', 100, 133000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Bộ bình ly thuỷ tinh Luminarc Rotterdam Pink 5pcs 350ml', 100, 133000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Ly rượu vang thuỷ tinh Luminarc Mineral 270ml', 100, 40000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Ly rượu vang thuỷ tinh Luminarc Elegance 140ml', 100, 23000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Ly champagne thuỷ tinh Luminarc Elegance 170ml', 100, 25000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Ly rượu thuỷ tinh Luminarc Cognac 130ml', 100, 23000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Ly rượu thuỷ tinh Luminarc Fine Champagne 15ml', 100, 20000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Ly bia thuỷ tinh Luminarc Brasserie 285ml', 100, 17000, '2022-1-1', '2023-1-1', 12, 6

EXEC proc_Product_Add N'Dao gọt inox có nắp đậy Konbini 20cm', 100, 66000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Bàn nạo rau củ kèm bát đựng nhựa Konbini 14.8cm', 100, 25000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao gọt thép không gỉ gắp gọn Konbini 18cm', 100, 23000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao bào thép không gỉ lưỡi xoay Konbini 12.5cm', 100, 21000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao gọt rau quả inox có nắp đậy Konbini (giao màu ngẫu nhiên) 21cm', 100, 25000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao cắt rau củ thép không gỉ cán gỗ Hiệp Phát 2 18cm', 100, 33000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao bào sợi thép không gỉ Hiệp Phát 12.5cm', 100, 18000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao bào đa năng 3 in 1 thép không gỉ Hiệp Phát 15.5cm', 100, 26000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Kéo cắt vải Hiệp Phát NK95 24.5cm', 100, 33000, '2022-1-1', '2023-1-1', 12, 6
EXEC proc_Product_Add N'Dao răng cưa thép không gỉ Hiệp Phát 20.8cm', 100, 7000, '2022-1-1', '2023-1-1', 12, 6

-- Công ty
EXEC proc_Company_Add N'Công ty rau sạch Organic Food', N'Số 93 Trần Não, Phường Bình An, Quận 2, TP. HCM', '0931771088'

EXEC proc_Company_Add N'Công ty TNHH TM nông sản thực phẩm Đồng Xanh', N'34/23 Hoàng Ngọc Phách, P. Phú Thọ Hoà, Q.Tân Phú, TP.HCM', '0936685268'

EXEC proc_Company_Add N'Công Ty TNHH TM XD Lê Hoàn Vũ', N'14/291 Lê Đức Thọ, Phường 15, Quận Gò Vấp, Tp. Hồ Chí Minh', '0765663878'

EXEC proc_Company_Add N'Công Ty SJ Foodro', N'37 Hoàn Diệu, P. 12, Q. 4, Tp. Hồ Chí Minh', '0962616667'
EXEC proc_Company_Add N'Công ty TNHH Apex Exim', N'Đường 20, Him Lam, Tân Hưng, Quận 7, Tp. Hồ Chí Minh', '0862624022'

EXEC proc_Company_Add N'Công Ty TNHH San Hà', N'Số 951 Tạ Quang Bửu, P. 6, Q. 8,Tp. Hồ Chí Minh', '0939810082'

EXEC proc_Company_Add N'Công Ty CP Zin Food Việt Nam', N'200/1, Phường 13, Q. Bình Thạnh, TP. HCM', '0866585358'

EXEC proc_Company_Add N'Công ty TNHH dịch vụ xuất nhập khẩu Thái Dương', N'229/38 Bùi Đình Túy, phường 24, Bình Thạnh, Tp.HCM', '0936933949'

EXEC proc_Company_Add N'Thực Phẩm Gia Anh - Gia Anh Foods', N'36 Đường Số 3, Khu Dân Cư Ấp 5, Xã Phong Phú, Huyện Bình Chánh, Tp. Hồ Chí Minh', '0903188933'
EXEC proc_Company_Add N'Công Ty TNHH Đầu Tư Và Xuất Nhập Khẩu Đại Thành', N'25/4 Đường Số 8, Phường Linh Xuân, Tp. Thủ Đức, Tp. Hồ Chí Minh', '0941096609'

EXEC proc_Company_Add N'Công Ty TNHH NAM PHƯƠNG', N'Phú Trung, xã Tân Phú Trung,TP Hồ Chí Minh', '1900558856'

EXEC proc_Company_Add N'Công ty TNHH Cooking Studio', N'32 Song Hành, An Phú, TP Thủ Đức - TP. Hồ Chí Minh', '0313333705'

EXEC proc_Company_Add N'CÔNG TY TNHH XUẤT NHẬP KHẨU BỐN MÙA VIỆT NAM', N'68 Nguyễn Cơ Thạch, Phường Cầu Diễn, Quận Nam Từ Liêm, Hà Nội', '0243207636'

EXEC proc_Company_Add N'Công Ty TNHH Choco', N'106 Đường TA10, P. Thới An, Q. 12,Tp. Hồ Chí Minh', '0938528965'

EXEC proc_Company_Add N'Công Ty Tnhh Oishi Việt Nam', N'Số 14, đường số 5, KCN Việt Nam', '0949868349'

EXEC proc_Company_Add N'CÔNG TY TNHH THƯƠNG MẠI POCA', N'D25, KDC Việt Sing, KP4, Phường An Phú, Thành phố Thuận An, Tỉnh Bình Dương', '0966845636'

EXEC proc_Company_Add N'CÔNG TY TNHH THƯƠNG MẠI PepsiCo ', N'67/16 Bình Hưng Hòa B, Q. Bình Tân, Tp. Hồ Chí Minh', '0899339611'

EXEC proc_Company_Add N'CÔNG TY TNHH Walls Vietnam', N'595 Điện Biên Phủ, P. 25, Q, Bình Thạnh, Tp. Hồ Chí Minh', '0763552333'

EXEC proc_Company_Add N'Công ty Cổ phần Sữa Vinamilk Việt Nam', N'6 Đồng Khởi, P. Bến Nghé, Q. 1, Tp. Hồ Chí Minh', '0238291924'

EXEC proc_Company_Add N'CÔNG TY TNHH THẢO TIẾN', N'165/24 Phan Văn Hớn, P. Tân Thới Nhất, Q. 12, Tp. HCM', '0937063521'

EXEC proc_Company_Add N'CÔNG TY TNHH THƯƠNG MẠI SẢN XUẤT TÂN PHÚ NHUẬN', N'133 Nguyễn Hồng Đào, p.14, Q. Tân Bình, TP.HCM', '0937824899'

EXEC proc_Company_Add N'Công ty Cổ phần Thực phẩm CJ Cầu Tree', N'125/208 Lương Thế Vinh, P.Tân Thới Hòa, Q.Tân Phú, TP.Hồ Chí Minh', '0237507211'

EXEC proc_Company_Add N'Công ty TNHH Nestlé Việt Nam', N'51/14 Đường Hòa Bình, P. Tân Thới Hòa, Q. Tân Phú, Tp. Hồ Chí Minh', '0237608215'

EXEC proc_Company_Add N'CÔNG TY TNHH NƯỚC GIẢI KHÁT COCA COLA VIỆT NAM', N'485 Xa lộ Hà Nội - Phường Linh Trung - Quận Thủ Đức - TP. Hồ Chí Minh', '0237652061'

EXEC proc_Company_Add N'CÔNG TY TNHH NƯỚC GIẢI KHÁT PEPSI VIỆT NAM', N' 205, Biệt thự E, Số 3 Thành Công, Quận Ba Đình, TP. Hà Nội', '0237966545'

EXEC proc_Company_Add N'CÔNG TY TNHH NƯỚC GIẢI KHÁT MIRINDA VIỆT NAM', N'18, Đường Số 5, Khu Dân Cư Kim Sơn, Phường Tân Phong, Quận 7, Tp. Hồ Chí Minh', '0981718080'

EXEC proc_Company_Add N'CÔNG TY TNHH BOBBY VIỆT NAM', N'18, Đường Số 5, Khu Dân Cư Kim Sơn, Phường Tân Phong, Quận 7, Tp. Hồ Chí Minh', '0981718080'

EXEC proc_Company_Add N'CÔNG TY TNHH PIGEON VIỆT NAM', N'43 Lê Thị Hồng, P. 17, Q. Gò Vấp, Tp. Hồ Chí Minh', '0933236266'

EXEC proc_Company_Add N'CÔNG TY TNHH HAPPY CALL CENTER', N'25/31 Võ Văn Hát, Phường Long Trường, Thành phố Thủ Đức, Thành phố Hồ Chí Minh', '0937922959'

EXEC proc_Company_Add N'CÔNG TY TNHH LUMINARC VIỆT NAM', N'178 Đường Số 9, Phường 16, Quận Gò Vấp, Tp. Hồ Chí Minh', '0938209339'

EXEC proc_Company_Add N'CÔNG TY TNHH KONBINI VIỆT NAM', N'1A Hồng Hà, P. 2, Q. Tân Bình, Tp. Hồ Chí Minh', '0907956597'



-- Cung cấp
EXEC proc_Import_Add 1, 1, '2022-1-10', 100, 20000 
EXEC proc_Import_Add 1, 2, '2022-1-10', 100, 30000
EXEC proc_Import_Add 1, 3, '2022-1-11', 100, 30000 
EXEC proc_Import_Add 1, 4, '2022-1-11', 100, 15000
EXEC proc_Import_Add 1, 5, '2022-1-12', 100, 40000 
EXEC proc_Import_Add 1, 6, '2022-1-12', 100, 30000
EXEC proc_Import_Add 1, 7, '2022-1-13', 100, 40000 
EXEC proc_Import_Add 1, 8, '2022-1-13', 100, 15000
EXEC proc_Import_Add 1, 9, '2022-1-14', 100, 55000 
EXEC proc_Import_Add 1, 10, '2022-1-14', 100, 30000

EXEC proc_Import_Add 2, 11, '2022-1-15', 100, 85000 
EXEC proc_Import_Add 2, 12, '2022-1-15', 100, 22000
EXEC proc_Import_Add 2, 13, '2022-1-16', 100, 25000 
EXEC proc_Import_Add 2, 14, '2022-1-16', 100, 45000
EXEC proc_Import_Add 2, 15, '2022-1-17', 100, 20000 
EXEC proc_Import_Add 2, 16, '2022-1-17', 100, 11000
EXEC proc_Import_Add 2, 17, '2022-1-18', 100, 20000 
EXEC proc_Import_Add 2, 18, '2022-1-18', 100, 15000
EXEC proc_Import_Add 2, 19, '2022-1-19', 100, 15000 
EXEC proc_Import_Add 2, 20, '2022-1-19', 100, 150000

EXEC proc_Import_Add 3, 21, '2022-1-20', 100, 15000 
EXEC proc_Import_Add 3, 22, '2022-1-20', 100, 35000
EXEC proc_Import_Add 3, 23, '2022-1-21', 100, 65000 
EXEC proc_Import_Add 3, 24, '2022-1-21', 100, 16000
EXEC proc_Import_Add 3, 25, '2022-1-22', 100, 15000 
EXEC proc_Import_Add 3, 26, '2022-1-22', 100, 80000
EXEC proc_Import_Add 3, 27, '2022-1-23', 100, 52000 
EXEC proc_Import_Add 3, 28, '2022-1-23', 100, 30000
EXEC proc_Import_Add 3, 29, '2022-1-24', 100, 70000 
EXEC proc_Import_Add 3, 30, '2022-1-25', 100, 32000

EXEC proc_Import_Add 4, 31, '2022-1-26', 100, 15000
EXEC proc_Import_Add 5, 32, '2022-1-26', 100, 210000
EXEC proc_Import_Add 4, 33, '2022-1-27', 100, 52000 
EXEC proc_Import_Add 5, 34, '2022-1-27', 100, 15000
EXEC proc_Import_Add 4, 35, '2022-1-28', 100, 35000 
EXEC proc_Import_Add 5, 36, '2022-1-28', 100, 80000
EXEC proc_Import_Add 4, 37, '2022-1-29', 100, 42000 
EXEC proc_Import_Add 5, 38, '2022-1-29', 100, 35000
EXEC proc_Import_Add 4, 39, '2022-1-30', 100, 35000 
EXEC proc_Import_Add 5, 40, '2022-1-30', 100, 25000

EXEC proc_Import_Add 6, 41, '2022-2-1', 100, 100000 
EXEC proc_Import_Add 6, 42, '2022-2-1', 100, 130000
EXEC proc_Import_Add 6, 43, '2022-2-2', 100, 145000 
EXEC proc_Import_Add 6, 44, '2022-2-2', 100, 120000
EXEC proc_Import_Add 6, 45, '2022-2-3', 100, 66000 
EXEC proc_Import_Add 6, 46, '2022-2-3', 100, 95000
EXEC proc_Import_Add 6, 47, '2022-2-4', 100, 80000 
EXEC proc_Import_Add 6, 48, '2022-2-4', 100, 130000
EXEC proc_Import_Add 6, 49, '2022-2-5', 100, 110000 
EXEC proc_Import_Add 6, 50, '2022-2-5', 100, 112000

EXEC proc_Import_Add 7, 51, '2022-2-6', 100, 65000 
EXEC proc_Import_Add 7, 52, '2022-2-6', 100, 95000
EXEC proc_Import_Add 7, 53, '2022-2-7', 100, 47000 
EXEC proc_Import_Add 7, 54, '2022-2-7', 100, 62000
EXEC proc_Import_Add 7, 55, '2022-2-8', 100, 40000 
EXEC proc_Import_Add 7, 56, '2022-2-8', 100, 100000
EXEC proc_Import_Add 7, 57, '2022-2-9', 100, 180000 
EXEC proc_Import_Add 7, 58, '2022-2-9', 100, 45000
EXEC proc_Import_Add 7, 59, '2022-2-10', 100, 35000 
EXEC proc_Import_Add 7, 60, '2022-2-10', 100, 30000

EXEC proc_Import_Add 8, 61, '2022-2-11', 100, 190000 
EXEC proc_Import_Add 8, 62, '2022-2-11', 100, 125000
EXEC proc_Import_Add 8, 63, '2022-2-12', 100, 200000 
EXEC proc_Import_Add 8, 64, '2022-2-12', 100, 225000
EXEC proc_Import_Add 8, 65, '2022-2-13', 100, 260000 
EXEC proc_Import_Add 8, 66, '2022-2-13', 100, 285000
EXEC proc_Import_Add 8, 67, '2022-2-14', 100, 130000 
EXEC proc_Import_Add 8, 68, '2022-2-14', 100, 135000
EXEC proc_Import_Add 8, 69, '2022-2-15', 100, 275000 
EXEC proc_Import_Add 8, 70, '2022-2-15', 100, 430000

EXEC proc_Import_Add 9, 71, '2022-2-16', 100, 350000 
EXEC proc_Import_Add 10, 72, '2022-2-16', 100, 140000
EXEC proc_Import_Add 9, 73, '2022-2-17', 100, 110000 
EXEC proc_Import_Add 10, 74, '2022-2-17', 100, 220000
EXEC proc_Import_Add 9, 75, '2022-2-18', 100, 340000 
EXEC proc_Import_Add 10, 76, '2022-2-18', 100, 520000
EXEC proc_Import_Add 9, 77, '2022-2-19', 100, 350000 
EXEC proc_Import_Add 10, 78, '2022-2-19', 100, 320000
EXEC proc_Import_Add 9, 79, '2022-2-20', 100, 330000 
EXEC proc_Import_Add 10, 80, '2022-2-20', 100, 185000

EXEC proc_Import_Add 11, 81, '2022-2-21', 100, 15000
EXEC proc_Import_Add 11, 82, '2022-2-21', 100, 12000 
EXEC proc_Import_Add 11, 83, '2022-2-22', 100, 12000
EXEC proc_Import_Add 11, 84, '2022-2-22', 100, 14000 
EXEC proc_Import_Add 11, 85, '2022-2-23', 100, 12000
EXEC proc_Import_Add 11, 86, '2022-2-23', 100, 19000 
EXEC proc_Import_Add 11, 87, '2022-2-24', 100, 12000
EXEC proc_Import_Add 11, 88, '2022-2-24', 100, 10000 
EXEC proc_Import_Add 11, 89, '2022-2-25', 100, 11000
EXEC proc_Import_Add 11, 90, '2022-2-25', 100, 11000

EXEC proc_Import_Add 11, 91, '2022-3-1', 100, 11000 
EXEC proc_Import_Add 11, 92, '2022-3-1', 100, 11000
EXEC proc_Import_Add 11, 93, '2022-3-2', 100, 10000 
EXEC proc_Import_Add 11, 94, '2022-3-2', 100, 10000
EXEC proc_Import_Add 12, 95, '2022-3-3', 100, 90000 
EXEC proc_Import_Add 12, 96, '2022-3-3', 100, 40000
EXEC proc_Import_Add 12, 97, '2022-3-4', 100, 55000 
EXEC proc_Import_Add 12, 98, '2022-3-4', 100, 80000
EXEC proc_Import_Add 12, 99, '2022-3-5', 100, 60000 
EXEC proc_Import_Add 12, 100, '2022-3-5', 100, 15000

EXEC proc_Import_Add 13, 101, '2022-3-6', 100, 18000 
EXEC proc_Import_Add 13, 102, '2022-3-6', 100, 15000
EXEC proc_Import_Add 13, 103, '2022-3-7', 100, 10000 
EXEC proc_Import_Add 13, 104, '2022-3-7', 100, 9000
EXEC proc_Import_Add 13, 105, '2022-3-8', 100, 80000 
EXEC proc_Import_Add 13, 106, '2022-3-8', 100, 6000
EXEC proc_Import_Add 13, 107, '2022-3-9', 100, 100000 
EXEC proc_Import_Add 13, 108, '2022-3-9', 100, 30000
EXEC proc_Import_Add 13, 109, '2022-3-10', 100, 8000 
EXEC proc_Import_Add 13, 110, '2022-3-10', 100, 25000

EXEC proc_Import_Add 14, 111, '2022-3-11', 100, 75000 
EXEC proc_Import_Add 14, 112, '2022-3-11', 100, 45000
EXEC proc_Import_Add 14, 113, '2022-3-12', 100, 10000 
EXEC proc_Import_Add 14, 114, '2022-3-12', 100, 44000
EXEC proc_Import_Add 14, 115, '2022-3-13', 100, 15000 
EXEC proc_Import_Add 14, 116, '2022-3-13', 100, 15000
EXEC proc_Import_Add 14, 117, '2022-3-14', 100, 15000 
EXEC proc_Import_Add 14, 118, '2022-3-14', 100, 33000
EXEC proc_Import_Add 14, 119, '2022-3-15', 100, 35000 
EXEC proc_Import_Add 14, 120, '2022-3-15', 100, 35000

EXEC proc_Import_Add 15, 121, '2022-3-16', 100, 6000 
EXEC proc_Import_Add 15, 122, '2022-3-16', 100, 6000
EXEC proc_Import_Add 15, 123, '2022-3-17', 100, 6000 
EXEC proc_Import_Add 15, 124, '2022-3-17', 100, 6000
EXEC proc_Import_Add 15, 125, '2022-3-18', 100, 6000 
EXEC proc_Import_Add 15, 126, '2022-3-18', 100, 6000
EXEC proc_Import_Add 15, 127, '2022-3-19', 100, 6000 
EXEC proc_Import_Add 15, 128, '2022-3-19', 100, 6000
EXEC proc_Import_Add 16, 129, '2022-3-20', 100, 10000 
EXEC proc_Import_Add 16, 130, '2022-3-20', 100, 10000

EXEC proc_Import_Add 16, 131, '2022-3-21', 100, 10000 
EXEC proc_Import_Add 16, 132, '2022-3-21', 100, 10000
EXEC proc_Import_Add 16, 133, '2022-3-22', 100, 10000 
EXEC proc_Import_Add 16, 134, '2022-3-22', 100, 11000
EXEC proc_Import_Add 16, 135, '2022-3-23', 100, 11000 
EXEC proc_Import_Add 17, 136, '2022-3-23', 100, 25000
EXEC proc_Import_Add 17, 137, '2022-3-24', 100, 25000
EXEC proc_Import_Add 17, 138, '2022-3-24', 100, 25000
EXEC proc_Import_Add 17, 139, '2022-3-25', 100, 25000
EXEC proc_Import_Add 17, 140, '2022-3-25', 100, 10000

EXEC proc_Import_Add 17, 141, '2022-3-26', 100, 10000 
EXEC proc_Import_Add 17, 142, '2022-3-26', 100, 10000
EXEC proc_Import_Add 17, 143, '2022-3-27', 100, 10000 
EXEC proc_Import_Add 17, 144, '2022-3-27', 100, 10000
EXEC proc_Import_Add 17, 145, '2022-3-28', 100, 10000 
EXEC proc_Import_Add 17, 146, '2022-3-28', 100, 25000
EXEC proc_Import_Add 17, 147, '2022-3-29', 100, 25000 
EXEC proc_Import_Add 17, 148, '2022-3-29', 100, 25000
EXEC proc_Import_Add 17, 149, '2022-3-30', 100, 25000 
EXEC proc_Import_Add 17, 150, '2022-3-30', 100, 25000

EXEC proc_Import_Add 18, 151, '2022-4-1', 100, 100000 
EXEC proc_Import_Add 18, 152, '2022-4-2', 100, 70000
EXEC proc_Import_Add 18, 153, '2022-4-3', 100, 70000 
EXEC proc_Import_Add 18, 154, '2022-4-4', 100, 70000
EXEC proc_Import_Add 18, 155, '2022-4-5', 100, 15000 
EXEC proc_Import_Add 18, 156, '2022-4-6', 100, 15000
EXEC proc_Import_Add 18, 157, '2022-4-7', 100, 15000 
EXEC proc_Import_Add 18, 158, '2022-4-8', 100, 12000
EXEC proc_Import_Add 18, 159, '2022-4-9', 100, 12000 
EXEC proc_Import_Add 18, 160, '2022-4-10', 100, 10000

EXEC proc_Import_Add 19, 161, '2022-4-11', 100, 65000 
EXEC proc_Import_Add 19, 162, '2022-4-11', 100, 65000
EXEC proc_Import_Add 19, 163, '2022-4-12', 100, 60000 
EXEC proc_Import_Add 19, 164, '2022-4-12', 100, 60000
EXEC proc_Import_Add 19, 165, '2022-4-13', 100, 45000 
EXEC proc_Import_Add 19, 166, '2022-4-13', 100, 45000
EXEC proc_Import_Add 19, 167, '2022-4-14', 100, 45000 
EXEC proc_Import_Add 19, 168, '2022-4-14', 100, 45000
EXEC proc_Import_Add 19, 169, '2022-4-15', 100, 45000 
EXEC proc_Import_Add 19, 170, '2022-4-15', 100, 45000

EXEC proc_Import_Add 20, 171, '2022-4-16', 100, 90000 
EXEC proc_Import_Add 20, 172, '2022-4-16', 100, 100000
EXEC proc_Import_Add 20, 173, '2022-4-17', 100, 240000 
EXEC proc_Import_Add 20, 174, '2022-4-17', 100, 240000
EXEC proc_Import_Add 20, 175, '2022-4-18', 100, 240000

EXEC proc_Import_Add 21, 176, '2022-4-18', 100, 35000 
EXEC proc_Import_Add 21, 177, '2022-4-19', 100, 25000
EXEC proc_Import_Add 21, 178, '2022-4-19', 100, 25000 
EXEC proc_Import_Add 21, 179, '2022-4-20', 100, 55000
EXEC proc_Import_Add 21, 180, '2022-4-20', 100, 55000 

EXEC proc_Import_Add 22, 181, '2022-4-21', 100, 90000 
EXEC proc_Import_Add 22, 182, '2022-4-21', 100, 70000
EXEC proc_Import_Add 22, 183, '2022-4-22', 100, 70000 
EXEC proc_Import_Add 22, 184, '2022-4-22', 100, 70000
EXEC proc_Import_Add 22, 185, '2022-4-23', 100, 65000 
EXEC proc_Import_Add 22, 186, '2022-4-23', 100, 65000
EXEC proc_Import_Add 22, 187, '2022-4-24', 100, 65000 
EXEC proc_Import_Add 22, 188, '2022-4-24', 100, 65000
EXEC proc_Import_Add 22, 189, '2022-4-25', 100, 60000 
EXEC proc_Import_Add 22, 190, '2022-4-25', 100, 65000

EXEC proc_Import_Add 19, 191, '2022-4-26', 100, 330000 
EXEC proc_Import_Add 19, 192, '2022-4-26', 100, 485000
EXEC proc_Import_Add 19, 193, '2022-4-27', 100, 350000 
EXEC proc_Import_Add 19, 194, '2022-4-27', 100, 350000
EXEC proc_Import_Add 19, 195, '2022-4-28', 100, 330000 
EXEC proc_Import_Add 19, 196, '2022-4-28', 100, 330000
EXEC proc_Import_Add 19, 197, '2022-4-29', 100, 320000 
EXEC proc_Import_Add 19, 198, '2022-4-29', 100, 320000
EXEC proc_Import_Add 19, 199, '2022-4-30', 100, 320000 
EXEC proc_Import_Add 19, 200, '2022-4-30', 100, 320000

EXEC proc_Import_Add 23, 201, '2022-5-1', 100, 70000 
EXEC proc_Import_Add 23, 202, '2022-5-1', 100, 50000
EXEC proc_Import_Add 23, 203, '2022-5-2', 100, 60000 
EXEC proc_Import_Add 23, 204, '2022-5-2', 100, 45000
EXEC proc_Import_Add 23, 205, '2022-5-3', 100, 80000 
EXEC proc_Import_Add 23, 206, '2022-5-3', 100, 55000
EXEC proc_Import_Add 23, 207, '2022-5-4', 100, 60000 
EXEC proc_Import_Add 23, 208, '2022-5-4', 100, 40000
EXEC proc_Import_Add 23, 209, '2022-5-5', 100, 65000 
EXEC proc_Import_Add 23, 210, '2022-5-5', 100, 65000

EXEC proc_Import_Add 24, 211, '2022-5-6', 100, 30000 
EXEC proc_Import_Add 24, 212, '2022-5-6', 100, 125000
EXEC proc_Import_Add 24, 213, '2022-5-7', 100, 230000 
EXEC proc_Import_Add 24, 214, '2022-5-7', 100, 180000
EXEC proc_Import_Add 24, 215, '2022-5-8', 100, 110000 
EXEC proc_Import_Add 24, 216, '2022-5-8', 100, 110000
EXEC proc_Import_Add 24, 217, '2022-5-9', 100, 80000 
EXEC proc_Import_Add 24, 218, '2022-5-9', 100, 55000
EXEC proc_Import_Add 24, 219, '2022-5-10', 100, 55000 
EXEC proc_Import_Add 24, 220, '2022-5-10', 100, 55000

EXEC proc_Import_Add 25, 221, '2022-4-11', 100, 42000 
EXEC proc_Import_Add 25, 222, '2022-4-11', 100, 42000
EXEC proc_Import_Add 25, 223, '2022-4-12', 100, 170000 
EXEC proc_Import_Add 25, 224, '2022-4-12', 100, 170000
EXEC proc_Import_Add 25, 225, '2022-4-13', 100, 35000 
EXEC proc_Import_Add 25, 226, '2022-4-13', 100, 140000
EXEC proc_Import_Add 25, 227, '2022-4-14', 100, 220000 
EXEC proc_Import_Add 25, 228, '2022-4-14', 100, 180000
EXEC proc_Import_Add 25, 229, '2022-4-15', 100, 150000 
EXEC proc_Import_Add 25, 230, '2022-4-15', 100, 55000

EXEC proc_Import_Add 26, 231, '2022-4-16', 100, 170000 
EXEC proc_Import_Add 26, 232, '2022-4-16', 100, 170000
EXEC proc_Import_Add 26, 233, '2022-4-17', 100, 35000 
EXEC proc_Import_Add 26, 234, '2022-4-17', 100, 35000
EXEC proc_Import_Add 26, 235, '2022-4-18', 100, 35000 
EXEC proc_Import_Add 26, 236, '2022-4-18', 100, 15000
EXEC proc_Import_Add 26, 237, '2022-4-19', 100, 140000 
EXEC proc_Import_Add 26, 238, '2022-4-19', 100, 220000
EXEC proc_Import_Add 26, 239, '2022-4-20', 100, 80000 
EXEC proc_Import_Add 26, 240, '2022-4-20', 100, 80000

EXEC proc_Import_Add 27, 241, '2022-4-21', 100, 290000 
EXEC proc_Import_Add 27, 242, '2022-4-21', 100, 280000
EXEC proc_Import_Add 27, 243, '2022-4-22', 100, 280000 
EXEC proc_Import_Add 27, 244, '2022-4-22', 100, 280000
EXEC proc_Import_Add 27, 245, '2022-4-23', 100, 280000 
EXEC proc_Import_Add 27, 246, '2022-4-23', 100, 260000
EXEC proc_Import_Add 27, 247, '2022-4-24', 100, 260000 
EXEC proc_Import_Add 27, 248, '2022-4-24', 100, 260000
EXEC proc_Import_Add 27, 249, '2022-4-25', 100, 260000 
EXEC proc_Import_Add 27, 250, '2022-4-25', 100, 190000

EXEC proc_Import_Add 28, 251, '2022-5-11', 100, 120000 
EXEC proc_Import_Add 28, 252, '2022-5-11', 100, 70000
EXEC proc_Import_Add 28, 253, '2022-5-12', 100, 120000 
EXEC proc_Import_Add 28, 254, '2022-5-12', 100, 80000
EXEC proc_Import_Add 28, 255, '2022-5-13', 100, 70000 
EXEC proc_Import_Add 28, 256, '2022-5-13', 100, 70000
EXEC proc_Import_Add 28, 257, '2022-5-14', 100, 45000 
EXEC proc_Import_Add 28, 258, '2022-5-14', 100, 35000
EXEC proc_Import_Add 28, 259, '2022-5-15', 100, 33000 
EXEC proc_Import_Add 28, 260, '2022-5-15', 100, 25000

EXEC proc_Import_Add 29, 261, '2022-5-16', 100, 350000 
EXEC proc_Import_Add 29, 262, '2022-5-16', 100, 350000
EXEC proc_Import_Add 29, 263, '2022-5-17', 100, 350000 
EXEC proc_Import_Add 29, 264, '2022-5-17', 100, 350000
EXEC proc_Import_Add 29, 265, '2022-5-18', 100, 300000 
EXEC proc_Import_Add 29, 266, '2022-5-18', 100, 310000
EXEC proc_Import_Add 29, 267, '2022-5-19', 100, 200000 
EXEC proc_Import_Add 29, 268, '2022-5-19', 100, 290000
EXEC proc_Import_Add 29, 269, '2022-5-20', 100, 290000 
EXEC proc_Import_Add 29, 270, '2022-5-20', 100, 280000

EXEC proc_Import_Add 30, 271, '2022-5-21', 100, 8000 
EXEC proc_Import_Add 30, 272, '2022-5-21', 100, 140000
EXEC proc_Import_Add 30, 273, '2022-5-22', 100, 130000 
EXEC proc_Import_Add 30, 274, '2022-5-22', 100, 130000
EXEC proc_Import_Add 30, 275, '2022-5-23', 100, 35000 
EXEC proc_Import_Add 30, 276, '2022-5-23', 100, 20000
EXEC proc_Import_Add 30, 277, '2022-5-24', 100, 20000 
EXEC proc_Import_Add 30, 278, '2022-5-24', 100, 20000
EXEC proc_Import_Add 30, 279, '2022-5-25', 100, 18000 
EXEC proc_Import_Add 30, 280, '2022-5-25', 100, 15000

EXEC proc_Import_Add 31, 281, '2022-5-26', 100, 65000 
EXEC proc_Import_Add 31, 282, '2022-5-26', 100, 20000
EXEC proc_Import_Add 31, 283, '2022-5-27', 100, 22000 
EXEC proc_Import_Add 31, 284, '2022-5-27', 100, 20000
EXEC proc_Import_Add 31, 285, '2022-5-28', 100, 22000 
EXEC proc_Import_Add 31, 286, '2022-5-28', 100, 30000
EXEC proc_Import_Add 31, 287, '2022-5-29', 100, 15000 
EXEC proc_Import_Add 31, 288, '2022-5-29', 100, 25000
EXEC proc_Import_Add 31, 289, '2022-5-30', 100, 30000 
EXEC proc_Import_Add 31, 290, '2022-5-30', 100, 6000

--Customer
EXEC proc_Customer_Add '0431728164', N'Đoạn Công Luật','2002/3/23','Nam'
EXEC proc_Customer_Add '0938628266', N'Tông Minh Ðức','2000/7/15','Nam'
EXEC proc_Customer_Add '0613658195', N'Hồ Minh Kiệt','2003/10/31','Nam'
EXEC proc_Customer_Add '0937874164', N'Đặng Lâm Vũ','2002/8/30','Nam'

EXEC proc_Customer_Add '0613674365', N'Đồ Trường Nam','1998/6/5','Nam'
EXEC proc_Customer_Add '0935672714', N'Thang Phương Trang','2001/9/1', N'Nữ'
EXEC proc_Customer_Add '0636728864', N'Cao Kiều Anh','2001/2/20', N'Nữ'
EXEC proc_Customer_Add '0931418164', N'Trịnh Việt Hương','2000/3/23', N'Nữ'

--Bill
EXEC proc_Bill_Add 5, '', 0
EXEC proc_Bill_Add 5, '', 0
EXEC proc_Bill_Add 5, '', 0

EXEC proc_Bill_Add 6, '', 0
EXEC proc_Bill_Add 6, '', 0
EXEC proc_Bill_Add 6, '', 0

EXEC proc_Bill_Add 7,'0431728164', 0
EXEC proc_Bill_Add 7,'0613658195', 0
EXEC proc_Bill_Add 7,'0935672714', 0

EXEC proc_Bill_Add 8,'0636728864', 0
EXEC proc_Bill_Add 8,'0931418164', 0
EXEC proc_Bill_Add 8,'0636728864', 0

--BillInfo
EXEC proc_BillInfo_Add 1,3,3,32000
EXEC proc_BillInfo_Add 1,46,1,97000
EXEC proc_BillInfo_Add 1,98,1,85000
EXEC proc_BillInfo_Add 1,236,1,16000
EXEC proc_BillInfo_Add 1,262,1,360000

EXEC proc_BillInfo_Add 2,290,4,7000
EXEC proc_BillInfo_Add 2,226,1,145000
EXEC proc_BillInfo_Add 2,192,2,500000
EXEC proc_BillInfo_Add 2,33,10,55000
EXEC proc_BillInfo_Add 2,23,8,68000
EXEC proc_BillInfo_Add 2,158,2,14000

EXEC proc_BillInfo_Add 3,152,5,75000
EXEC proc_BillInfo_Add 3,153,8,75000
EXEC proc_BillInfo_Add 3,157,4,15000
EXEC proc_BillInfo_Add 3,235,4,36000

EXEC proc_BillInfo_Add 4,241,5,296000
EXEC proc_BillInfo_Add 4,256,1,71000
EXEC proc_BillInfo_Add 4,257,2,48000
EXEC proc_BillInfo_Add 4,200,2,325000
EXEC proc_BillInfo_Add 4,18,3,17000
EXEC proc_BillInfo_Add 4,33,2,55000

EXEC proc_BillInfo_Add 5,69,4,290000
EXEC proc_BillInfo_Add 5,70,3,450000
EXEC proc_BillInfo_Add 5,63,4,220000
EXEC proc_BillInfo_Add 5,59,5,38000
EXEC proc_BillInfo_Add 5,42,4,132000
EXEC proc_BillInfo_Add 5,33,2,55000

EXEC proc_BillInfo_Add 6,141,6,11000
EXEC proc_BillInfo_Add 6,165,2,48000
EXEC proc_BillInfo_Add 6,201,1,73000
EXEC proc_BillInfo_Add 6,224,5,180000

EXEC proc_BillInfo_Add 7,282,1,25000
EXEC proc_BillInfo_Add 7,284,1,21000
EXEC proc_BillInfo_Add 7,289,1,33000
EXEC proc_BillInfo_Add 7,278,5,23000
EXEC proc_BillInfo_Add 7,262,1,360000

EXEC proc_BillInfo_Add 8,240,1,90000
EXEC proc_BillInfo_Add 8,237,3,145000
EXEC proc_BillInfo_Add 8,227,2,230000
EXEC proc_BillInfo_Add 8,219,5,60000
EXEC proc_BillInfo_Add 8,147,10,28000
EXEC proc_BillInfo_Add 8,140,5,11000
EXEC proc_BillInfo_Add 8,137,5,28000
EXEC proc_BillInfo_Add 8,145,5,11000

EXEC proc_BillInfo_Add 9,267,1,219000
EXEC proc_BillInfo_Add 9,262,1,360000
EXEC proc_BillInfo_Add 9,290,1,7000
EXEC proc_BillInfo_Add 9,285,1,25000
EXEC proc_BillInfo_Add 9,273,1,133000

EXEC proc_BillInfo_Add 10,95,1,100000
EXEC proc_BillInfo_Add 10,72,1,145000
EXEC proc_BillInfo_Add 10,78,2,350000
EXEC proc_BillInfo_Add 10,80,3,200000

EXEC proc_BillInfo_Add 11,102,1,17000
EXEC proc_BillInfo_Add 11,110,1,26000
EXEC proc_BillInfo_Add 11,12,3,25000
EXEC proc_BillInfo_Add 11,18,3,17000
EXEC proc_BillInfo_Add 11,207,2,62000

EXEC proc_BillInfo_Add 12,252,1,78000
EXEC proc_BillInfo_Add 12,250,1,198000
EXEC proc_BillInfo_Add 12,257,1,48000
EXEC proc_BillInfo_Add 12,259,1,36000
EXEC proc_BillInfo_Add 12,206,3,58000

EXEC [dbo].[proc_Bill_RoundTotal] 1
EXEC [dbo].[proc_Bill_RoundTotal] 2
EXEC [dbo].[proc_Bill_RoundTotal] 3
EXEC [dbo].[proc_Bill_RoundTotal] 4
EXEC [dbo].[proc_Bill_RoundTotal] 5
EXEC [dbo].[proc_Bill_RoundTotal] 6
EXEC [dbo].[proc_Bill_RoundTotal] 7
EXEC [dbo].[proc_Bill_RoundTotal] 8
EXEC [dbo].[proc_Bill_RoundTotal] 9
EXEC [dbo].[proc_Bill_RoundTotal] 10
EXEC [dbo].[proc_Bill_RoundTotal] 11
EXEC [dbo].[proc_Bill_RoundTotal] 12

--Customer 
EXEC proc_Customer_AccumulatePoints '0431728164',7
EXEC proc_Customer_AccumulatePoints '0613658195',8
EXEC proc_Customer_AccumulatePoints '0935672714',9

EXEC proc_Customer_AccumulatePoints '0636728864',10
EXEC proc_Customer_AccumulatePoints '0931418164',11
EXEC proc_Customer_AccumulatePoints '0636728864',12



