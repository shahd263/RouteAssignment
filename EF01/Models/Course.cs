using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Course // By Data Annotations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Crs_Id { get; set; }

        [Range(1, 3)]
        public int Duration { get; set; }

        [Column("crs_Name" , TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [AllowNull]
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [ForeignKey(nameof(Topic))]
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }
        public List<Stud_Course> Students { get; set; }
        public List<Course_Inst> Insructors { get; set; }

    }
}
