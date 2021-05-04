using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DTO
{
 //   id INT IDENTITY PRIMARY KEY,
	//idOrderFood INT NOT NULL,
 //   idFood INT NOT NULL,
	//amount INT NOT NULL DEFAULT 0,
	//userMess NVARCHAR(500),
    public class OrderFoodInfo
    {
        private int iD;
        private int idOrderFood;
        private int idFood;
        private int amount;
        private string userMess;

        public OrderFoodInfo(int id, int idOrderFood, int idFood, int amount, string userMess)
        {
            this.ID = id;
            this.IdOrderFood = idOrderFood;
            this.IdFood = idFood;
            this.Amount = amount;
            this.UserMess = userMess;
        }

        public OrderFoodInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdOrderFood = (int)row["idOrderFood"];
            this.IdFood = (int)row["idFood"];
            this.Amount = (int)row["amount"];
            this.UserMess = row["userMess"].ToString();
        }


        public int ID { get => iD; set => iD = value; }
        public int IdOrderFood { get => idOrderFood; set => idOrderFood = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Amount { get => amount; set => amount = value; }
        public string UserMess { get => userMess; set => userMess = value; }
    }
}
