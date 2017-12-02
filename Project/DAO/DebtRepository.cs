using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DebtRepository
    {
        private static DebtRepository instance;
        public static DebtRepository Instance
        {
            get { if (instance == null) instance = new DebtRepository(); return instance; }
            private set { instance = value; }
        }

        private DebtRepository() { }

        public DataTable LoadListDebt()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadListDebt");
        }

        public bool InsertDebt()
        {
            int result;
            result = DataProvider.Instance.ExecuteNonQuery("USP_InsertDebt ");
            return result > 0;
        }

        public Debt LoadDebtByID(int id)
        {
            Debt debt = new Debt();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadDebtByID @iD", new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                debt = new Debt(item);
            }

            return debt;
        }

        public DataTable GetIdDebtByIdStudent(int idStudent)
        {
            return DataProvider.Instance.ExecuteQuery("GetIdDebtByIdStudent @idStudent",
                new object[] {idStudent });
        }

        public bool UpdateMoneyWhenRegistrationByIDDebt(int idDebt, decimal money)
        {
            int result;
            result = DataProvider.Instance.ExecuteNonQuery("AddMoneyWhenRegistrationByIDDebt @idDebt , @money",
                new object[] {idDebt, money });
            return result > 0;
        }

    }
}
