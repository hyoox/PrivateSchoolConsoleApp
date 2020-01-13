using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class AssignmentPerCourse : School
    {
        //List of assignments and a course
        public Course Course { get; set; }
        public List<Assignment> asgmsPerCourse = new List<Assignment>();
        //Constructors
        

        public AssignmentPerCourse(Course course, Assignment asgm)
        {
            Course = course;
            asgmsPerCourse.Add(asgm);
        }
        
    }
}
