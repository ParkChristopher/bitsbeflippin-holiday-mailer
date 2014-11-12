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
        //protected Contact[] contacts;
        protected List<Contact> contacts;
        protected SmtpClient smtp;
        protected MailMessage message;
        protected string fromName;
        protected string fromAddress, toAddress;
        protected string fromPassword;
        protected string subject;
        protected string body;

        public NetworkManager()
        {
        }

        protected void buildMessage()
        {
            message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Body = body;
        }

        public void send()
        {
            int i;
            



            //for (i = 0; i < contacts.Length; i++ )
            foreach (Contact current in contacts)
            {
                toAddress = current.Email;

                message = new MailMessage(fromAddress, toAddress);
                message.Subject = subject;
                message.Body = body;

                try
                {
                    smtp.Send(message);
                }
                catch (Exception E)
                {
                    Console.WriteLine(E.ToString());
                    Console.ReadLine();
                }
            }
        }
    }

    class GmailManager : NetworkManager
    {
        public GmailManager(User theSender, List<Contact> contacts, string subject, string body)
        {
            this.body = body;
            this.fromName = theSender.FirstName + " " + theSender.LastName;
            this.fromAddress = theSender.Email;
            this.fromPassword = theSender.Password;
            this.contacts = contacts;
            this.subject = subject;
            this.body = body;

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
        public HotmailManager(User theSender, List<Contact> contacts, string subject, string body)
        {
            this.body = body;
            this.fromName = theSender.FirstName + " " + theSender.LastName;
            this.fromAddress = theSender.Email;
            this.fromPassword = theSender.Password;
            this.contacts = contacts;
            this.subject = subject;
            this.body = body;

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
        public YahooManager(User theSender, List<Contact> contacts, string subject, string body)
        { 
            this.fromName = theSender.FirstName + " " + theSender.LastName;
            this.fromAddress = theSender.Email;
            this.fromPassword = theSender.Password;
            this.contacts = contacts;
            this.subject = subject;
            this.body = body;

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


