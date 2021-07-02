namespace Lab4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LecturerId { get; set; }

        [Required(ErrorMessage ="The Place is Required")]
        [StringLength(255)]
        public string Place { get; set; }

        [Required(ErrorMessage ="The Datetime is Required")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage ="Category is Required")]
        public int CategoryId { get; set; }
        public Category Category { get; internal set; }

        public string Name;

        //add List Category
        public List<Category> ListCategory = new List<Category>();
    }
}
