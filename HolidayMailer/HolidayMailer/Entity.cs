using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{
    public abstract class Entity
    {
        protected string _lastName, _firstName, _email;
        protected bool _sentPrevious;

        public Entity(string lastName, string firstName, string email)
        {
            _lastName = lastName;
            _firstName = firstName;
            _email = email;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
