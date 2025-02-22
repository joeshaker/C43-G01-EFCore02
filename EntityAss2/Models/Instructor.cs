using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Instructors")]
    internal class NewInstructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Ins_Name", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Name { get; set; }

        public decimal Bouns { get; set; }

        [Column("Ins_Salary", TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }

        public string? Address { get; set; }

        public int Hour_Rate { get; set; }

        [ForeignKey(nameof(InsDepartment))]
        public int Dept_Id { get; set; }

        [InverseProperty(nameof(NewDepartment.Manager))]
        public NewDepartment? ManagedDepartment { get; set; }

        [InverseProperty(nameof(NewDepartment.Instructors))]
        public NewDepartment InsDepartment { get; set; } = null!;

        public ICollection<NewCourse_Inst> NewCourse_Insts { get; set; } = new List<NewCourse_Inst>();

    }
}
