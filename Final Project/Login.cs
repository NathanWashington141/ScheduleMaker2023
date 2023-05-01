using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Login
    {
        public Login() { }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Password { get; set; }

        public bool ConfirmPassword { get; set; }

        public string Email { get; set; }

        public DateTime TimeOfMeeting { get; set; }

        public Login(string firstName, string lastName, string password, bool confirmPassword, string email, DateTime timeOfMeeting)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
            TimeOfMeeting = timeOfMeeting;
        }
    }
}
