using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public decimal Money { set; get; }

        public Subject() { }

        public Subject(int id, string name, decimal money)
        {
            this.ID = id;
            this.Name = name;
            this.Money = money;
        }

        public Subject(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        public Subject(DataRow data)
        {
            this.ID = (int)data["iD"];
            this.Name = data["name"].ToString();
            this.Money = (decimal)data["money"];
        }

    }
}
