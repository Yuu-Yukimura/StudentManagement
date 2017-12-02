using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DebtInfo
    {
        public int ID { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public int IDDebt { get; set; }

        public DebtInfo() { }

        public DebtInfo(int id, decimal money, DateTime date, int idDebt) 
        {
            this.ID = id;
            this.Money = money;
            this.Date = date;
            this.IDDebt = idDebt;
        }

        public DebtInfo(decimal money, DateTime date, int idDebt)
        {
            this.Money = money;
            this.Date = date;
            this.IDDebt = idDebt;
        }

        public DebtInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Money = (decimal)row["money"];
            this.Date = (DateTime)row["date"];
        }

    }
}
