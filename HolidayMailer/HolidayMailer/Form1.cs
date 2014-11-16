using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayMailer
{
    public partial class Form1 : Form
    {
        NetworkManager mailer;
        List<Contact> contactList;
        User currentUser;

        public Form1()
        {
            InitializeComponent();
            loadContacts();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            FormAddContact addContact = new FormAddContact();
            addContact.Owner = this;
            addContact.ShowDialog();
            clearContacts();
            loadContacts();
            //Set available controls here
        }

        private void loadContacts()
        {
            DatabaseManager database = new DatabaseManager();
            //List<Contact> contactList;//moved this to be class wide as I need access to it in another control
            
            contactList = database.retrieveContacts();

            ListViewItem row;
            foreach (Contact contact in contactList)
            { 
                row = new ListViewItem(contact.FirstName);
                row.SubItems.Add(contact.LastName);
                row.SubItems.Add(contact.Email);

                listViewContacts.Items.Add(row);
            }
            
        }

        private void clearContacts()
        {
            listViewContacts.Items.Clear();
        }

        private void toolstripMainSender_Click(object sender, EventArgs e)
        {
            initUser();
        }

        private void initUser()
        {
            User newUser = new User();
            userForm userForm = new userForm(newUser);
            userForm.ShowDialog();

            //currentUser = userForm.User;

            newUser = userForm.User;

            if (newUser == null)
                MessageBox.Show("User was not initialized correctly.");

            else
                currentUser = newUser;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendEmails();
        }

        private void sendEmails()
        {
            if (currentUser.EmailService == "Gmail")
                mailer = new GmailManager(currentUser, contactList, "Some Subject", "Some body");

            if (currentUser.EmailService == "Hotmail")
                mailer = new HotmailManager(currentUser, contactList, "Some Subject", "Some body");

            if (currentUser.EmailService == "Yahoo")
                mailer = new YahooManager(currentUser, contactList, "Some Subject", "Some body");

            if (mailer != null)
                mailer.send();
        }
    }
}
