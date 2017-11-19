using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    class Staff
    {
        private int iD;
        private string name;
        private byte[] avatar;
        private Boolean sex;
        private DateTime dateOfBirth;
        private string address;
        private string phone;
        private Boolean maritalStatus;
        private Boolean type;
        private Boolean admin;

        #region Set and Get

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
        public bool Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public bool Type { get => type; set => type = value; }
        public bool Admin { get => admin; set => admin = value; }

        #endregion

        #region Construstor

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, Boolean maritalStatus, Boolean type, Boolean admin)
        {
            this.iD = id;
            this.name = name;
            this.avatar = avatar;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
            this.maritalStatus = maritalStatus;
            this.type = type;
            this.admin = admin;
        }

        public Staff(int id, string name, Boolean sex, DateTime dateOfBirth, string address, string phone, Boolean maritalStatus, Boolean type, Boolean admin)
        {
            this.iD = id;
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
            this.maritalStatus = maritalStatus;
            this.type = type;
            this.admin = admin;
        }

        public Staff(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            //this.avatar = (byte[])row["avatar"];
            this.sex = (Boolean)row["sex"];
            this.dateOfBirth = (DateTime)row["dateOfBirth"];
            this.address = row["address"].ToString();
            this.phone = row["phone"].ToString();
            this.maritalStatus = (Boolean)row["maritalStatus"];
            this.type = (Boolean)row["type"];
            this.admin = (Boolean)row["administrator"];
        }

        #endregion

    }
}
