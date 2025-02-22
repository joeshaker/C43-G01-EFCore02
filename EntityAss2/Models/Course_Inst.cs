using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Course_Ins")]
    internal class NewCourse_Inst
    {
        [Required]
        [ForeignKey(nameof(NewCourse))]
        public  int Course_Id { get; set; }
        [Required]
        [ForeignKey(nameof(NewInstructor))]
        public int Ins_Id { get; set; }
        public  string ?Evaluate { get; set; }
        public NewCourse NewCourse { get; set; }
        public NewInstructor NewInstructor { get; set; }
    }
}
