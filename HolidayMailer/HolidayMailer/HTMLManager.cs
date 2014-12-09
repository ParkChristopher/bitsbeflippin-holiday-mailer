using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailer
{
    static class HTMLManager
    {

        public static string generateHTMLForSending(User sender, Contact receiver, string message, string html, int template)
        {
            string[] tokens;
            string ret = html;
            string from, to;
            string temp = "";
            int tokenNum, tokenBreaks, j;

            from = sender.FirstName + " " + sender.LastName;
            to = receiver.FirstName + " " + receiver.LastName;

            ret = ret.Replace("#from#", from);
            ret = ret.Replace("#name#", to);

            tokens = message.Split(' ');
            tokenNum = tokens.Length;
            tokenBreaks = tokenNum / 10;

            if (template == 1)
            {
                ret = ret.Replace("1.jpg", "cid:1");

                temp += tokens[0] + " ";
                j = 1;

                for (int i = 1; i < tokenNum; i++)
                {
                    temp += tokens[i] + " ";

                    if (j == 10)
                    {
                        temp += "<br>";
                        j = 0;
                    }

                    j++;
                }
            }

            else
            {
                ret = ret.Replace("2.jpg", "cid:2");
                temp = message;
            }

            ret = ret.Replace("#body#", temp);

            return ret;
        }

        //work on this one first
        public static string generateHTMLForPreviewing(User sender, Contact receiver, string message, string html, int template)
        {
            string[] tokens;
            string ret = html;
            string from, to;
            string temp = "";
            int tokenNum, tokenBreaks, j;

            from = sender.FirstName + " " + sender.LastName;
            to = receiver.FirstName + " " + receiver.LastName;

            ret = ret.Replace("#from#", from);
            ret = ret.Replace("#name#", to);

            tokens = message.Split(' ');
            tokenNum = tokens.Length;
            tokenBreaks = tokenNum / 10;

            if (template == 1)
            {
                temp += tokens[0] + " ";
                j = 1;

                for (int i = 1; i < tokenNum; i++)
                {
                    temp += tokens[i] + " ";

                    if (j == 10)
                    {
                        temp += "<br>";
                        j = 0;
                    }

                    j++;
                }
            }

            else
                temp = message;

            ret = ret.Replace("#body#", temp);

            return ret;
        }
    }
}
