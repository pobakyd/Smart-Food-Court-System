CREATE DATABASE SmartFoodCourtSystem
GO

USE SmartFoodCourtSystem
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'DisplayName',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	TypeCourt INT NOT NULL,
	TypeAccount INT NOT NULL  DEFAULT 0 -- 2: admin && 1: staff && 0: user
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	typeCourt INT NOT NULL,
	food_detail NVARCHAR(500), 
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE OrderFood
(
	id INT IDENTITY PRIMARY KEY,
	DateOrder DATE NOT NULL DEFAULT GETDATE(),
	DatePay DATE,
	UserName NVARCHAR(100) NOT NULL,
	StatusOrder INT NOT NULL DEFAULT 0,
	StatusPay int NOT NULL DEFAULT 0,
	TypeAcourt INT NOT null
	FOREIGN KEY(UserName) REFERENCES dbo.Account(UserName) 
)
GO


CREATE TABLE OrderFoodInfo
(
	id INT IDENTITY PRIMARY KEY,
	idOrderFood INT NOT NULL,
	idFood INT NOT NULL,
	amount INT NOT NULL DEFAULT 0,
	userMess NVARCHAR(500),
	FOREIGN KEY(idOrderFood) REFERENCES dbo.OrderFood(id),
	FOREIGN KEY(idFood) REFERENCES dbo.Food(id)
)
GO


CREATE TABLE UserMess
(
	id int IDENTITY PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	Status INT NOT NULL DEFAULT 0,
	Mess NVARCHAR(1000),
	FOREIGN KEY(UserName) REFERENCES dbo.Account(UserName)
)



CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
		  TypeCourt,
          TypeAccount
        )
VALUES  ( N'longnhat' , -- UserName - nvarchar(100)
          N'Long Nhật' , -- DisplayName - nvarchar(100)
          N'0' , -- PassWord - nvarchar(1000)
		  0,
          0  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
		  TypeCourt,
          TypeAccount
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'Nhân Viên The Canteen' , -- DisplayName - nvarchar(100)
          N'0' , -- PassWord - nvarchar(1000)
          1  ,-- Type - int
		  1
        )
GO
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
		  TypeCourt,
          TypeAccount
        )
VALUES  ( N'admin' , -- UserName - nvarchar(100)
          N'Quản lí toàn khu' , -- DisplayName - nvarchar(100)
          N'0' , -- PassWord - nvarchar(1000)
          0  ,-- Type - int
		  2
        )
GO

ALTER PROC USP_GetAccountByUserName
@userName nvarchar(100), @typeCourt int
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND (TypeCourt = @typeCourt OR TypeCourt=0)
END
GO


alter PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100), @typeCourt INT, @typeAccount INT 
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord AND ( TypeCourt = @typeCourt OR TypeCourt=0) AND ( TypeAccount=@typeAccount OR TypeAccount=2)
END
GO

-- thêm bàn
DECLARE @i INT = 0

WHILE @i <= 20
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

-- thêm category
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Bánh mì'  -- name - nvarchar(100)
          )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nước giải khát' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Đồ ăn nhanh' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Trà sữa' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Bún phở' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Cơm' )

