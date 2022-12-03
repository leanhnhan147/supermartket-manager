
USE [SupermarketManagement]
GO

-- Tạo ROLE	Quản lý
EXEC sp_addrole 'db_Manager'

-- Cấp quyền vào các bảng
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Account] TO db_Manager
GRANT SELECT ON [dbo].[Position] TO db_Manager
GRANT SELECT ON [dbo].[Category] TO db_Manager
GRANT SELECT, UPDATE, DELETE ON [dbo].[Product] TO db_Manager
GRANT SELECT, INSERT, UPDATE ON [dbo].[Bill] TO db_Manager
GRANT SELECT, INSERT, UPDATE ON [dbo].[BillInfo] TO db_Manager
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Customer] TO db_Manager
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Employee] TO db_Manager
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Import] TO db_Manager
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Company] TO db_Manager

-- Cấp quyền exec func, proc
GRANT SELECT ON [dbo].[func_Account_GetAccount] TO db_Manager
GRANT SELECT ON [dbo].[func_Category_GetAll] TO db_Manager
GRANT EXEC ON [dbo].[proc_Category_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Category_Update] TO db_Manager
GRANT EXEC ON [dbo].[proc_Category_Delete] TO db_Manager
GRANT SELECT ON [dbo].[func_Product_GetAll] TO db_Manager
GRANT EXEC ON [dbo].[proc_Product_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Product_Update] TO db_Manager
GRANT EXEC ON [dbo].[proc_Product_Delete] TO db_Manager
GRANT SELECT ON [dbo].[func_Customer_GetAll] TO db_Manager
GRANT SELECT ON [dbo].[func_Customer_FindByPhone] TO db_Manager
GRANT EXEC ON [dbo].[proc_Customer_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Customer_Update] TO db_Manager
GRANT EXEC ON [dbo].[proc_Customer_Delete] TO db_Manager
GRANT EXEC ON [dbo].[proc_Bill_Add] TO db_Manager
GRANT EXEC ON [dbo].[func_Bill_GetNewestBillId] TO db_Manager
GRANT EXEC ON [dbo].[proc_BillInfo_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Bill_RoundTotal] TO db_Manager
GRANT EXEC ON [dbo].[func_BillInfo_CalcTotal] TO db_Manager
GRANT EXEC ON [dbo].[proc_Customer_AccumulatePoints] TO db_Manager
GRANT EXEC ON [dbo].[proc_Import_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Import_Delete] TO db_Manager
GRANT SELECT ON [dbo].[func_Import_GetAll] TO db_Manager
GRANT SELECT ON [dbo].[func_Product_GetAll] TO db_Manager
GRANT SELECT ON [dbo].[func_Company_GetAll] TO db_Manager
GRANT EXEC ON [dbo].[proc_Company_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Company_Update] TO db_Manager
GRANT EXEC ON [dbo].[proc_Company_Delete] TO db_Manager
GRANT SELECT ON [dbo].[func_Warehouse_GetAll] TO db_Manager
GRANT EXEC ON [dbo].[proc_Warehouse_Add] TO db_Manager
GRANT EXEC ON [dbo].[proc_Warehouse_Update] TO db_Manager
GRANT EXEC ON [dbo].[proc_Warehouse_Delete] TO db_Manager



-- Tạo ROLE Thu ngân
EXEC sp_addrole 'db_Cashier'

-- Cấp quyền vào các bảng
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Account] TO db_Cashier
GRANT SELECT ON [dbo].[Position] TO db_Cashier
GRANT SELECT ON [dbo].[Category] TO db_Cashier
GRANT SELECT, UPDATE ON [dbo].[Product] TO db_Cashier
GRANT SELECT, INSERT, UPDATE ON [dbo].[Bill] TO db_Cashier
GRANT SELECT, INSERT, UPDATE ON [dbo].[BillInfo] TO db_Cashier
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Customer] TO db_Cashier

-- Cấp quyền exec proc func, proc
GRANT SELECT ON [dbo].[func_Account_GetAccount] TO db_Cashier
GRANT SELECT ON [dbo].[func_Category_GetAll] TO db_Cashier
GRANT SELECT ON [dbo].[func_Product_GetAll] TO db_Cashier
GRANT SELECT ON [dbo].[func_Customer_GetAll] TO db_Cashier
GRANT EXEC ON [dbo].[proc_Customer_Add] TO db_Cashier
GRANT EXEC ON [dbo].[proc_Customer_Update] TO db_Cashier
GRANT EXEC ON [dbo].[proc_Customer_Delete] TO db_Cashier
GRANT EXEC ON [dbo].[proc_Bill_Add] TO db_Cashier
GRANT EXEC ON [dbo].[func_Bill_GetNewestBillId] TO db_Cashier
GRANT EXEC ON [dbo].[proc_BillInfo_Add] TO db_Cashier
GRANT EXEC ON [dbo].[proc_Bill_RoundTotal] TO db_Cashier
GRANT EXEC ON [dbo].[func_BillInfo_CalcTotal] TO db_Cashier
GRANT EXEC ON [dbo].[proc_Customer_AccumulatePoints] TO db_Cashier
GRANT SELECT ON [dbo].[func_Customer_FindByPhone] TO db_Cashier

-- Tạo ROLE Thủ kho
EXEC sp_addrole 'db_WarehouseKeeper'

-- Cấp quyền vào các bảng
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Account] TO  db_WarehouseKeeper
GRANT SELECT, UPDATE, DELETE ON [dbo].[Product] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[Position] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[Category] TO db_WarehouseKeeper
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Employee] TO db_WarehouseKeeper
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Import] TO db_WarehouseKeeper
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Company] TO db_WarehouseKeeper
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[Warehouse] TO db_WarehouseKeeper

-- Cấp quyền EXEC proc, SELECT func
GRANT SELECT ON [dbo].[func_Account_GetAccount] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[func_Category_GetAll] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Import_Add] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Import_Delete] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[func_Import_GetAll] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[func_Product_GetAll] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Product_Add] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Product_Update] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Product_Delete] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[func_Company_GetAll] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Company_Add] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Company_Update] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Company_Delete] TO db_WarehouseKeeper
GRANT SELECT ON [dbo].[func_Warehouse_GetAll] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Warehouse_Add] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Warehouse_Update] TO db_WarehouseKeeper
GRANT EXEC ON [dbo].[proc_Warehouse_Delete] TO db_WarehouseKeeper	