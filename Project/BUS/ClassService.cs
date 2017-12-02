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
    public class ClassService
    {
        private static ClassService instance;

        public static ClassService Instance
        {
            get { if (instance == null) instance = new ClassService(); return instance; }
            private set { instance = value; }
        }

        public ClassService() { }

        public List<Class> GetListClass()
        {
            return ClassRepository.Instance.LoadListClass();
        }

        public bool AddClass(Class cl)
        {
            if (cl.DateStart < DateTime.Now)
                cl.Status = "Đang mở";
            else if (cl.DateStart > DateTime.Now)
                cl.Status = "Vào học";
            else if (DateTime.Now > cl.DateEnd)
                cl.Status = "Kết thúc";

            return ClassRepository.Instance.InsertClass(cl);
        }

        public DataTable GetSubjectStaffNameByClass()
        {
            return ClassRepository.Instance.LoadSubjectStaffNameByClass();
        }

        public DataTable GetIDNameClass()
        {
            return ClassRepository.Instance.LoadIDNameClassWhenStatusIsReady();
        }

        public List<Class> GetListClassByStatus(string status)
        {
            return ClassRepository.Instance.LoadListClassByStatus(status);
        }

        public DataTable GetListClassStudentRegistration(int idStudent)
        {
            return ClassRepository.Instance.LoadClassStudentRegistration(idStudent);
        }

    }
}
