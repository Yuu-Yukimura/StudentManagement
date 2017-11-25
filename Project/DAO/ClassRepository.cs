using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClassRepository
    {
        private static ClassRepository instance;

        public static ClassRepository Instance
        {
            get { if (instance == null) instance = new ClassRepository(); return instance; }
            private set { instance = value; }
        }

        private ClassRepository() { }

        public List<Class> LoadListClass()
        {
            List<Class> listClass = new List<Class>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadListClass");

            foreach (DataRow item in data.Rows)
            {
                Class classStudent = new Class(item);
                listClass.Add(classStudent);
            }

            return listClass;
        }

        public bool InsertClass(Class cl)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertClass @name , @status , @dateStart , @dateEnd , @idSubject , @idStaff ",
                new object[] { cl.Name, cl.Status, cl.DateStart, cl.DateEnd, cl.IDSubject, cl.IDStaff});
            return result > 0;
        }

        public DataTable LoadSubjectStaffNameByClass()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadSubjectStaffNameByClass");
        }

    }
}
