using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Debt
    {
        public int ID { get; set; }
        public Decimal SumOfDebt { get; set; }
        public int IDStudent { get; set; }

        public Debt() { }

        public Debt (int id, Decimal sumOfDebt, int idStudent)
        {
            this.ID = id;
            this.SumOfDebt = sumOfDebt;
            this.IDStudent = idStudent;
        }

        public Debt(Decimal sumOfDebt, int idStudent)
        {

            this.SumOfDebt = sumOfDebt;
            this.IDStudent = idStudent;
        }

        
        public Debt(DataRow row)
        {
            this.ID = (int)row["id"];
            this.SumOfDebt = (Decimal)row["SumOfDebt"];
            this.IDStudent = (int)row["idStudent"];
        }

    }
}
