using Microsoft.VisualBasic.ApplicationServices;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics.Metrics;
using System.Xml;
using System.Xml.Linq;
using Org.BouncyCastle.Asn1.Crmf;
using Microsoft.Identity.Client;

namespace GUI_IT
{
    internal class Email
    {
        public static Boolean sendEmail(string template, string user, int x = 0, int tID = 0)
        {
            String[] data = { };
            data = emailBody(template, user, tID);
            string subject = data[0];
            string body = data[1];

            var regEmail = new MimeMessage();

            regEmail.From.Add(new MailboxAddress("Red Agents IT Service", "redagentsit@gmail.com"));
            if (x == 0)
            {
                regEmail.To.Add(new MailboxAddress(Sql.getName(user), Sql.getEmail(user)));
            }
            else
            {
                regEmail.To.Add(new MailboxAddress(Sql.getNamee(user), Sql.getEmaill(user)));
            }
            regEmail.Subject = subject;
            regEmail.Body = new TextPart()
            {
                Text = body
            };

            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 465, true);
                smtp.Authenticate("redagentsit@gmail.com", "wjwrhbulohrxrcfq");
                smtp.Send(regEmail);
                smtp.Disconnect(true);
            }

            return true;
        }

        public static bool isValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

        private static string[] emailBody(string template, string user, int tID = 0)
        {
            string[] data = {string.Empty, string.Empty};
            if(template == "Registration")
            {
                data[0] = "Successful Registration";
                data[1] = "Hello " + Sql.getNamee(user)
                          + "! Your access is pending administrative approval.\n You will be notified " 
                          + "when your registration status has been reviewed by our Administrative Team.\n\n"
                          + "If you have any concerns or questions, please respond to this email or reach us at redagentsit@gmail.com\n\n-Red Agents IT";
            }
            if(template == "Registration Accepted")
            {
                data[0] = "Account Registration Accepted";
                data[1] = "Hello " + Sql.getNamee(user)
                        + "! \n\nCongratulations! Your account registration has been accepted.\n\n"
                        + "Below are your login credentials for the Red Agents IT Ticketing System.\n"
                        + "Username: " + user + "\n" + "Password: " + Sql.getPasss(user) + "\n\n"
                        + "Please do not share your credentials with anyone!\n\n-Red Agents IT";
            }
            if(template == "Registration Denied")
            {
                data[0] = "Account Registration Denied";
                data[1] = "Hello " + Sql.getNamee(user)
                        + "! \n\nYour account registration has been denied.\n\n"
                        + "If you believe we have made an error, please respond to this email or "
                        + "reach us at redagentsit@gmail.com\n\n-Reg Agents IT";
            }
            if(template == "Raised Ticket")
            {
                data[0] = "Notice: New Ticket Raised";
                data[1] = "Hello " + Sql.getName(user)
                        + "!\n\nA new ticket has been raised on the Reg Agents IT Help Desk. Below are the details:\n"
                        + "Ticket ID: " + tID + "\n"
                        + "Ticket Category " + Sql.getTicketCategory(tID) + "\n"
                        + "Ticket Priority " + Sql.getTicketPriority(tID) + "\n"
                        + "Ticket Created By: " + Sql.getTicketUser(tID) + "\n"
                        + "Ticket Description: " + Sql.getTicketDescription(tID) + "\n\n"
                        + "More information can be found within the Reg Agents IT Helpdesk Interface.";
            }
            return data;
        }
        /* 
        "Hello " + Sql.getName(user) 
		+ "! Below are your login credentials for the Red Agents IT Ticketing System.\n" 
		+ "Your access is pending administrative approval. You will be notified when your registration status is confirmed.\n\n" 
		+ "Username: " + user + "\n" + "Password: " + Sql.getPass(user) + "\n\n" 
		+ "Please do not share your credentials with anyone!" + "\n" + "- Red Agents IT"
        */
    }
}
