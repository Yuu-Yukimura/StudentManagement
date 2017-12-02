using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ClassInfoService
    {
        private static ClassInfoService instance;

        public static ClassInfoService Instance
        {
            get { if (instance == null) instance = new ClassInfoService(); return instance; }
            private set { instance = value; }
        }

        private ClassInfoService() { }

        //Thêm Class Info
        public bool AddClassInfo(ClassInfo classInfo)
        {
            if (ClassInfoRepository.Instance.CheckStudentInClass(classInfo))
                return false;
            else
                return ClassInfoRepository.Instance.InsertClassInfo(classInfo);
        }

        //Xóa Class Info
        public bool DeleteClassInfo(int idStudent, int idClass)
        {
            return ClassInfoRepository.Instance.DeleteClassInfo(idStudent, idClass);      
        }

    }
}
