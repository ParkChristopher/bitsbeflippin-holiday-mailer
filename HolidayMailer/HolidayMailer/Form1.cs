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
            contactList = database.retrieveContacts();
            
            foreach (Contact contact in contactList)
                dataGridViewContactList.Rows.Add(contact.FirstName, contact.LastName,
                    contact.Email, contact.SentPrevious);
        }

        private void clearContacts()
        {
            dataGridViewContactList.Rows.Clear();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Holiday Mailer\n\n" +
                "Team: Bits Be Flippin\'\n\n" +
                "Members:\n" +
                "Sami Awwad\n" +
                "Chris Park\n" +
                "Nathan Pilgrim\n\n" +
                "Version: 1", "About the Developers", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to " +
                             "delete the selected contact(s)";
            string caption = "Confirmation";
            DialogResult res; 

            res = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Exclamation);

            if (res == DialogResult.OK)
            {
                string delContact = "";
                DatabaseManager database = new DatabaseManager();

                foreach (DataGridViewRow row in dataGridViewContactList.SelectedRows)
                {
                    delContact = row.Cells[2].Value.ToString();
                    database.delete(delContact);
                }

                message = "Contact(s) Deleted";
                MessageBox.Show(message, "", MessageBoxButtons.OK);
                clearContacts();
                loadContacts();
            }

        }
    }
}
