using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        //iCollections in Student because a enrollment can be accessed multiple times by the same student/course. Enrollment is collecting all this data to make the list I think
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}