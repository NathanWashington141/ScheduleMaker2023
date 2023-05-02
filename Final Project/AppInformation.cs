using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class AppInformation : DbContext
    {
        public DbSet<Login> myUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UserData;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Login>().HasData
            (
                new Login { LoginId = 1, FirstName = "Nathan", LastName = "Washington", Password = "WhyAreYouLooking", ConfirmPassword = false, Attendees = 0, Address = "1234 Jojolands", Email = "NateSoRealEmail@gmail.com"}
                );
        }
    }
}

// Tools --> Package Manager