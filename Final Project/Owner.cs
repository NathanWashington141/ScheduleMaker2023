﻿using Microsoft.Data.SqlClient;
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
            int attendeesSchedule = Convert.ToInt32(txtAttendessSchedule);
            string addressSchedule = txtAddressSchedule.Text;
            DateTime startingDate = Convert.ToDateTime(txtDateSchedule.Text);

            Login addUser = new() { FirstName = txtFirstSchedule.Text, LastName = "None", Password = "None", ConfirmPassword = false, Email = txtEmailSchedule.Text, Attendees = Convert.ToInt32(txtAttendessSchedule), Address = txtAddressSchedule.Text, TimeOfMeeting = Convert.ToDateTime(txtDateSchedule.Text) };

            userDb.myUser.Add(addUser);
            userDb.SaveChanges();
            foreach (Login user in userList)
            {
                lblOutput.Text += user.ToString;
            }
        }

        private void btnCheckSchedule_Click(object sender, EventArgs e)
        {
            DateTime seeDate = Convert.ToDateTime(txtSchedule.Text);

            Login? dateShow = userDb.myUser.Where(c => c.TimeOfMeeting == seeDate).Select(c => c).FirstOrDefault();

            foreach (Login user in userList)
            {

                lblScheduleDate.Text = user.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduleChange_Click(object sender, EventArgs e)
        {

        }
    }
}
