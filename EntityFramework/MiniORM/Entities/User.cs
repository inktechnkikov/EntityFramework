using MiniORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.Entities
{
    [Entity(TableName = "Users")]

    class User
    {
        [Id]
        private int id;
        [Column(ColumnName = "Username")]
        private string username;

        [Column(ColumnName = "Age")]
        private string age;

        [Column(ColumnName = "Password")];
        private string password;

        [Column(ColumnName = "Registration Date")]
        private DateTime registrationDateTime;

        public User(string username,string password, string age, DateTime registrationDateTime)
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.RegistrationDateTime = registrationDateTime;
        }
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }
        public string Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public DateTime RegistrationDateTime
        {
            get
            {
                return this.registrationDateTime;
            }
            set
            {
                this.registrationDateTime = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
    }
}
