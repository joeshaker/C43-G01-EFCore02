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
            modelBuilder.ApplyConfiguration(new ModelsConf.Student_Crs_Conf());
            modelBuilder.ApplyConfiguration(new ModelsConf.Crs_Ins_Conf());
            modelBuilder.ApplyConfiguration(new ModelsConf.InstructorConf());

        }
    }
}
