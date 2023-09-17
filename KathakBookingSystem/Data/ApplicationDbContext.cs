using KathakBookingSystem.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace KathakBookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContextpublic (DbContextOptions options):base(options)
        {           }

        // Write your ApplicationDbContext here...
public  virtual DbSet<Class> Class{get;set;}
public  virtual DbSet<Student> Student{get;set;}
    }
}
