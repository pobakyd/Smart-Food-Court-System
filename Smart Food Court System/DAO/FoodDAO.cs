using SmartFoodCourtSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByIDFood(int id, int idCourt)
        {
            string query = " SELECT * FROM dbo.Food WHERE id = @id AND typeCourt = @typeCourt ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id, idCourt });
            List<Food> result = new List<Food>();
            foreach (DataRow item in data.Rows)
            {
                result.Add(new Food(item));
            }
            return result;
        }
        public List<Food> GetFoodByCategoryID(int id, int idCourt)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory = " + id + " and typeCourt = " + idCourt;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public int GetIDFoodByName(string foodName, int typeCourt)
        {
            string query = "SELECT id FROM dbo.Food WHERE name = @foodName AND typeCourt = @typeCourt ";
            return int.Parse(DataProvider.Instance.ExecuteScalar(query, new object[] { foodName, typeCourt }).ToString());
        }
        public Category GetCategoryByFoodID(int id)
        {
            Category result = null;
            string query = "SELECT * FROM Food AS F, dbo.FoodCategory AS FC WHERE F.id = @id AND F.idCategory = FC.id ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                result = new Category(item);
            }
            return result;
        }
        public int GetCourtByFoodID(int id)
        {
            string query = "SELECT typeCourt FROM dbo.Food WHERE id= " + id;
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public DataTable GetListFood(int typeCourt)
        {
            string query = " SELECT F.id as N'ID', F.name AS N'Tên món ăn', G.name AS N'Loại', F.price AS N'Đơn giá', F.food_detail AS N'Mô tả'  FROM food AS F, dbo.FoodCategory AS G WHERE typeCourt = @typeCourt AND F.idCategory=G.id " ;

           return  DataProvider.Instance.ExecuteQuery(query, new object[] { typeCourt});
        }

        public DataTable SearchFoodByName(string name, int typeCourt)
        {
            

            string query = string.Format("SELECT F.id as N'ID', F.name AS N'Tên món ăn', G.name AS N'Loại', F.price AS N'Đơn giá', F.food_detail AS N'Mô tả'  FROM food AS F, dbo.FoodCategory AS G WHERE typeCourt = {0} AND F.idCategory=G.id and dbo.fuConvertToUnsign1(F.name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + '%'", typeCourt ,name);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertFood(string name, int id, float price, int typeCourt,string foodDetail)
        {
            string query = string.Format("INSERT dbo.Food ( name, idCategory, price, typeCourt, food_detail )VALUES  ( N'{0}', {1}, {2},{3}, N'{4}')", name, id, price,typeCourt,foodDetail);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price, string foodDetail)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2}, food_detail = N'{3}' WHERE id = {4}", name, id, price, foodDetail,idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            OrderFoodDAO.Instance.DeleteOrderInfoByID(idFood);
            string query1 = string.Format("Delete Food where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }
    }
}
