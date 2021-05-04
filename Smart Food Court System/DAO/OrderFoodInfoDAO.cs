using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DAO
{
    public class OrderFoodInfoDAO
    {
        private static OrderFoodInfoDAO instance;

        public static OrderFoodInfoDAO Instance
        {
            get { if (instance == null) instance = new OrderFoodInfoDAO(); return OrderFoodInfoDAO.instance; }
            private set { OrderFoodInfoDAO.instance = value; }
        }

        private OrderFoodInfoDAO() { }

        public void InsertOrderFoodInfoByUser(int idOrderFood, int idFood, int amount, string userMess)
        {
            string query = "INSERT dbo.OrderFoodInfo( idOrderFood , idFood , amount , userMess  ) VALUES  ( @idOrderFood , @idFood , @amount , @userMess  )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idOrderFood, idFood, amount, userMess });
        }
        
        public int GetMaxIDFoodOrder()
        {
            string query = "SELECT MAX(id) FROM dbo.OrderFood";
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public DataTable GetUserCart(string userName, int typeCourt)
        {
            string query = " SELECT A.id AS N'ID',A.DateOrder AS N'Ngày thêm vào',C.name AS N'Tên món ăn',B.amount AS N'Số lượng', B.amount*C.price AS N'Thành tiền' FROM dbo.OrderFood AS A, dbo.OrderFoodInfo AS B, dbo.Food AS C WHERE B.idOrderFood = A.id AND B.idFood=C.id AND A.StatusOrder=0 AND A.UserName = @userName AND A.TypeACourt = @typeCourt ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { userName, typeCourt });
        }

        public bool DeleteOrderFoodByID(int id)
        {
            string query1 = " DELETE dbo.OrderFoodInfo WHERE idOrderFood = @id ";
            DataProvider.Instance.ExecuteNonQuery(query1, new object[] { id });
            string query2 = " DELETE dbo.OrderFood WHERE id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query2, new object[] { id })>0;
        }

        public DataTable GetOrderFoodInfoByID(int id)
        {
            string query = "SELECT  A.id,A.UserName, A.DateOrder,C.name,B.amount,C.price,B.amount*C.price AS N'Thành tiền',B.userMess FROM dbo.OrderFood AS A, dbo.OrderFoodInfo AS B, dbo.Food AS C WHERE B.idOrderFood=A.id AND B.idFood=C.id AND A.id=" + id.ToString();
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetUserHistory(string userName)
        {
            string query = string.Format("SELECT A.id AS N'ID',C.name AS N'Tên món ăn',C.price AS N'Đơn giá',B.amount AS N'Số lượng', C.price*B.amount AS N'Thành tiền',A.DateOrder as N'Ngày đặt hàng',A.DatePay AS N'Ngày thanh toán' FROM dbo.OrderFood AS A, dbo.OrderFoodInfo AS B, dbo.Food AS C WHERE B.idOrderFood=A.id AND B.idFood=C.id and statusOrder=1 and statusPay=1 AND A.UserName=N'{0}'", userName);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
