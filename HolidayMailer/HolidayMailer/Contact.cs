using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{
    public class Contact : Entity
    {
        private bool sentPrevious;

        public Contact(string lastName, string firstName,
            string email, bool sentPrevious) : base(lastName, firstName, email)
        {
            this.sentPrevious = sentPrevious;
        }

        public bool SentPrevious
        {
            get { return sentPrevious; }
            set { sentPrevious = value; }
        }
    }
}