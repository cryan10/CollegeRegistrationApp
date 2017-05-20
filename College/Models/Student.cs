using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentMajor { get; set; }
        //iCollections in Student because a enrollment can be accessed multiple times by the same student/course
        public virtual ICollection<Enrollment>Enrollments { get; set; }

    }
}