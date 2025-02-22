using System.Reflection.Emit;
using EntityAss1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityAss2.ModelsConf
{
    internal class Student_Crs_Conf : IEntityTypeConfiguration<NewStd_Course>
    {
        public void Configure(EntityTypeBuilder<NewStd_Course> builder)
        {
            builder
                .HasOne(c => c.Student)
                .WithMany(c => c.Std_Courses)
                .HasForeignKey(c => c.Std_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder
                .HasOne(c => c.Course)
                .WithMany(c => c.Std_Courses)
                .HasForeignKey(c => c.Course_Id)
                .OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.HasKey(e => new
            {
                e.Std_Id,
                e.Course_Id

            });
        }
    }
}
