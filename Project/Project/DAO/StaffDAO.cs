using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }

        private StaffDAO() { }

        //Hàm lấy tất cả thông tin nhân viên từ csdl
        public DataTable LoadStaff()
        {
            string query = "SELECT ID,Name FROM dbo.Staff ";

            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
