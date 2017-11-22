using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        private static StudentService instance;

        public static StudentService Instance
        {
            get { if (instance == null) instance = new StudentService(); return instance; }
            private set { instance = value; }
        }

        private StudentService() { }

        //Lấy thông tin sinh viên từ tầng DAO lên tầng DTO
        public List<Student> GetStudentList()
        {
            return StudentRepository.Instance.LoadStudentList();
        }

        //Lấy thông tin sinh viên qua id từ tầng DAO lên tầng DTO
        public Student GetStudentByID(int id)
        {
            return StudentRepository.Instance.LoadStudentById(id);
        }

        //Chỉnh sửa thông tin sinh viên
        public bool EditStudentByID(Student student)
        {
            return StudentRepository.Instance.UpdateStudentById(student);
        }

        //Thêm sinh viên
        public bool AddStudent(string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, string parentPhone)
        {
            return StudentRepository.Instance.InsertStudent(name, avatar, sex, dateOfBirth, address, phone, parentPhone);
        }

        //Xóa sinh viên
        public bool DeleteStudent(int id)
        {
            return StudentRepository.Instance.DeleteStudent(id);
        }
    }
}
