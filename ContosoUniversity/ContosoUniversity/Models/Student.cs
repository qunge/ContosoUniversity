using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// 一对多关系，一个学生可以对应多个课程
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}