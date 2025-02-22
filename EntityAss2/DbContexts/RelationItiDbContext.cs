using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EntityAss1.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityAss2.DbContexts
{
    internal class RelationItiDbContext:DbContext
    {
        public RelationItiDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= NewRelationItiDb; Trusted_Connection= true; TrustServerCertificate=true");
        }
        DbSet<NewStudent> Students { get; set; }
        DbSet<NewCourse> Courses { get; set; }

        DbSet<NewDepartment> Departments { get; set; }

        DbSet<NewStd_Course> Std_Courses { get; set; }
        DbSet<NewInstructor> Instructors { get; set; }
        DbSet<NewTopic> Topics { get; set; }
        DbSet<NewCourse_Inst> Course_Insts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewStd_Course>().HasKey(e => new
            {
                e.Std_Id,
                e.Course_Id

            });
            modelBuilder.Entity<NewCourse_Inst>().HasKey(e => new
            {
                e.Course_Id,
                e.Ins_Id,
            });
            modelBuilder.Entity<NewInstructor>()
              .HasOne(i => i.InsDepartment) 
              .WithMany(d => d.Instructors)   
              .HasForeignKey(i => i.Dept_Id)  
              .OnDelete(DeleteBehavior.NoAction).IsRequired(); 

            modelBuilder.Entity<NewInstructor>()
                .HasOne(d => d.ManagedDepartment)         
                .WithOne(E=>E.Manager)                     
                .HasForeignKey<NewDepartment>(d=>d.Ins_Id)   
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            modelBuilder.Entity<NewCourse_Inst>()
                .HasOne(c => c.NewCourse)
                .WithMany(c => c.NewCourse_Insts)
                .HasForeignKey(c => c.Course_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            modelBuilder.Entity<NewCourse_Inst>()
                .HasOne(c => c.NewInstructor)
                .WithMany(c => c.NewCourse_Insts)
                .HasForeignKey(c => c.Ins_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            modelBuilder.Entity<NewStd_Course>()
                .HasOne(c => c.Student)
                .WithMany(c => c.Std_Courses)
                .HasForeignKey(c => c.Std_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            modelBuilder.Entity<NewStd_Course>()
                .HasOne(c => c.Course)
                .WithMany(c => c.Std_Courses)
                .HasForeignKey(c => c.Course_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();

        }
    }
}
