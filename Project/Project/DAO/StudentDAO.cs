using Project.DTO;
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
        public List<Student> LoadStudentList()
        {
            List<Student> studentList = new List<Student>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadStudentList");

            foreach(DataRow item in data.Rows)
            {
                Student student = new Student(item);
                studentList.Add(student);
            }

            return studentList;
        }

        //Hàm chỉ lấy Id và Name sinh viên từ csdl
        public DataTable Load_ID_Name_Student()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ID, Name FROM dbo.Student");
        }

        //Hàm chỉ lấy sinh viên theo id
        public DataTable LoadStudentById(int id)
        {
            return DataProvider.Instance.ExecuteQuery("USP_ViewStudentByID @iD", new object[] {id });
        }

        //Hàm chỉnh sửa thông tin sinh viên theo id
        public DataTable EditStudentById(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, string parentPhone)
        {
            return DataProvider.Instance.ExecuteQuery("USP_EditStudentByID @iD , @Name , @Avatar , @Sex , @DateOfBirth , @Address , @Phone , @ParentPhone ", 
                                                            new object[] {id, name, null, sex, dateOfBirth, address, phone, parentPhone });
        }

    }
}
