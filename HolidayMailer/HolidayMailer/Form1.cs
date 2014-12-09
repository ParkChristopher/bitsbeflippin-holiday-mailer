using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HolidayMailer
{
    public partial class Form1 : Form
    {
        NetworkManager mailer;
        List<Contact> contactList;
        User currentUser;
        string[] files;

        public Form1()
        {
            InitializeComponent();
            loadContacts();

            comboBoxTemplate.SelectedIndex = 0;
            buttonRemove.Enabled = false;

            //sets up a dummy user
            currentUser = new User("Burgundy", "Ron", "imnotevenmad@gmail.com", "***");
            currentUser.EmailService = "Gmail";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {}

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            FormAddContact addContact = new FormAddContact();
            addContact.Owner = this;
            addContact.ShowDialog();
            clearContacts();
            loadContacts();
        }

        private void loadContacts()
        {
            DatabaseManager database = new DatabaseManager();
            contactList = database.retrieveContacts();

            updateGridView();
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

            if (currentUser == null)
                currentUser = new User();

            userForm userForm = new userForm(currentUser);

            userForm.ShowDialog();
            newUser = userForm.User;

            if (newUser == null)
                MessageBox.Show("User was not initialized correctly.");

            else
            {
                labelUsernameout.Text = currentUser.FirstName + " " + currentUser.LastName;
                labelEmailout2.Text = currentUser.Email;
                buttonSend.Enabled = true;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            List<Contact> temp = new List<Contact>();
            List<Contact> bckup = contactList;
            
            if (radioButtonSendPrevious.Checked)
            {
                foreach (Contact contact in contactList)
                    if (contact.SentPrevious)
                        temp.Add(contact);

                contactList = temp;
            }

            if (radioButtonSendSelected.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewContactList.SelectedRows)
                {
                    temp.Add(new Contact(row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        false));
                }

                contactList = temp;
            }

            buttonSend.Enabled = false;
            sendEmails();
            buttonSend.Enabled = true;
            contactList = bckup;
        }

        private void sendEmails()
        {
            if (contactList == null || contactList.Count == 0)
            {
                MessageBox.Show("No contacts selected or available to send to.");
                return;
            }

            int img = 1;

            if (comboBoxTemplate.Text == "RedTemplate.jpg")
                img = 1;

            if (comboBoxTemplate.Text == "RedAndBlackTemplate.jpg")
                img = 2;


            if ( currentUser == null)
            {
                MessageBox.Show("Enter email authentication first!");
                return;
            }

            if (currentUser.EmailService == "Gmail")
                mailer = new GmailManager(currentUser, contactList, textBoxSubject.Text, textBoxCustomMessage.Text, img);

            if (currentUser.EmailService == "Hotmail")
                mailer = new HotmailManager(currentUser, contactList, textBoxSubject.Text, textBoxCustomMessage.Text, img);

            if (currentUser.EmailService == "Yahoo")
                mailer = new YahooManager(currentUser, contactList, textBoxSubject.Text, textBoxCustomMessage.Text, img);

            try
            {
                if (mailer != null)
                    mailer.send(files); // need to create a file
            }

            catch (Exception e)
            {
                string err = e.ToString();
            }
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

        private void comboBoxTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = comboBoxTemplate.Text;

            if (selected == "RedTemplate.jpg")
                pictureBoxPreview.Image = HolidayMailer.Properties.Resources.RedTemplate;

            else
                pictureBoxPreview.Image = HolidayMailer.Properties.Resources.RedAndBlackTemplate;
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

        private void buttonPreview_Click_1(object sender, EventArgs e)
        {
            string preview = "";
            int img = 1;
            User testu;
            Contact testc;
            StreamWriter fout;

            if (comboBoxTemplate.Text == "RedTemplate.jpg")
            {
                img = 1;
                preview = HolidayMailer.Properties.Resources.index1;
            }

            if (comboBoxTemplate.Text == "RedAndBlackTemplate.jpg")
            {
                img = 2;
                preview = HolidayMailer.Properties.Resources.index2;
            }

            if (currentUser == null)
                testu = new User("Nimoy", "Leonard", "mindfusion@yahoo.com", "garbage");

            else
                testu = currentUser;

            testc = new Contact("Shatner", "William", "assimilatethis@email.com", false);

            preview = HTMLManager.generateHTMLForPreviewing(testu, testc, textBoxCustomMessage.Text, preview, img);

            fout = new StreamWriter("HTMLPreview.html");

            fout.Write(preview);

            if (img == 1)
                HolidayMailer.Properties.Resources._1.Save(img + ".jpg");

            if (img == 2)
                HolidayMailer.Properties.Resources._2.Save(img + ".jpg");

            System.Diagnostics.Process.Start("HTMLPreview.html");

            fout.Close();
        }

        private void enterUserCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initUser();
        }

        private void aboutF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Holiday Mailer\n\n" +
            "Team: Bits Be Flippin\'\n\n" +
            "Members:\n" +
            "Sami Awwad\n" +
            "Chris Park\n" +
            "Nathan Pilgrim\n\n" +
            "Version: 1", "About the Developers", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                files = ofd.FileNames;
                buttonAttach.Enabled = false;
                attachFileToolStripMenuItem.Enabled = false;
                buttonRemove.Enabled = true;
                removeAttachmentToolStripMenuItem.Enabled = true;
            }

            else
            {
                buttonAttach.Enabled = true;
                attachFileToolStripMenuItem.Enabled = true;
                buttonRemove.Enabled = false;
                removeAttachmentToolStripMenuItem.Enabled = false;
            }
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            buttonAttach.Enabled = true;
            attachFileToolStripMenuItem.Enabled = true;
            buttonRemove.Enabled = false;
            removeAttachmentToolStripMenuItem.Enabled = false;
            files = null;
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            clearContacts();
            if (textBoxSearch.Text == "")
            {
                loadContacts();
                return;
            }

            DatabaseManager dbase = new DatabaseManager();
            contactList = dbase.retrieveByLastName(textBoxSearch.Text);

            updateGridView();
        }

        private void updateGridView()
        {
            foreach (Contact contact in contactList)
                dataGridViewContactList.Rows.Add(contact.FirstName, contact.LastName,
                    contact.Email, contact.SentPrevious);
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonRemove_Click(sender, e);
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonPreview_Click_1(sender, e);
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSend_Click(sender, e);
        }

        private void attachFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAttach_Click(sender, e);
        }

        private void removeAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonRemove_Click(sender, e);
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Managing Contacts:\n" +
                "-Click Add Contact and enter required information.\n" +
                "-Select contacts in the list and click Delete to remove them.\n" +
                "-Contacts can be sorted by clicking on the column headers in the list.\n" +
                "-Text entered in the search bar refines the contact list by last name.\n\n" +
                "Enter sender email:\n" +
                "-File -> Enter User (Ctrl+E)\n\n" +
                "Message Crafting Options:\n" +
                "-Choose who to send the emails to (Send to)\n" +
                "-Choose A template.\n" +
                "-Choose the subject line of the email to be sent.\n" +
                "-Attach a file if preferred.\n" +
                "-Click Preview to view the email being created.\n" +
                "-Click send.", "How To", MessageBoxButtons.OK);

        }
    }
}
