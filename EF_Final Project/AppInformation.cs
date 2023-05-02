//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;

//namespace EF_Final_Project
//{
//    internal class AppInformation : DbContext
//    {
//        public DbSet<Login> myUser { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UserData;Trusted_Connection=True;MultipleActiveResultSets=true");
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Login>().HasData
//               (
//               new Login { UserId = 0, FirstName = "Nathan", LastName = "Washington", Password = "WhyAreYouLooking", ConfirmPassword = false, Email = "NateSoRealEmail@gmail.com" }
//               );
//        }
//    }
//}