SELECT * FROM dbo.FoodCategory
-- thêm món ăn
-- quầy 1 --
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì heo quay' , -- name - nvarchar(100)
          1 , -- idCategory - int
          15000 , -- price - float
          1 , -- typeCourt - int
          N'Bánh mì giòn thơm, heo quay da giòn ngon khó cưỡng, nước sốt thần thánh'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì ốp la' , -- name - nvarchar(100)
          1 , -- idCategory - int
          10000 , -- price - float
          1 , -- typeCourt - int
          N'Trứng gà chín vừa tới còn độ béo ngậy rất thơm,giàu dinh dương kết hợp với rau dưa cân bằng dưỡng chất'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì xíu mại' , -- name - nvarchar(100)
          1 , -- idCategory - int
          15000 , -- price - float
          1 , -- typeCourt - int
          N'Với công thức làm xíu mại gia truyền của phố người Hoa chúng tôi đã tạo nên viên xíu mại đậm vị thơm ngon'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì chả cá' , -- name - nvarchar(100)
          1 , -- idCategory - int
          20000 , -- price - float
          1 , -- typeCourt - int
          N'Chả cá nhập từ Quy Nhơn được làm thủ công rất dai, ngọt và thơm đảm bảo các bạn sẽ mê mệt với món này'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà đào cam sả' , -- name - nvarchar(100)
          2 , -- idCategory - int
          20000 , -- price - float
          1 , -- typeCourt - int
          N'Mang đến 1 cảm giác tươi mới cho ngày dài mệt mỏi'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cafe đen đá' , -- name - nvarchar(100)
          2 , -- idCategory - int
          10000 , -- price - float
          1 , -- typeCourt - int
          N'Vị đắng nhẹ, thơm ngon'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cafe sữa đá' , -- name - nvarchar(100)
          2 , -- idCategory - int
          12000 , -- price - float
          1 , -- typeCourt - int
          N'Kết hợp với sữa để có thêm chút vị béo cho ly café đậm đà'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Pepsi' , -- name - nvarchar(100)
          2 , -- idCategory - int
          8000 , -- price - float
          1 , -- typeCourt - int
          N'Vừa ăn vừa uống pepsi thì còn gì bằng nhỉ?'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Sting' , -- name - nvarchar(100)
          2 , -- idCategory - int
          10000 , -- price - float
          1 , -- typeCourt - int
          N'Dành cho các bạn thích mùi thơm của dâu'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Oshi' , -- name - nvarchar(100)
          3 , -- idCategory - int
          7000 , -- price - float
          1 , -- typeCourt - int
          N'Ngon giòn'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh tráng trộn' , -- name - nvarchar(100)
          3 , -- idCategory - int
          10000 , -- price - float
          1 , -- typeCourt - int
          N'Gồm có tôm khô, bò khô, trứng cút,….'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Đồ viên chiên' , -- name - nvarchar(100)
          3 , -- idCategory - int
          9000 , -- price - float
          1 , -- typeCourt - int
          N'Cá, Bò, Tôm, Gà, Trứng chiên,….'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa truyền thống' , -- name - nvarchar(100)
          4 , -- idCategory - int
          15000 , -- price - float
          1 , -- typeCourt - int
          N'Trân châu mềm thơm, vị trà thơm phức'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa Matcha' , -- name - nvarchar(100)
          4 , -- idCategory - int
          20000 , -- price - float
          1 , -- typeCourt - int
          N'Matcha được nhập từ Mỹ đảm bảo chất lượng thanh lọc cơ thể'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa trân châu đường đen' , -- name - nvarchar(100)
          4 , -- idCategory - int
          25000 , -- price - float
          1 , -- typeCourt - int
          N'Trà sữa truyền thống nhưng được dùng với loại đường hảo hạn thơm ngon'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bún riêu cua' , -- name - nvarchar(100)
          7 , -- idCategory - int
          15000 , -- price - float
          1 , -- typeCourt - int
          N'Cua tuyển chọn từ miền Tây được nấu kĩ càng để ra được 1 nồi nước dùng độc đáo'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bún chả cá' , -- name - nvarchar(100)
          7 , -- idCategory - int
         15000 , -- price - float
          1 , -- typeCourt - int
          N'Bún chả cá được nấu từ công thức của Nha Trang và nguyên liệu cũng nhập từ đó'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Phở bò' , -- name - nvarchar(100)
          7 , -- idCategory - int
         25000 , -- price - float
          1 , -- typeCourt - int
          N'Phở bò thập cẩm: đuôi, nạm, tái,… Giàu chất dinh dưỡng'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Phờ gà' , -- name - nvarchar(100)
          7 , -- idCategory - int
         30000 , -- price - float
          1 , -- typeCourt - int
          N'Gà được tuyển chọn từ những con gà nuôi thả rong thịt dai ngọt,….'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm sườn trứng' , -- name - nvarchar(100)
          6 , -- idCategory - int
          0.0 , -- price - float
          1 , -- typeCourt - int
          N'Sườn được ướp gia vị đậm đà nướng lên thơm ngất ngây. Hạt gạo nấu cơm là loại gạo ngon nhất thế giới ST25'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm gà chiên nước mắm' , -- name - nvarchar(100)
          6 , -- idCategory - int
          25000 , -- price - float
          1 , -- typeCourt - int
          N'Gà được chiên giòn rồi chiên với nước mắm thơm nức mũi'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm cá bóng kho' , -- name - nvarchar(100)
          6 , -- idCategory - int
          30000 , -- price - float
          1 , -- typeCourt - int
          N'Cá bóng được mua từ những người dân mới đánh bắt vào bờ nên đảm bảo độ tươi ngon kết hợp với nước sốt đặc biệt của quán thì quả đúng là 1 món ngon trên đời'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm canh chua cá hú' , -- name - nvarchar(100)
          6 , -- idCategory - int
          25000 , -- price - float
          1 , -- typeCourt - int
          N'Tô canh đầy đủ hương săc vị. Được nấu từ vị ngọt của cá,thơm; vị chua của me, cà chua; mùi thơm từ các loại rau: rau răm, lá quế,…  '  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm thịt kho tàu' , -- name - nvarchar(100)
          6 , -- idCategory - int
          20000 , -- price - float
          1 , -- typeCourt - int
          N'Thịt ba chỉ với trứng vịt được kho với nước dừa rất ngọt và thịt heo mềm dịu ít béo'  -- food_detail - nvarchar(500)
        )
		------
