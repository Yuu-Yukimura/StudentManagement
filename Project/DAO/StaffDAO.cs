using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }

        private StaffDAO() { }

        //Hàm lấy tất cả thông tin nhân viên từ csdl
        /*public List<Staff> LoadStaffList()
        {
            List<Staff> listStaff = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadStaffList");

            foreach(DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                listStaff.Add(staff);
            }

            return listStaff;
        }*/

        //Hàm chỉ lấy Id và Name nhân viên từ csdl
        public DataTable Load_ID_Name_Staff()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ID, Name FROM dbo.Staff");
        }

    }
}
