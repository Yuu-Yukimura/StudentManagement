using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StaffRepository
    {
        private static StaffRepository instance;

        public static StaffRepository Instance
        {
            get { if (instance == null) instance = new StaffRepository(); return instance; }
            private set { instance = value; }
        }

        private StaffRepository() { }

        //Hàm lấy tất cả thông tin nhân viên từ csdl
        public List<Staff> LoadStaffList()
        {
            List<Staff> listStaff = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LoadStaffList");

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                listStaff.Add(staff);
            }

            return listStaff;
        }

        //Hàm lấy thông tin nhân viên qua id
        public Staff LoadStaffById(int id)
        {
            Staff staff = new Staff();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetStaffById @Id", new object[] { id });

            foreach (DataRow item in data.Rows)
                staff = new Staff(item);

            return staff;
        }

        //Hàm sửa thông tin nhân viền từ csdl
        public bool UpdateStaffById(Staff staff)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateStaffById @iD , @name , @avatar , @sex , @dateOfBirth , @address , @phone , @maritalStatus , @type , @admin",
                new object[] { staff.ID, staff.Name, staff.Avatar, staff.Sex, staff.DateOfBirth, staff.Address, staff.Phone, staff.MaritalStatus, staff.Type, staff.Admin });
            return result > 0;
        }

        //Hàm thêm nhân viên vào csdl
        public bool InsertStaff(Staff staff)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertStaff @name , @avatar , @sex , @dateOfBirth , @address , @phone , @maritalStatus , @type , @admin", 
                new object[] {staff.Name, staff.Avatar, staff.Sex, staff.DateOfBirth, staff.Address, staff.Phone, staff.MaritalStatus, staff.Type, staff.Admin });
            return result > 0;
        }

        //Xóa 1 nhân viên 
        public bool DeleteStaff(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteStaff @id", new object[] { id});
            return result > 0;
        }

    }
}
