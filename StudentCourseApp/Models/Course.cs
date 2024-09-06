using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCourseApp.Models
{
    public class Course
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [Required]
        [Range(1,3)]
        public virtual int Duration {  get; set; }
        public virtual Student Student { get; set; }
    }
}