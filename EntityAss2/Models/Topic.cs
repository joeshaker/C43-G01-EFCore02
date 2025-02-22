using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Topics")]
    internal class NewTopic
    {
        [Key]
        public  int  TopicId { get; set; }
        [Required]
        [Column("TopicName", TypeName = "varchar(40)")]
        public string ? Name { get; set; }
        public ICollection<NewCourse> Courses { get; set; } = new List<NewCourse>();
    }
}