-- quầy 2 --
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì heo quay' , -- name - nvarchar(100)
          1 , -- idCategory - int
          15000 , -- price - float
          2 , -- typeCourt - int
          N'Bánh mì giòn thơm, heo quay da giòn ngon khó cưỡng, nước sốt thần thánh'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì ốp la' , -- name - nvarchar(100)
          1 , -- idCategory - int
          10000 , -- price - float
          2 , -- typeCourt - int
          N'Trứng gà chín vừa tới còn độ béo ngậy rất thơm,giàu dinh dương kết hợp với rau dưa cân bằng dưỡng chất'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì xíu mại' , -- name - nvarchar(100)
          1 , -- idCategory - int
          15000 , -- price - float
          2 , -- typeCourt - int
          N'Với công thức làm xíu mại gia truyền của phố người Hoa chúng tôi đã tạo nên viên xíu mại đậm vị thơm ngon'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì chả cá' , -- name - nvarchar(100)
          1 , -- idCategory - int
          20000 , -- price - float
          2 , -- typeCourt - int
          N'Chả cá nhập từ Quy Nhơn được làm thủ công rất dai, ngọt và thơm đảm bảo các bạn sẽ mê mệt với món này'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà đào cam sả' , -- name - nvarchar(100)
          2 , -- idCategory - int
          20000 , -- price - float
          2 , -- typeCourt - int
          N'Mang đến 1 cảm giác tươi mới cho ngày dài mệt mỏi'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cafe đen đá' , -- name - nvarchar(100)
          2 , -- idCategory - int
          10000 , -- price - float
          2 , -- typeCourt - int
          N'Vị đắng nhẹ, thơm ngon'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cafe sữa đá' , -- name - nvarchar(100)
          2 , -- idCategory - int
          12000 , -- price - float
          2 , -- typeCourt - int
          N'Kết hợp với sữa để có thêm chút vị béo cho ly café đậm đà'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Pepsi' , -- name - nvarchar(100)
          2 , -- idCategory - int
          8000 , -- price - float
          2 , -- typeCourt - int
          N'Vừa ăn vừa uống pepsi thì còn gì bằng nhỉ?'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Sting' , -- name - nvarchar(100)
          2 , -- idCategory - int
          10000 , -- price - float
          2 , -- typeCourt - int
          N'Dành cho các bạn thích mùi thơm của dâu'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Oshi' , -- name - nvarchar(100)
          3 , -- idCategory - int
          7000 , -- price - float
          2 , -- typeCourt - int
          N'Ngon giòn'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh tráng trộn' , -- name - nvarchar(100)
          3 , -- idCategory - int
          10000 , -- price - float
          2 , -- typeCourt - int
          N'Gồm có tôm khô, bò khô, trứng cút,….'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Đồ viên chiên' , -- name - nvarchar(100)
          3 , -- idCategory - int
          9000 , -- price - float
          2 , -- typeCourt - int
          N'Cá, Bò, Tôm, Gà, Trứng chiên,….'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa truyền thống' , -- name - nvarchar(100)
          4 , -- idCategory - int
          15000 , -- price - float
          2 , -- typeCourt - int
          N'Trân châu mềm thơm, vị trà thơm phức'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa Matcha' , -- name - nvarchar(100)
          4 , -- idCategory - int
          20000 , -- price - float
          2 , -- typeCourt - int
          N'Matcha được nhập từ Mỹ đảm bảo chất lượng thanh lọc cơ thể'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa trân châu đường đen' , -- name - nvarchar(100)
          4 , -- idCategory - int
          25000 , -- price - float
          2 , -- typeCourt - int
          N'Trà sữa truyền thống nhưng được dùng với loại đường hảo hạn thơm ngon'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bún riêu cua' , -- name - nvarchar(100)
          7 , -- idCategory - int
          15000 , -- price - float
          2 , -- typeCourt - int
          N'Cua tuyển chọn từ miền Tây được nấu kĩ càng để ra được 1 nồi nước dùng độc đáo'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bún chả cá' , -- name - nvarchar(100)
          7 , -- idCategory - int
         15000 , -- price - float
          2 , -- typeCourt - int
          N'Bún chả cá được nấu từ công thức của Nha Trang và nguyên liệu cũng nhập từ đó'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Phở bò' , -- name - nvarchar(100)
          7 , -- idCategory - int
         25000 , -- price - float
          2 , -- typeCourt - int
          N'Phở bò thập cẩm: đuôi, nạm, tái,… Giàu chất dinh dưỡng'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Phờ gà' , -- name - nvarchar(100)
          7 , -- idCategory - int
         30000 , -- price - float
          2 , -- typeCourt - int
          N'Gà được tuyển chọn từ những con gà nuôi thả rong thịt dai ngọt,….'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm sườn trứng' , -- name - nvarchar(100)
          6 , -- idCategory - int
          0.0 , -- price - float
          2 , -- typeCourt - int
          N'Sườn được ướp gia vị đậm đà nướng lên thơm ngất ngây. Hạt gạo nấu cơm là loại gạo ngon nhất thế giới ST25'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm gà chiên nước mắm' , -- name - nvarchar(100)
          6 , -- idCategory - int
          25000 , -- price - float
          2 , -- typeCourt - int
          N'Gà được chiên giòn rồi chiên với nước mắm thơm nức mũi'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm cá bóng kho' , -- name - nvarchar(100)
          6 , -- idCategory - int
          30000 , -- price - float
          2 , -- typeCourt - int
          N'Cá bóng được mua từ những người dân mới đánh bắt vào bờ nên đảm bảo độ tươi ngon kết hợp với nước sốt đặc biệt của quán thì quả đúng là 1 món ngon trên đời'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm canh chua cá hú' , -- name - nvarchar(100)
          6 , -- idCategory - int
          25000 , -- price - float
          2 , -- typeCourt - int
          N'Tô canh đầy đủ hương săc vị. Được nấu từ vị ngọt của cá,thơm; vị chua của me, cà chua; mùi thơm từ các loại rau: rau răm, lá quế,…  '  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm thịt kho tàu' , -- name - nvarchar(100)
          6 , -- idCategory - int
          20000 , -- price - float
          2 , -- typeCourt - int
          N'Thịt ba chỉ với trứng vịt được kho với nước dừa rất ngọt và thịt heo mềm dịu ít béo'  -- food_detail - nvarchar(500)
        )
		--------
