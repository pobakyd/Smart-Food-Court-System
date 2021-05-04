using SmartFoodCourtSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DAO
{
    public class OrderFoodDAO
    {
        private static OrderFoodDAO instance;

        public static OrderFoodDAO Instance
        {
            get { if (instance == null) instance = new OrderFoodDAO(); return OrderFoodDAO.instance; }
            private set { OrderFoodDAO.instance = value; }
        }

        private OrderFoodDAO() { }

        public List<OrderFood> GetOrderFoodByCourt(int typeCourt)
        {
            List<OrderFood> listOrder = new List<OrderFood>();
            string query = "SELECT * FROM dbo.OrderFood WHERE StatusOrder=1 AND StatusPay=0 AND TypeACourt= " + typeCourt.ToString();
            DataTable temp = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in temp.Rows)
            {
                listOrder.Add(new OrderFood(item));
            }
            return listOrder;
        }
        public bool InsertOrderFoodByUser(string userName, int typeCourt)
        {
            string query= "INSERT dbo.OrderFood( DateOrder ,DatePay ,UserName , TypeAcourt ,StatusOrder,StatusPay ) VALUES  ( GETDATE() , GETDATE() , N'" + userName + "', " + typeCourt.ToString() + " , 0 ,0  ) " ;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool InsertOrderFoodByStaff(string userName, int typeCourt)
        {
            string query = "INSERT dbo.OrderFood( DateOrder ,DatePay ,UserName , TypeAcourt ,StatusOrder,StatusPay ) VALUES  ( GETDATE() , GETDATE() , N'" + userName + "', " + typeCourt.ToString() + " , 1 ,0  ) ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public void OrderFoodByUser(int id, int typeCourt)
        {
            string query = " UPDATE dbo.OrderFood SET StatusOrder=1 WHERE id= " + id.ToString() +" and TypeAcourt= "+typeCourt.ToString();
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void CompleteOrderByStaff(int idOrder)
        {
            string query1 = "UPDATE dbo.OrderFood SET StatusPay=1 WHERE id = " + idOrder.ToString();
            DataProvider.Instance.ExecuteNonQuery(query1);
            string query2= "UPDATE dbo.OrderFood SET StatusPay=1 WHERE id =" + idOrder.ToString();
            DataProvider.Instance.ExecuteNonQuery(query2);
        }

        public DataTable GetBillOrderByDate(DateTime dateOrder, DateTime datePay, int typeCourt)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListOrderByDate @checkIn , @checkOut , @typeCourt ", new object[] { dateOrder, datePay, typeCourt });
        }

        public void DeleteOrderInfoByID(int idFood)
        {
            string query1 = "SELECT * FROM dbo.OrderFoodInfo WHERE idFood=" + idFood.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query1);
            string query2 = "DELETE dbo.OrderFoodInfo WHERE idFood =" + idFood.ToString();
            DataProvider.Instance.ExecuteNonQuery(query2);
            foreach (DataRow item in data.Rows)
            {
                string query3 = "DELETE dbo.OrderFood WHERE id=" + item[1].ToString();
                DataProvider.Instance.ExecuteNonQuery(query3);
            }
           
        }
    }
}
