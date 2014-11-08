﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{

    public class User : Entity 
    {
        private string _password;

        public User(string lastName, string firstName,
            string email) : base(lastName, firstName, email)
        {
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
