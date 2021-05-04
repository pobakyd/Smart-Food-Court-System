﻿using SmartFoodCourtSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord, int typeCourt, int typeAccount)
        {
            string query = "USP_Login @userName , @passWord , @typeCourt , @typeAccount";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord, typeCourt, typeAccount });

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }

        public DataTable GetListAccount(int typeCourt)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, TypeCourt, TypeAccount FROM dbo.Account where TypeCourt = @typeCourt or TypeCourt = 0", new object[] {typeCourt });
        }

        public int GetAccountExist(string userName)
        {
            return int.Parse(DataProvider.Instance.ExecuteScalar("Select count(*) from account where userName = '" + userName + "'").ToString());
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool InsertAccountDefault(string name, string displayName, int typeCourt, int typeAccount)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, TypeCourt, typeAccount )VALUES  ( N'{0}', N'{1}', {2}, {3})", name, displayName, typeCourt, typeAccount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertNewAccount(string name, string displayName,string passWord, int typeCourt, int typeAccount)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName,PassWord, TypeCourt, typeAccount )VALUES  ( N'{0}', N'{1}', N'{2}', {3}, {4})", name, displayName,passWord, typeCourt, typeAccount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string name, string displayName, int typeCourt, int typeAccount)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', TypeCourt = {2} , TypeAccount = {3} WHERE UserName = N'{0}'", name, displayName, typeCourt, typeAccount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("update account set password = N'0' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
