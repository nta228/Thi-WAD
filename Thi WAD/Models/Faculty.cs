using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thi_WAD.Models
{
    public class Faculty
    {       public Faculty()
        {
            this.Exams = new HashSet<Exam>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}