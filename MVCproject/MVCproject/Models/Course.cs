using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCproject.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Display(Name = " CODE")]
        public string Code { get; set; }

        [Display(Name = "COURSE CRADITE")]
        public string Credite { get; set; }

        [Display(Name = "COURSE NAME")]
        public string Name { get; set; }

        [Display(Name = "COURSE DESCRIPTION")]
        public string Description { get; set; }

        public virtual Department Department { set; get; }
        [Display(Name = "STUDENT DEPARTMENT")]
        public int DepartmentId { set; get; }



    }
}