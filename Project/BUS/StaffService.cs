using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class StaffService
    {
        private static StaffService instance;

        public static StaffService Instance
        {
            get { if (instance == null) instance = new StaffService(); return instance; }
            private set { instance = value; }
        }

        StaffService() { }

        // Lấy list staff từ DAO
        public List<Staff> GetListStaff()
        {
            return StaffRepository.Instance.LoadStaffList();
        }


        // Lấy thông tin nhân viên qua id từ DAO
        public Staff GetStaffById(int id)
        {
            return StaffRepository.Instance.LoadStaffById(id);
        }

        // Sửa thông tin nhân viên
        public Boolean EditStaffById(Staff staff)
        {
            return StaffRepository.Instance.UpdateStaffById(staff);
        }


    }
}
