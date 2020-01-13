using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class TrainerPerCourse
    {
        public Course Course;
        public List<Trainer> trainersInCourse = new List<Trainer>();

        public TrainerPerCourse(Course course, Trainer tr)
        {
            Course = course;
            trainersInCourse.Add(tr);
        }
    }
}
