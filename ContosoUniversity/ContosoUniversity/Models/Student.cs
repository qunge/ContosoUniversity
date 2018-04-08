using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Column("FirstName")]
        [Display(Name ="First Name")]
        [StringLength(50,ErrorMessage ="名字最大长度不能超高50")]
        public string FirstMidName { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name ="Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="Full Name")]
        public string FullName
        {
            get { return FirstMidName + "," + LastName; }
        }
        /// <summary>
        /// 一对多关系，一个学生可以对应多个课程
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}