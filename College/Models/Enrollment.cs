using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public float StudentGPA { get; set; }
        public bool isEnrolled { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }



    }
}