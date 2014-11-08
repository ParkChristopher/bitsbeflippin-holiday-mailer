using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{
    class Contact : Entity
    {
        
        
        private bool _sentPrevious;

        public Contact(string lastName, string firstName,
            string email, bool sentPrevious) : base(lastName, firstName, email)
        {
            _sentPrevious = sentPrevious;
        }

        public bool SentPrevious
        {
            get { return _sentPrevious; }
            set { _sentPrevious = value; }
        }
    }
}