-- quầy 3 --
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì heo quay' , -- name - nvarchar(100)
          1 , -- idCategory - int
          15000 , -- price - float
          3 , -- typeCourt - int
          N'Bánh mì giòn thơm, heo quay da giòn ngon khó cưỡng, nước sốt thần thánh'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì ốp la' , -- name - nvarchar(100)
          1 , -- idCategory - int
          10000 , -- price - float
          3 , -- typeCourt - int
          N'Trứng gà chín vừa tới còn độ béo ngậy rất thơm,giàu dinh dương kết hợp với rau dưa cân bằng dưỡng chất'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì xíu mại' , -- name - nvarchar(100)
          1 , -- idCategory - int
          15000 , -- price - float
          3 , -- typeCourt - int
          N'Với công thức làm xíu mại gia truyền của phố người Hoa chúng tôi đã tạo nên viên xíu mại đậm vị thơm ngon'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh mì chả cá' , -- name - nvarchar(100)
          1 , -- idCategory - int
          20000 , -- price - float
          3 , -- typeCourt - int
          N'Chả cá nhập từ Quy Nhơn được làm thủ công rất dai, ngọt và thơm đảm bảo các bạn sẽ mê mệt với món này'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà đào cam sả' , -- name - nvarchar(100)
          2 , -- idCategory - int
          20000 , -- price - float
          3 , -- typeCourt - int
          N'Mang đến 1 cảm giác tươi mới cho ngày dài mệt mỏi'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cafe đen đá' , -- name - nvarchar(100)
          2 , -- idCategory - int
          10000 , -- price - float
          3 , -- typeCourt - int
          N'Vị đắng nhẹ, thơm ngon'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cafe sữa đá' , -- name - nvarchar(100)
          2 , -- idCategory - int
          12000 , -- price - float
          3 , -- typeCourt - int
          N'Kết hợp với sữa để có thêm chút vị béo cho ly café đậm đà'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Pepsi' , -- name - nvarchar(100)
          2 , -- idCategory - int
          8000 , -- price - float
          3 , -- typeCourt - int
          N'Vừa ăn vừa uống pepsi thì còn gì bằng nhỉ?'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Sting' , -- name - nvarchar(100)
          2 , -- idCategory - int
          10000 , -- price - float
          3 , -- typeCourt - int
          N'Dành cho các bạn thích mùi thơm của dâu'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Oshi' , -- name - nvarchar(100)
          3 , -- idCategory - int
          7000 , -- price - float
          3 , -- typeCourt - int
          N'Ngon giòn'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bánh tráng trộn' , -- name - nvarchar(100)
          3 , -- idCategory - int
          10000 , -- price - float
          3 , -- typeCourt - int
          N'Gồm có tôm khô, bò khô, trứng cút,….'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Đồ viên chiên' , -- name - nvarchar(100)
          3 , -- idCategory - int
          9000 , -- price - float
          3 , -- typeCourt - int
          N'Cá, Bò, Tôm, Gà, Trứng chiên,….'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa truyền thống' , -- name - nvarchar(100)
          4 , -- idCategory - int
          15000 , -- price - float
          3 , -- typeCourt - int
          N'Trân châu mềm thơm, vị trà thơm phức'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa Matcha' , -- name - nvarchar(100)
          4 , -- idCategory - int
          20000 , -- price - float
          3 , -- typeCourt - int
          N'Matcha được nhập từ Mỹ đảm bảo chất lượng thanh lọc cơ thể'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Trà sữa trân châu đường đen' , -- name - nvarchar(100)
          4 , -- idCategory - int
          25000 , -- price - float
          3 , -- typeCourt - int
          N'Trà sữa truyền thống nhưng được dùng với loại đường hảo hạn thơm ngon'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bún riêu cua' , -- name - nvarchar(100)
          7 , -- idCategory - int
          15000 , -- price - float
          3 , -- typeCourt - int
          N'Cua tuyển chọn từ miền Tây được nấu kĩ càng để ra được 1 nồi nước dùng độc đáo'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Bún chả cá' , -- name - nvarchar(100)
          7 , -- idCategory - int
         15000 , -- price - float
          3 , -- typeCourt - int
          N'Bún chả cá được nấu từ công thức của Nha Trang và nguyên liệu cũng nhập từ đó'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Phở bò' , -- name - nvarchar(100)
          7 , -- idCategory - int
         25000 , -- price - float
          3 , -- typeCourt - int
          N'Phở bò thập cẩm: đuôi, nạm, tái,… Giàu chất dinh dưỡng'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Phờ gà' , -- name - nvarchar(100)
          7 , -- idCategory - int
         30000 , -- price - float
          3 , -- typeCourt - int
          N'Gà được tuyển chọn từ những con gà nuôi thả rong thịt dai ngọt,….'  -- food_detail - nvarchar(500)
        )
		--
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm sườn trứng' , -- name - nvarchar(100)
          6 , -- idCategory - int
          0.0 , -- price - float
          3 , -- typeCourt - int
          N'Sườn được ướp gia vị đậm đà nướng lên thơm ngất ngây. Hạt gạo nấu cơm là loại gạo ngon nhất thế giới ST25'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm gà chiên nước mắm' , -- name - nvarchar(100)
          6 , -- idCategory - int
          25000 , -- price - float
          3 , -- typeCourt - int
          N'Gà được chiên giòn rồi chiên với nước mắm thơm nức mũi'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm cá bóng kho' , -- name - nvarchar(100)
          6 , -- idCategory - int
          30000 , -- price - float
          3 , -- typeCourt - int
          N'Cá bóng được mua từ những người dân mới đánh bắt vào bờ nên đảm bảo độ tươi ngon kết hợp với nước sốt đặc biệt của quán thì quả đúng là 1 món ngon trên đời'  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm canh chua cá hú' , -- name - nvarchar(100)
          6 , -- idCategory - int
          25000 , -- price - float
          3 , -- typeCourt - int
          N'Tô canh đầy đủ hương săc vị. Được nấu từ vị ngọt của cá,thơm; vị chua của me, cà chua; mùi thơm từ các loại rau: rau răm, lá quế,…  '  -- food_detail - nvarchar(500)
        )
