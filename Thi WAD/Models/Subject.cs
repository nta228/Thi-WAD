using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thi_WAD.Models
{
    public class Subject
    {
        public Subject()
        {
            this.Exams = new HashSet<Exam>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}