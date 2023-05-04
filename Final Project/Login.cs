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

        public int LoginId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public bool ConfirmPassword { get; set; }

        public string Email { get; set; }

        public int Attendees { get; set; }

        public string Address { get; set; }

        public DateTime TimeOfMeeting { get; set; }

        public override string ToString()
        {
            return $"{FirstName}\n" +
                   $"At this date {TimeOfMeeting}\n" +
                   $"There are {Attendees} people coming\n" +
                   $"At this Address {Address}\n";
        }

        public Login(int loginId, string firstName, string lastName, string password, bool confirmPassword, string email, int attendees, string address, DateTime timeOfMeeting)
        {
            LoginId = loginId;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
            Attendees = attendees;
            Address = address;
            TimeOfMeeting = timeOfMeeting;
        }
    }
}

