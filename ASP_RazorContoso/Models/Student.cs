using System;
using System.Collections.Generic;


namespace ASP_RazorContoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
