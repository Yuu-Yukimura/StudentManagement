using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance {
            get { if (instance == null) instance = new StudentDAO(); return instance; }
            private set { instance = value; }
        }

        private StudentDAO() { }

        //Hàm lấy tất cả thông tin sinh viên từ csdl
        public DataTable LoadStudent()
        {
            string query = "SELECT ID,Name FROM dbo.Student ";

            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
