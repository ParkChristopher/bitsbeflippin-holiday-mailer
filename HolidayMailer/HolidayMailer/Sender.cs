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
    public partial class userForm : Form
    {
        User sender;

        public User User { get { return this.sender; } }

        public userForm()
        {
            InitializeComponent();
        }

        public userForm(User sender)
        {
            InitializeComponent();

            this.sender = sender;

            textBoxLastName.Text = sender.LastName;
            textBoxFirstName.Text = sender.FirstName;
            textBoxEmail.Text = sender.Email;
            textBoxPassword.Text = sender.Password;
            comboBoxProviders.Text = sender.EmailService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            initializeUser();
        }

        private void initializeUser()
        {
            if ( textBoxEmail.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Email and/or password fields are blank.");
                return;
            }

            this.sender.LastName = textBoxLastName.Text;
            this.sender.FirstName = textBoxFirstName.Text;
            this.sender.Email = textBoxEmail.Text;
            this.sender.Password = textBoxPassword.Text;
            this.sender.EmailService = comboBoxProviders.Text;

            MessageBox.Show("User has been initialized.");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.sender = null;
        }

        private void actionFormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
