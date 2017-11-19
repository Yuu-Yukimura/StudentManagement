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
        private int iD;
        private string name;
        private byte[] avatar;
        private Boolean sex;
        private DateTime dateOfBirth;
        private string address;
        private string phone;
        private string parentPhone;

        #region Set and Get

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
        public Boolean Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string ParentPhone { get => parentPhone; set => parentPhone = value; }

        #endregion

        #region Constructor

        public Student(int id, string name, byte[] avatar , Boolean sex, DateTime dateOfBirth, string address, string phone, string parentPhone)
        {
            this.iD = id;
            this.name = name;
            this.avatar = avatar;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
            this.parentPhone = parentPhone;
        }

        public Student (int id, string name, Boolean sex, DateTime dateOfBirth, string address, string phone, string parentPhone)
        {
            this.iD = id;
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
            this.parentPhone = parentPhone;
        }

        public Student(int id, string name, Boolean sex, DateTime dateOfBirth, string address)
        {
            this.iD = id;
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }

        public Student(int id, string name, Boolean sex, DateTime dateOfBirth, string address, string phone)
        {
            this.iD = id;
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
        }

        public Student(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            //this.avatar = (byte[])row["avatar"];
            this.sex = (Boolean)row["sex"];
            this.dateOfBirth = (DateTime)row["dateOfBirth"];
            this.address = row["address"].ToString();
            this.phone = row["phone"].ToString();
            this.parentPhone = row["parentPhone"].ToString();
        }

        #endregion
    }
}
