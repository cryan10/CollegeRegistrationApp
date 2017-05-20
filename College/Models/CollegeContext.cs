using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace College.Models
{
    public class CollegeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CollegeContext() : base("name=CollegeContext")
        {
        }

        public System.Data.Entity.DbSet<College.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<College.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<College.Models.Course> Courses { get; set; }
    }
}
