using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EntityAss1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityAss2.ModelsConf
{
    internal class Crs_Ins_Conf : IEntityTypeConfiguration<NewCourse_Inst>
    {
        public void Configure(EntityTypeBuilder<NewCourse_Inst> builder)
        {
            builder
                .HasOne(c => c.NewCourse)
                .WithMany(c => c.NewCourse_Insts)
                .HasForeignKey(c => c.Course_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder
                .HasOne(c => c.NewInstructor)
                .WithMany(c => c.NewCourse_Insts)
                .HasForeignKey(c => c.Ins_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder
                .HasKey(e => new
            {
                e.Course_Id,
                e.Ins_Id,
            });
        }
    }
}
