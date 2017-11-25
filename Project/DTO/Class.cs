using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int IDSubject { get; set; }
        public int IDStaff { get; set; }

        public Class() { }

        public Class(int id, string name, string status, DateTime dateStart, DateTime dateEnd, int idSubject, int idStaff)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.IDSubject = idSubject;
            this.IDStaff = idStaff;
        }

        public Class(string name, string status, DateTime dateStart, DateTime dateEnd, int idSubject, int idStaff)
        {
            this.Name = name;
            this.Status = status;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.IDSubject = idSubject;
            this.IDStaff = idStaff;
        }

        public Class(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
            this.DateStart = (DateTime)row["dateStart"];
            this.DateEnd = (DateTime)row["dateEnd"];
            this.IDSubject = (int)row["idSubject"];
            this.IDStaff = (int)row["idStaff"];
        }

    }
}
