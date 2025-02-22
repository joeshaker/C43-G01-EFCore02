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
    internal class InstructorConf : IEntityTypeConfiguration<NewInstructor>
    {
        public void Configure(EntityTypeBuilder<NewInstructor> builder)
        {
            builder
                .HasOne(d => d.ManagedDepartment)
                .WithOne(E => E.Manager)
                .HasForeignKey<NewDepartment>(d => d.Ins_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder
                .HasOne(i => i.InsDepartment)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
        }
    }
}
