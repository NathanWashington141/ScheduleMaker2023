using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Owner : Form
    {
        AppInformation userDb;
        List<Login> userList;
        public Owner()
        {
            userDb = new AppInformation();
            InitializeComponent();

            userList = userDb.myUser.Select(u => u).ToList();
        }

        private void openForm()
        {
            Login? welcomeUser = userDb.myUser.Where(w => w.TimeOfMeeting > DateTime.Now).OrderBy(w => w.TimeOfMeeting).FirstOrDefault();

            if (welcomeUser != null)
            {
                foreach (Login user in userList)
                {
                    lblAppointment.Text = user.ToString();
                }
            }
            else
            {
                lblAppointment.Text = "No meeting found";
            }
        }

        private void btnScheduleEnter_Click(object sender, EventArgs e)
        {
            string firstNameSchedule = txtFirstSchedule.Text;
            string emailSchedule = txtEmailSchedule.Text;
            int attendeesSchedule = Convert.ToInt32(txtAttendessSchedule.Text);
            string addressSchedule = txtAddressSchedule.Text;
            DateTime startingDate = Convert.ToDateTime(txtDateSchedule.Text);

            try
            {
                Login newMeeting = new Login
                {
                    FirstName = firstNameSchedule,
                    Email = emailSchedule,
                    Attendees = attendeesSchedule,
                    Address = addressSchedule,
                    TimeOfMeeting = startingDate,
                };

                userDb.myUser.Add(newMeeting);
                userDb.SaveChanges();

                lblOutput.Text = "Meeting have been made.";
                lblOutput.ForeColor = Color.Green;
                
            }
            catch 
            {
                lblOutput.Text = "Error";
                lblOutput.ForeColor = Color.Red;
            }
        }

        private void btnCheckSchedule_Click(object sender, EventArgs e)
        {
            DateTime seeDate = Convert.ToDateTime(txtSchedule.Text);

            lblScheduleDate.Text = "";

            Login? dateShow = userDb.myUser.Where(c => c.TimeOfMeeting.Date == seeDate.Date).Select(c => c).FirstOrDefault();

            foreach (Login user in userList)
            {

                lblScheduleDate.Text = $"{user.FirstName}\n" +
                   $"At this date {user.TimeOfMeeting}\n" +
                   $"There are {user.Attendees} people coming\n" +
                   $"At this Address {user.Address}\n";
                openForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime BeginDate = DateTime.Parse(txtBeginDate.Text);
            DateTime EndDate = DateTime.Parse(txtEndDate.Text);

            lblPersonSchedule.Text = "";

            foreach (Login user in userList)
            {
                lblPersonSchedule.Text = $"{user.FirstName}\n" +
                   $"At this date {user.TimeOfMeeting}\n" +
                   $"There are {user.Attendees} people coming\n" +
                   $"At this Address {user.Address}\n";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string deleteDate = txtDelete.Text;

            Login? updateList = userDb.myUser.FirstOrDefault(u => u.Email == deleteDate);

            if (updateList != null)
            {
                try
                {
                    userDb.myUser.Remove(updateList);
                    userDb.SaveChanges();
                    lblDeleted.Visible = true;
                }
                catch
                {
                    lblDeleted.Text = "Error";
                    lblDeleted.ForeColor = Color.Red;
                    lblDeleted.Visible = true;
                }
            }
        }

        private void btnScheduleChange_Click(object sender, EventArgs e)
        {
            string nameUp = txtNameUp.Text;

            DateTime dateTimeUp = DateTime.Parse(txtStartingUp.Text);

            int attendeesUp = Convert.ToInt32(txtAttendeesUp.Text);

            string addressUp = txtAddressUp.Text;

            string emailUp = txtEmailUp.Text;

            Login? updatePerson = userDb.myUser.SingleOrDefault(p => p.Email == emailUp);

                if (updatePerson != null)
                {
                    try
                    {
                        updatePerson.FirstName = nameUp;
                        updatePerson.TimeOfMeeting= dateTimeUp;
                        updatePerson.Attendees = attendeesUp;
                        updatePerson.Address = addressUp;
                        updatePerson.Email = emailUp;

                        userDb.SaveChanges();
                        lblScheduleUpdate.Visible = true;
                    }
                    catch
                    {
                        lblScheduleUpdate.Text = "Error";
                        lblScheduleUpdate.ForeColor = Color.Red;
                        lblScheduleUpdate.Visible = true;
                    }
                }
        }
    }
}
