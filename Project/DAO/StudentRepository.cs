using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class StudentRepository
    {
        private static StudentRepository instance;

        public static StudentRepository Instance {
            get { if (instance == null) instance = new StudentRepository(); return instance; }
            private set { instance = value; }
        }

        private StudentRepository() { }

        //Hàm lấy tất cả thông tin sinh viên từ csdl và trả ra một list
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

        //Hàm chỉ lấy sinh viên theo id và trả ra Student
        public Student LoadStudentById(int id)
        {
            Student student = new Student();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_ViewStudentByID @iD", new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                student = new Student(item);
            }

            return student;
        }

        //Hàm chỉnh sửa thông tin sinh viên theo id
        public bool UpdateStudentById(Student student)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_EditStudentByID @iD , @Name , @Avatar , @Sex , @DateOfBirth , @Address , @Phone , @ParentPhone ", 
                                                            new object[] {student.ID, student.Name, student.Avatar, student.Sex, student.DateOfBirth, student.DateOfBirth, student.Phone, student.ParentPhone });
            return result > 0;
        }

        //Hàm thêm một sinh viên vào csdl
        public bool InsertStudent(Student student)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertStudent @Name , @Avatar , @Sex , @DateOfBirth , @Address , @Phone , @ParentPhone ", new object[] {student.Name, student.Avatar, student.Sex, student.DateOfBirth, student.Address, student.Phone, student.ParentPhone});

            return result > 0;
        }

        //Hàm xóa một sinh trong csdl
        public bool DeleteStudent(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.Student WHERE ID = " + id);

            return result > 0;
        }

        //Hàm lấy id và tên sinh viên trong csdl
        public DataTable LoadIDNameStudent()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ID AS [Mã], Name AS [Tên] FROM Student");
        }

        //Hàm lấy id và tên sinh viên trong lớp qua idclass
        public DataTable LoadIDNameStudentInClassByIDClass(int idClass)
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadStudentInClassByIDClass @idClass", 
                new object[] {idClass });
        }

    }
}
