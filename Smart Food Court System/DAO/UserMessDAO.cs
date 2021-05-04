using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DAO
{
    public class UserMessDAO
    {
        private static UserMessDAO instance;

        public static UserMessDAO Instance
        {
            get { if (instance == null) instance = new UserMessDAO(); return UserMessDAO.instance; }
            private set { UserMessDAO.instance = value; }
        }

        private UserMessDAO() { }

        public int GetAmountUserMess(string userName)
        {
            string query = "SELECT COUNT(*) FROM UserMess WHERE UserName = N'" + userName +"' and status=0";
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public bool SendMess(string userName, string mess)
        {
            string query = " INSERT dbo.UserMess ( UserName, Status, Mess ) VALUES  ( N'" + userName + "' , 0 , N'" + mess + "' )";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetUserMess(string userName)
        {
            string query1 = "SELECT id,Mess FROM dbo.UserMess WHERE UserName = N'" + userName +"' and status=0";
            DataTable data=DataProvider.Instance.ExecuteQuery(query1);
            DataRow row = data.Rows[data.Rows.Count-1];
            int idMess = int.Parse(row[0].ToString());
            string query2 = "UPDATE UserMess SET Status=1 WHERE id = " + idMess.ToString();
            DataProvider.Instance.ExecuteNonQuery(query2);
            return row[1].ToString();
        }
    }
}
