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
            //sender = new User(textBoxLastName.Text, textBoxFirstName.Text, textBoxEmailAddress.Text, textBoxPassword.Text);

            this.sender.LastName = textBoxLastName.Text;
            this.sender.FirstName = textBoxFirstName.Text;
            this.sender.Email = textBoxEmail.Text;
            this.sender.Password = textBoxPassword.Text;
            this.sender.EmailService = comboBoxProviders.Text;

            MessageBox.Show("User has been initialized.");
            this.Close();
                



            //need to check these for a user trying to break the progra
        }
    }
}
