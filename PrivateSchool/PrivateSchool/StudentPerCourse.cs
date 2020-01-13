using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class StudentPerCourse : School
    {
        //List of Students and a Course
        public Course Course { get; }
        public List<Student> studentsPerCourse { get; set; }


        public StudentPerCourse(Course course,Student std)
        {
            studentsPerCourse = new List<Student>();
            Course = course;
            studentsPerCourse.Add(std);
        }
    }
}
