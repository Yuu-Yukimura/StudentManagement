using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class AccountService
    {
        private static AccountService instance;

        public static AccountService Instance
        {
            get { if (instance == null) instance = new AccountService(); return instance; }
            private set { instance = value; }
        }

        private AccountService() { }

        //Ktra đẳng nhập
        public bool Login(string userName, string passWord)
        {
            return AccountRepository.Instance.Login(userName, passWord);
        }

        //Thêm account vào csdl
        public bool AddAccount(Account account)
        {
            return AccountRepository.Instance.InsertAccount(account);
        }

        // Ktr tên đẳng nhập có trùng hay ko ?
        public bool CheckUserNameIsOnly(string userName)
        {
            DataTable data = AccountRepository.Instance.GetAllAccount();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (userName == data.Rows[i]["userName"].ToString())
                    return false;
            }
            return true;
        }

    }
}
