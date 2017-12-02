using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassInfo
    {
        public int ID { get; set; }
        public int IDClass { get; set; }
        public int IDStudent { get; set; }

        public ClassInfo(int id, int idClass, int idStudent)
        {
            this.ID = id;
            this.IDClass = idClass;
            this.IDStudent = idStudent;
        }

        public ClassInfo(int idClass, int idStudent)
        {
            this.IDClass = idClass;
            this.IDStudent = idStudent;
        }

        public ClassInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDClass = (int)row["IDClass"];
            this.IDStudent = (int)row["IDStudent"];
        }

    }
}
