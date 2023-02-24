using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_IT
{
    internal class SessionRegister
    {
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _userType;
        public SessionRegister()
        {
            _email = string.Empty;
            _firstName = string.Empty;
            _lastName = string.Empty;
            _userType = string.Empty;
        }
        public string Email { get =>_email; set => _email = value;}
        public string FirstName { get => _firstName; set => _firstName = value;}
        public string LastName { get => _lastName; set => _lastName = value;}
        public string UserType { get => _userType; set => _userType = value;}
    }
}
