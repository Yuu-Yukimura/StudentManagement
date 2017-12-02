using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DebtInfoRepository
    {
        private static DebtInfoRepository instance;
        public static DebtInfoRepository Instance
        {
            get { if (instance == null) instance = new DebtInfoRepository(); return instance; }
            private set { instance = value; }
        }

        private DebtInfoRepository() { }

        public DataTable LoadListDebtInfoByID(int idDebt)
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadListDebtInfoByID @idDebt", 
                new object[] {idDebt });
        }

        public bool InsertDebtInfo(DebtInfo debtInfo)
        {
            int result;
            result = DataProvider.Instance.ExecuteNonQuery("USP_InsertDebtInfo @idDebt , @money , @date",
                new object[] {debtInfo.IDDebt, debtInfo.Money, debtInfo.Date });
            return result > 0;
        }

    }

}
