using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Avatar { get; set; }
        public Boolean Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ParentPhone { get; set; }
       
        public Student() { }

        public Student(int id)
        {
            this.ID = id;
        }

        public Student(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public Student(int id, string name, byte[] avatar) : this(id, name)
        {
            this.Avatar = avatar;
        }

        public Student(int id, string name, byte[] avatar, Boolean sex) : this(id, name, avatar)
        {
            this.Sex = sex;
        }

        public Student(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth) : this(id, name, avatar, sex)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public Student(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address) : this(id, name, avatar, sex, dateOfBirth)
        {
            this.Address = address;
        }

        public Student(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone) : this(id, name, avatar, sex, dateOfBirth, address)
        {
            this.Phone = phone;
        }

        public Student(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, string parentPhone) : this(id, name, avatar, sex, dateOfBirth, address, phone)
        {
            this.ParentPhone = parentPhone;
        }

    }
}
