using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class StudentsMetaData
    {
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Enrollment Date")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
    }

    [MetadataType(typeof(StudentsMetaData))]
    public partial class Student { } 
}