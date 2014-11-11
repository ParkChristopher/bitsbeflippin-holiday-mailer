using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{

    public class User : Entity 
    {
        private string password;

        public User(string lastName, string firstName,
            string email) : base(lastName, firstName, email)
        {
        }

        public User(string lastName, string firstName,
            string email, string password)
            : base(lastName, firstName, email)
        {
            this.password = password;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
