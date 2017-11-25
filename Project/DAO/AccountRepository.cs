using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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

        // Kiểm tra đẳng nhập
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result  = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord});
         
            return result.Rows.Count > 0;
        }

        // Lấy toàn bộ 
        public DataTable GetAllAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account");
        }

        // thêm tài khoản vào csdl
        public bool InsertAccount(Account account)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertAccount @userName , @passWord ",
                                new object[] { account.UserName, account.PassWord });
            return result > 0;
        }

        // Xóa 1 tài khoản 
        public bool DeleteAccount(int idStaff)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteAccount @id", new object[] { idStaff });
            return result > 0;
        }


    }
}
