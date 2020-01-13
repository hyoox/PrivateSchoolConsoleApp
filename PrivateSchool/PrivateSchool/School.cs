using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class School
    {
        public List<Student> studentList = new List<Student>();
        public List<Course> courseList = new List<Course>();
        public List<Trainer> trainerList = new List<Trainer>();
        public List<Assignment> assignmentList = new List<Assignment>();
        public List<StudentPerCourse> stdsPerCourse = new List<StudentPerCourse>();
        public List<AssignmentPerCourse> asgsPerCourse = new List<AssignmentPerCourse>();
        public List<TrainerPerCourse> trPerCourse = new List<TrainerPerCourse>();
        public List<AssignmentPerStudent> asgmPerStudent = new List<AssignmentPerStudent>();


        public School()
        {
            
        }

    }
}
