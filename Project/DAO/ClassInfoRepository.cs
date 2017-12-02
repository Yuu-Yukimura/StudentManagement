using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClassInfoRepository
    {
        private static ClassInfoRepository instance;

        public static ClassInfoRepository Instance
        {
            get { if (instance == null) instance = new ClassInfoRepository(); return instance; } 
            private set { instance = value; }
        }

        private ClassInfoRepository() { }

        //Lấy list Class info
        public List<ClassInfo> GetListClassInfo()
        {
            List<ClassInfo> list = new List<ClassInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ClassInfo");

            foreach(DataRow item in data.Rows)
            {
                ClassInfo classInfo = new ClassInfo(item);
                list.Add(classInfo);
            }

            return list;
        }

        //Insert Class info
        public bool InsertClassInfo(ClassInfo classInfo)
        {
            int result;
            result = DataProvider.Instance.ExecuteNonQuery("USP_InsertClassInfo @idStudent , @idClass ", 
                new object[] {classInfo.IDStudent, classInfo.IDClass });
            return result > 0;
        }

        //Ktra xem đã có sinh viên đã trong lớp học chưa
        public bool CheckStudentInClass(ClassInfo classInfo)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_CheckStudentInClass @idStudent , @idClass ",
                new object[] { classInfo.IDStudent, classInfo.IDClass});
            return data.Rows.Count > 0;
        }

        //Delete Student ra khỏi lớp
        public bool DeleteClassInfo(int idStudent, int idClass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteStudentInClass @idStudent , @idClass",
                new object[] {idStudent, idClass });
            return result > 0; 
        }
    }
}
