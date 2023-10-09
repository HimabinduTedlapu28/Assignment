using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudyproject
{
    public  class Course
    {
        private string v;

        public int courseid { get; set; }
        public string coursename { get; set; }
        public Course(int courseid, string coursename)
        {
            this.courseid = courseid;
            this.coursename = coursename;
        }

       
    }
}
