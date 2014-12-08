using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Collections;

//usage: NetworkManager manager = new GmailManager(User sender, Contact[] contacts, string subject, string body);
//then to send: manager.send();

namespace HolidayMailer
{
    abstract class NetworkManager
    {
        protected User theSender;
        protected List<Contact> contacts;
        protected SmtpClient smtp;
        protected MailMessage message;
        protected string fromName;
        protected string fromAddress, toAddress;
        protected string fromPassword;
        protected string subject;
        protected string body;
        protected int img;

        public NetworkManager()
        {
        }

        protected void buildMessage()
        {
            message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;//new
        }

        public void send()
        {
            string html = "";
            Attachment bgImg;

            if (img == 1)
            {
                html = HolidayMailer.Properties.Resources.index1;
                HolidayMailer.Properties.Resources._1.Save("1.jpg");
                bgImg = new Attachment("1.jpg");
                bgImg.ContentId = "1";// this will need to be able to switch between 1 and 2
            }

            else
            {
                html = HolidayMailer.Properties.Resources.index2;
                HolidayMailer.Properties.Resources._2.Save("2.jpg");
                bgImg = new Attachment("2.jpg");
                bgImg.ContentId = "2";// this will need to be able to switch between 1 and 2
            }

            foreach (Contact current in contacts)
            {
                toAddress = current.Email;

                message = new MailMessage(fromAddress, toAddress);
                message.Subject = subject;
                //message.Body = body;
                message.Body = HTMLManager.generateHTMLForSending(theSender, current, body, html, img);

                //new
                message.IsBodyHtml = true;
                message.Attachments.Add(bgImg);

                try
                {
                    smtp.Send(message);
                }
                catch (Exception E)
                {
                    System.Windows.Forms.MessageBox.Show(E.ToString());
                    //no console available
                    //Console.WriteLine(E.ToString());
                    //Console.ReadLine();
                }
            }
        }
    }

    class GmailManager : NetworkManager
    {
        public GmailManager(User theSender, List<Contact> contacts, string subject, string body, int img)
        {
            this.body = body;
            this.fromName = theSender.FirstName + " " + theSender.LastName;
            this.fromAddress = theSender.Email;
            this.fromPassword = theSender.Password;
            this.contacts = contacts;
            this.subject = subject;
            this.body = body;
            this.theSender = theSender;
            this.img = img;

            smtp = new SmtpClient();

            authenticate();
        }
        
        protected void authenticate()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
        }
    }

    class HotmailManager : NetworkManager
    {
        public HotmailManager(User theSender, List<Contact> contacts, string subject, string body, int img)
        {
            this.body = body;
            this.fromName = theSender.FirstName + " " + theSender.LastName;
            this.fromAddress = theSender.Email;
            this.fromPassword = theSender.Password;
            this.contacts = contacts;
            this.subject = subject;
            this.body = body;
            this.theSender = theSender;
            this.img = img;

            smtp = new SmtpClient();

            authenticate();

            smtp = new SmtpClient();

            authenticate();
        }

        protected void authenticate()
        {

            smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
        }
    }

    class YahooManager : NetworkManager
    {
        protected string fromAddressPrefix;
        public YahooManager(User theSender, List<Contact> contacts, string subject, string body, int img)
        { 
            this.fromName = theSender.FirstName + " " + theSender.LastName;
            this.fromAddress = theSender.Email;
            this.fromPassword = theSender.Password;
            this.contacts = contacts;
            this.subject = subject;
            this.body = body;
            this.theSender = theSender;
            this.img = img;

            string[] toSplit = fromAddress.Split('@');
            fromAddressPrefix = toSplit[0];

            smtp = new SmtpClient();

            authenticate();
        }

        protected void authenticate()
        {

            smtp.Host = "smtp.mail.yahoo.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromAddressPrefix, fromPassword);
        }
    }
}


