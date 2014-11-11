using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HolidayMailer;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void DatabaseTests()
        {
            DatabaseManager database = new DatabaseManager();
            List<Contact> contactList;

            //Contact List Populated
            contactList = database.retrieveContacts();
            Assert.IsNotNull(contactList);
            foreach (Contact contact in contactList)
            {
                Assert.IsNotNull(contact);
            }

        }
    }
}
