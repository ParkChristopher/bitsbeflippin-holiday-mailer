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
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Focus();
            this.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DatabaseManager database = new DatabaseManager();

            try
            {
                database.add(textBoxLastName.Text, textBoxFirstName.Text,
                    textBoxEmail.Text, false);
                MessageBox.Show("Added.");
            }
            catch (Exception excep)
            {
                MessageBox.Show("Failed to add contact");
            }
        }
    }
}
