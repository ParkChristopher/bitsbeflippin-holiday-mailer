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
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            closeDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DatabaseManager database = new DatabaseManager();

            try
            {
                database.add(textBoxLastName.Text, textBoxFirstName.Text,
                    textBoxEmail.Text, checkBoxPreviousContact.Checked);
                MessageBox.Show("Contact added.");
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: Contact already exists.",
                    "Duplicate Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);

                using (StreamWriter writer = new StreamWriter("errorlog.txt"))
                { writer.WriteLine(excep); }
            }

            closeDialog();
        }

        private void closeDialog()
        {
            this.Hide();
            this.Owner.Focus();
            this.Dispose();
        }


    }
}
