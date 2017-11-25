using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string UserName { set; get; }
        public string PassWord { set; get; }
        public int IDStaff { set; get; }

        public Account() { }

        public Account(string userName, string passWord)
        {
            this.UserName = userName;
            this.PassWord = passWord;
        }

        public Account(string userName, string passWord, int iDStaff)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.IDStaff = iDStaff;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.IDStaff = (int)row["iDStaff"];
        }

        
    }
}
