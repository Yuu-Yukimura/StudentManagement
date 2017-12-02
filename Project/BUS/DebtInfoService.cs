using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class DebtInfoService
    {
        private static DebtInfoService instance;
        public static DebtInfoService Instance
        {
            get { if (instance == null) instance = new DebtInfoService(); return instance; }
            private set { instance = value; }
        }

        private DebtInfoService() { }

        public DataTable GetListDebtInfo(int idDebt)
        {
            return DebtInfoRepository.Instance.LoadListDebtInfoByID(idDebt);
        }

        public bool AddDebtInfo(DebtInfo debtInfo)
        {
            DebtRepository.Instance.UpdateMoneyWhenRegistrationByIDDebt(debtInfo.IDDebt, debtInfo.Money);
            return DebtInfoRepository.Instance.InsertDebtInfo(debtInfo);
        }

    }
}
