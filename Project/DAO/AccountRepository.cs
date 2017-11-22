using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountRepository
    {
        private static AccountRepository instance;

        public static AccountRepository Instance
        {
            get { if (instance == null) instance = new AccountRepository();  return instance; }
            private set { instance = value; }
        }

        private AccountRepository() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result  = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord});
         
            return result.Rows.Count > 0;
        }

    }
}
