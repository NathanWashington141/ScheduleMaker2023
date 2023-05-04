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
                    lblWelcome.Text = $"Welcome {user.FirstName} {user.LastName}";

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
                Login addUser = new() { FirstName = txtFirstSchedule.Text, LastName = "None", Password = "None", ConfirmPassword = false, Email = txtEmailSchedule.Text, Attendees = Convert.ToInt32(txtAttendessSchedule), Address = txtAddressSchedule.Text, TimeOfMeeting = DateTime.Parse(txtDateSchedule.Text) };

                userDb.myUser.Add(addUser);
                userDb.SaveChanges();
                foreach (Login user in userList)
                {
                    lblOutput.Text += user.ToString();
                }
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnCheckSchedule_Click(object sender, EventArgs e)
        {
            DateTime seeDate = Convert.ToDateTime(txtSchedule.Text);

            Login? dateShow = userDb.myUser.Where(c => c.TimeOfMeeting == seeDate).Select(c => c).FirstOrDefault();

            foreach (Login user in userList)
            {

                lblScheduleDate.Text = user.ToString();
                openForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime BeginDate = DateTime.Parse(txtBeginDate.Text);
            DateTime EndDate = DateTime.Parse(txtEndDate.Text);

            foreach (Login user in userList)
            {
                lblPersonSchedule.Text += user.ToString();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //string deleteDate = txtDelete.Text;

            //int emailIdDelete = userDb.myUser.Select();

            //foreach (Login user in userList)
            //{
            //    if (deleteDate == user.Email)
            //    {
                    
            //    }
            //}

            //Login? deleteDate = userDb.myUser.Find();

            //if (deleteDate != null)
            //{
            //    try
            //    {
            //        userDb.myUser.Remove();
            //        userDb.SaveChanges();
            //        lblDeleted.Visible = true;
            //    }
            //    catch
            //    {
            //        lblDeleted.Text = "Error";
            //        lblDeleted.ForeColor = Color.Red;
            //        lblDeleted.Visible = true;
            //    }
            //}
        }

        private void btnScheduleChange_Click(object sender, EventArgs e)
        {
            string nameUp = txtNameUp.Text;

            DateTime dateTimeUp = DateTime.Parse(txtStartingUp.Text);

            int attendeesUp = Convert.ToInt32(txtAttendeesUp.Text);

            string addressUp = txtAddressUp.Text;

            string emailUp = txtEmailUp.Text;

            Login? updateName = userDb.myUser.Find(nameUp);

            Login? updateTime = userDb.myUser.Find(dateTimeUp);

            Login? updateAttendees = userDb.myUser.Find(attendeesUp);

            Login? updateAddress = userDb.myUser.Find(addressUp);

            Login? updateEmail = userDb.myUser.Find(emailUp);

            if (updateName != null && updateTime != null && updateAttendees != null && updateAddress != null && updateEmail != null)
            {
                try
                {
                    userDb.myUser.Add(updateEmail);
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
    }
}
