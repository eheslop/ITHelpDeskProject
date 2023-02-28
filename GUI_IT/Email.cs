using Microsoft.VisualBasic.ApplicationServices;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_IT
{
    internal class Email
    {
        public static void regEmail(string user)
        {
            var regEmail = new MimeMessage();

            regEmail.From.Add(new MailboxAddress("Red Agents IT Service", "redagentsit@gmail.com"));
            regEmail.To.Add(new MailboxAddress(Sql.getName(user), Sql.getEmail(user))); ;

            regEmail.Subject = "Login Credentials";
            regEmail.Body = new TextPart()
            {
                Text = "Hello " + Sql.getName(user) + "! Below are your login credentials for the Red Agents IT Ticketing System.\n\n" +
                "Username: " + user + "\n" +
                "Password: " + Sql.getPass(user) + "\n\n" +
                "Please do not share your credentials with anyone!" + "\n" +
                "- Red Agents IT"

            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 465, true);
                smtp.Authenticate("redagentsit@gmail.com", "wjwrhbulohrxrcfq");
                smtp.Send(regEmail);
                smtp.Disconnect(true);
            }
        }
    }
}
