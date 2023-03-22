using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_IT
{
    public class SessionRegister
    {
        private string email_;
        private string firstName_;
        private string lastName_;
        private string userType_;
        private string username_;
        private string password_;

        public SessionRegister()
        {
            email_ = string.Empty;
            firstName_ = string.Empty;
            lastName_ = string.Empty;
            userType_ = string.Empty;
            username_ = string.Empty;
            password_ = string.Empty;
        }
        public string Email { get => email_; set => email_ = value;}
        public string FirstName { get => firstName_; set => firstName_ = value;}
        public string LastName { get => lastName_; set => lastName_ = value;}
        public string UserType { get => userType_; set => userType_ = value;}
        public string Username { get => username_; set => username_ = value; }
        public string Password { get => password_; set => password_ = value;}
    }
}
