using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class AssignmentPerStudent : School
    {
        //List of assignments and a student
        private Student student { get; set; }
        public List<Assignment> listOfAssignmentsPerStudent = new List<Assignment>();
        //Constructors
        

        public AssignmentPerStudent(Student std,Assignment asgmt)
        {
            student = std;
            listOfAssignmentsPerStudent.Add(asgmt);
        }
        //Prints all assignments per student
        public void PrintAllAssignmentsPerStudent(Student std)
        {
            Console.WriteLine("Student's {0} {1} assignments:", std.FirstName, std.LastName);
            foreach (Assignment asg in listOfAssignmentsPerStudent)
            {
                Console.WriteLine("Assignment:{0}", asg.Title);
            }
        }
        //All students that have an assignment in the week.
        public void PrintAllStudentsThatHaveAssignmentInTheWeek(DateTime date)
        {
            bool isInWeek = false;
            Console.WriteLine("Students that have an assignment this week:");
            //foreach(StudentPerCourse st in stdsPerCourse) { }
            for(int i=0;i< listOfAssignmentsPerStudent.Count;i++)
            {
                isInWeek = AssgsInWeek(date, listOfAssignmentsPerStudent[i].SubDateTime);
                if (isInWeek)
                {
                    Console.WriteLine("{0}---{1}",student.FirstName,student.LastName);
                }
            }
        }
        //Calculates the span between the given date and each assignment's submission date.
        public bool AssgsInWeek(DateTime input, DateTime assgDate)
        {
            TimeSpan span = input.Subtract(assgDate);
            if (span.TotalDays < 6 || span.TotalDays > -6)
            {
                switch (input.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        if (span.TotalDays <= 4 && span.TotalDays >= 0)
                        {
                            return true;
                        }
                        break;
                    case DayOfWeek.Tuesday:
                        if (span.TotalDays <= 3 && span.TotalDays >= -1)
                        {
                            return true;
                        }
                        break;
                    case DayOfWeek.Wednesday:
                        if (span.TotalDays <= 2 && span.TotalDays >= -2)
                        {
                            return true;
                        }
                        break;
                    case DayOfWeek.Thursday:
                        if (span.TotalDays <= 1 && span.TotalDays >= -3)
                        {
                            return true;
                        }
                        break;
                    case DayOfWeek.Friday:
                        if (span.TotalDays <= 0 && span.TotalDays >= -4)
                        {
                            return true;
                        }
                        break;
                    case DayOfWeek.Saturday:
                        if (span.TotalDays <= 0 && span.TotalDays >= -5)
                        {
                            return true;
                        }
                        break;
                    case DayOfWeek.Sunday:
                        if (span.TotalDays <= 0 && span.TotalDays >= -6)
                        {
                            return true;
                        }
                        break;
                }
            }
            return false;
        }
    }
}
