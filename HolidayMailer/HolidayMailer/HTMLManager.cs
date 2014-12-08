using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{
    static class HTMLManager
    {

        public static string generateHTMLForSending(User sender, Contact receiver, string message, string html)
        {
            string ret = html;
            string from, to;

            from = sender.FirstName + " " + sender.LastName;
            to = receiver.FirstName + " " + receiver.LastName;


            return ret;
        }

        //work on this one first
        public static string generateHTMLForPreviewing(User sender, Contact receiver, string message, string html)
        {
            string ret = html;
            string from, to;
            int i, lineBreaks = message.Length / 50;
            string temp = message;

            from = sender.FirstName + " " + sender.LastName;
            to = receiver.FirstName + " " + receiver.LastName;

            ret = ret.Replace("#from#", from);
            ret = ret.Replace("#name#", to);

            for (i = 0; i < lineBreaks; i++)
                temp = temp.Insert((i + 1) * 50 + 4 * i, "<br>");

            ret = ret.Replace("#body#", temp);

            return ret;
        }

    }
}
