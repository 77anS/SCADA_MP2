using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.User
{
    class Users
    {
        internal protected class _base
        {
            public string id { get; set; }
            public string fullName { get; set; }
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string address { get; set; }
            public string email { get; set; }
            public string[] phoneNumber { get; set; } = new string[5];

            public roles role { get; set; }
            public _base(string id, string username, string password, string address, string[] phoneNumner, roles role)
            {
                this.id = id;
                this.username = username;
                this.password = password;
                this.address = address;
                this.phoneNumber = phoneNumber;
                this.role = role;
            }

            public _base()
            {

            }
        }
        internal class Operators:_base
        {
            public Operators(): base()
            {
                this.role = roles.Operator;
            }
            
        }
        internal class Managers:_base
        {
            public Managers() : base()
            {
                this.role = roles.Manager;
            }
        }
        internal class Administrators:_base
        {
            public Administrators() : base()
            {
               this.role = roles.Administrator;
            }
        }
        internal class Guests:_base
        {
            public Guests() : base()
            {
                this.role = roles.Guest;
            }
        }

        public enum roles
        {
            Administrator = 0,
            Manager = 1,
            Supervisor = 2,
            Operator = 3,
            Guest = 4,
            Undefined = 5,
            Other = 6,
        }
    }
}
