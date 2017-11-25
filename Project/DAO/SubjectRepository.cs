using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SubjectRepository
    {
        private static SubjectRepository instance;

        public static SubjectRepository Instance
        {
            get { if (instance == null) instance = new SubjectRepository(); return instance; }
            private set { instance = value; }
        }

        private SubjectRepository() { }

        //Lấy toàn bộ thông tin môn học và trả về một list
        public List<Subject> LoadSubjectList()
        {
            List<Subject> subjectList = new List<Subject>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadListSubject");

            foreach(DataRow item in data.Rows)
            {
                Subject subject = new Subject(item);
                subjectList.Add(subject);
            }

            return subjectList;
        }


        //Sửa một môn học
        public bool UpdateSubjectById(Subject subject)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateSubjectById @id , @name , @money", 
                new object[] {subject.ID, subject.Name, subject.Money });
            return result > 0;
        }

        //Thêm môn học
        public bool InsertSubject(Subject subject)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertSubject @name , @money",
                new object[] {subject.Name, subject.Money });
            return result > 0;
        }

    }
}
