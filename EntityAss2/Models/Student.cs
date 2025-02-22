using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Students")]
    internal class NewStudent
    {
        [Key]
        public  int  StdId { get; set; }
        [Required]
        [Column("FirstName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public  string Fname { get; set; }
        [Required]
        [Column("LastName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public  string Lname { get; set; }
        public  string? Address { get; set; }
        [Range(6,18)]
        [DeniedValues(1,2,3,4,5)]
        public  int  Age { get; set; }
        [ForeignKey(nameof(StdDepartment))]
        public  int  Dep_Id { get; set; }
        public NewDepartment ?StdDepartment { get; set; }
        public ICollection<NewStd_Course> Std_Courses { get; set; } = new List<NewStd_Course>();
    }
}
