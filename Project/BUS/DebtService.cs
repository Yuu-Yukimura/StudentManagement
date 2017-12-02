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
    public class DebtService
    {
        private static DebtService instance;
        public static DebtService Instance
        {
            get { if (instance == null) instance = new DebtService(); return instance; }
            private set { instance = value; }
        }

        private DebtService() { }

        public DataTable GetListDebt()
        {
            return DebtRepository.Instance.LoadListDebt();
        }

        public bool AddDebt()
        {
            return DebtRepository.Instance.InsertDebt();
        }

        public Debt GetDebtByID(int id)
        {
            return DebtRepository.Instance.LoadDebtByID(id);
        }

        public DataTable GetIdDebtByIdStudent(int idStudent)
        {
            return DebtRepository.Instance.GetIdDebtByIdStudent(idStudent);
        }

    }
}