INSERT dbo.Food
        ( name ,
          idCategory ,
          price ,
          typeCourt ,
          food_detail
        )
VALUES  ( N'Cơm thịt kho tàu' , -- name - nvarchar(100)
          6 , -- idCategory - int
          20000 , -- price - float
          3 , -- typeCourt - int
          N'Thịt ba chỉ với trứng vịt được kho với nước dừa rất ngọt và thịt heo mềm dịu ít béo'  -- food_detail - nvarchar(500)
        )

-- thêm bill
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          4, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          5 , -- idTable - int
          1  -- status - int
        )
-- thêm bill infor
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          6, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 3, -- idBill - int
          5, -- idFood - int
          2  -- count - int
          )         
          
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0  -- status - int
	        )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO


CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
	end
	
END
GO


CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO


CREATE PROC USP_SwitchTabel
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

ALTER TABLE dbo.Bill ADD totalPrice FLOAT
GO

DELETE dbo.BillInfo
DELETE dbo.Bill

GO

CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên bàn],b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

ALTER  PROC USP_GetListOrderByDate
@dateOrder date, @datePay DATE, @typeCourt INT 
AS 
BEGIN
	SELECT A.id AS [ID],A.UserName AS [Tên tài khoản], C.name AS [Tên món ăn], B.amount AS [Số lượng], C.price AS [Đơn giá], A.DateOrder AS [Ngày đặt hàng], A.DatePay AS [Ngày thanh toán] FROM dbo.OrderFood AS A, dbo.OrderFoodInfo AS B, dbo.Food AS C
	WHERE A.DateOrder>=@dateOrder AND A.DatePay<=@datePay AND A.StatusPay=1 AND C.typeCourt=@typeCourt
	AND B.idOrderFood=A.id AND B.idFood=C.id
END
GO

ALTER PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

GO

CREATE PROC USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.ID, t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC USP_GetNumBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

CREATE PROC USP_GetListBillByDateForReport
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name, b.totalPrice, DateCheckIn, DateCheckOut
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO
SELECT * FROM dbo.OrderFood
SELECT A.id AS N'ID',C.name AS N'Tên món ăn',C.price AS N'Đơn giá',B.amount AS N'Số lượng', C.price*B.amount AS N'Thành tiền',A.DateOrder as N'Ngày đặt hàng',A.DatePay AS N'Ngày thanh toán' FROM dbo.OrderFood AS A, dbo.OrderFoodInfo AS B, dbo.Food AS C WHERE B.idOrderFood=A.id AND B.idFood=C.id AND A.StatusOrder=1 AND  A.StatusPay=0 AND A.UserName=N'quay2'