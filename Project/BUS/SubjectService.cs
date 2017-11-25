using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class SubjectService
    {
        private static SubjectService instance;

        public static SubjectService Instance
        {
            get { if (instance == null) instance = new SubjectService(); return instance; }
            private set { instance = value; }
        }

        private SubjectService() { }

        // Lấy list subject
        public List<Subject> GetListSubject()
        {
            return SubjectRepository.Instance.LoadSubjectList();
        }

        // Sửa 1 môn học
        public bool EditSubjectById(Subject subject)
        {
            return SubjectRepository.Instance.UpdateSubjectById(subject);
        }

        // Thêm 1 môn học
        public bool AddSubject(Subject subject)
        {
            return SubjectRepository.Instance.InsertSubject(subject);
        }

        // Ktra tên môn học có trùng hay ko ?
        public bool CheckNameSubject(string nameSubject)
        {
            List<Subject> list = SubjectRepository.Instance.LoadSubjectList();
            foreach(Subject item in list)
            {
                if (nameSubject == item.Name)
                    return false;
            }
            return true;
        }

    }
}
