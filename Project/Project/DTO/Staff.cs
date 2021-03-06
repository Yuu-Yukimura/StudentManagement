﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Avatar { get; set; }
        public Boolean Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Boolean MaritalStatus { get; set; }
        public Boolean Type { get; set; }
        public Boolean Admin { get; set; }

        public Staff() { }

        public Staff(int id)
        {
            this.ID = id;
        }

        public Staff(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public Staff(int id, string name, byte[] avatar) : this(id, name)
        {
            this.Avatar = avatar;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex) : this(id, name, avatar)
        {
            this.Sex = sex;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth) : this(id, name, avatar, sex)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address) : this(id, name, avatar, sex, dateOfBirth)
        {
            this.Address = address;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone) : this(id, name, avatar, sex, dateOfBirth, address)
        {
            this.Phone = phone;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, Boolean maritalStatus) : this(id, name, avatar, sex, dateOfBirth, address, phone)
        {
            this.MaritalStatus = maritalStatus;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, Boolean maritalStatus, Boolean type) : this(id, name, avatar, sex, dateOfBirth, address, phone, maritalStatus)
        {
            this.Type = type;
        }

        public Staff(int id, string name, byte[] avatar, Boolean sex, DateTime dateOfBirth, string address, string phone, Boolean maritalStatus, Boolean type, Boolean admin) : this(id, name, avatar, sex, dateOfBirth, address, phone, maritalStatus, type)
        {
            this.Admin = admin;
        }

    }
}
