using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{
    public abstract class Entity
    {
        protected string lastName, firstName, email;

        public Entity(string lastName, string firstName, string email)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
