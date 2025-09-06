using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = SHAHD\\SQLEXPRESS ; Database = ITI ; Trusted_Connection = True; TrustServerCertificate = True");

        } 
        
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>(entityBuilder =>
            {
                entityBuilder.HasKey(s => new { s.Stud_Id, s.Course_Id });
                entityBuilder.Property(s => s.Grade)
                .IsRequired();
            });
            modelBuilder.Entity<Course_Inst>(entityBuilder =>
            {
                entityBuilder.HasKey(c => new {c.Course_Id, c.Inst_Id });
                entityBuilder.Property(c => c.Evaluate).HasMaxLength(50).IsRequired(false) ;

            }); 
            modelBuilder.ApplyConfiguration(new InstructorConfigurations());
        }

       





    }
}
