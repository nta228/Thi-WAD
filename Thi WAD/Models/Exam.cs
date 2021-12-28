using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Thi_WAD.Models
{
    public class Exam

    {
        public int id { get; set; }
        [Display(Name = "Subject")]
        public Nullable<int> examSubject { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh: mm}")]
        public System.DateTime startTime { get; set; }

        [Display(Name = "Exam Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime examDate { get; set; }

        [Display(Name = "Exam Duration")]

        public int examduration { get; set; }

        [Display(Name = "Class Room")]
        public Nullable<int> classRoom { get; set; }

        [Display(Name = "Faculty")]
        public Nullable<int> faculty { get; set; }

        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public Faculty Faculty1 { get; set; }
    }
}