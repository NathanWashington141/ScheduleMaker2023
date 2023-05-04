using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Appintment
    {
        public Appintment() { }

        public int AppointmentFinderID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int Attendees { get; set; } = 0;

        public string Address { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            return $"Wlcome {FirstName}";
        }

        public Appintment(int appointmentFinderID, string firstName, string email, int attendees, string address, DateTime startDate)
        {
            AppointmentFinderID = appointmentFinderID;
            FirstName = firstName;
            Email = email;
            Attendees = attendees;
            Address = address;
            StartDate = startDate;
        }
    }
}
