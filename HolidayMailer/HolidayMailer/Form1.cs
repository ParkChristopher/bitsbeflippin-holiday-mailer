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

            //Set available controls here
        }

        private void loadContacts()
        {
            DatabaseManager database = new DatabaseManager();
            List<Contact> contactList;
            
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

    }
}
