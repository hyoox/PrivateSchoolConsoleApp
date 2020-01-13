using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Databases
    {
        private string _connectionString = @"Data Source=LAPTOP-6LDKI96P\SQLEXPRESS;Initial Catalog = PrivateSchool; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #region//Print menu choices
        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("----Print Menu Choices:-----");
            Console.WriteLine();
            Console.WriteLine("1.Print all students");
            Console.WriteLine("2.Print all trainers");
            Console.WriteLine("3.Print all assignments");
            Console.WriteLine("4.Print all courses");
            Console.WriteLine("5.Print all students per course");
            Console.WriteLine("6.Print all trainers per course");
            Console.WriteLine("7.Print all assignments per course");
            Console.WriteLine("8.Print all assignments per student");
            Console.WriteLine("9.Print all students that belong to more than one courses");
            Console.WriteLine();
            Console.WriteLine("------Insert Data Choices:");
            Console.WriteLine();
            Console.WriteLine("10.Insert a student");
            Console.WriteLine("11.Insert a trainer");
            Console.WriteLine("12.Insert a assignment");
            Console.WriteLine("13.Insert a course");
            Console.WriteLine("14.Insert a student to a course");
            Console.WriteLine("15.Insert a trainer to a course");
            Console.WriteLine("16.Insert a assignment to a student");
            Console.WriteLine("0.Exit");
        }
        #endregion
        #region//1.Print all students
        public void PrintAllStudents()
        {
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["student_Id"];
                            string firstname = (string)reader["FirstName"];
                            string lastname = (string)reader["LastName"];
                            DateTime date = (DateTime)reader["DateOfBirth"];
                            decimal tuitionfees = (decimal)reader["TuitionFees"];

                            Console.WriteLine($"{id} | {firstname} | {lastname} | {date.ToLongDateString()} | {tuitionfees}euros");
                        }
                    }
                }
            }
        }
        #endregion
        #region//2.Print all trainers
        public void PrintAllTrainers()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Trainer", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["trainer_Id"];
                            string firstname = (string)reader["FirstName"];
                            string lastname = (string)reader["LastName"];
                            string subject = (string)reader["Subject"];

                            Console.WriteLine($"{id}  {firstname} | {lastname} | {subject}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//3.Print all assignments
        public void PrintAllAssignments()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Assignment", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["assignment_Id"];
                            string title = (string)reader["Title"];
                            string description = (string)reader["Description"];
                            DateTime subdate = (DateTime)reader["SubDateTime"];
                            int oralmark = (int)reader["OralMark"];
                            int totalmark = (int)reader["TotalMark"];

                            Console.WriteLine($"{id} | {title} | {description} | {subdate.ToLongDateString()} | Oral mark:{oralmark} | Total mark:{totalmark}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//4.Print all courses
        public void PrintAllCourses()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Course", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["course_Id"];
                            string title = (string)reader["Title"];
                            string stream = (string)reader["Stream"];
                            string type = (string)reader["Type"];
                            DateTime startdate = (DateTime)reader["StartDate"];
                            DateTime enddate = (DateTime)reader["EndDate"];

                            Console.WriteLine($"{id} | {title} | {stream} | {type} | {startdate.ToLongDateString()} | {enddate.ToLongDateString()}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//5.Print all students per course
        public void PrintAllStudentsPerCourse()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT StudentPerCourse.course_Id,Course.Title,Course.Stream,Course.Type,FirstName,LastName FROM StudentPerCourse " +
                    "INNER JOIN Course ON StudentPerCourse.course_Id = Course.course_Id " +
                    "INNER JOIN Student ON StudentPerCourse.student_Id = Student.student_Id " +
                    "ORDER BY StudentPerCourse.course_Id", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["course_Id"];
                            string title = (string)reader["Title"];
                            string stream = (string)reader["Stream"];
                            string type = (string)reader["Type"];
                            string firstname = (string)reader["FirstName"];
                            string lastname = (string)reader["LastName"];

                            Console.WriteLine($"Course's id:{id} |Course's info: {title} | {stream} | {type} | Student's info: {firstname} | {lastname}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//6.Print all trainers per course
        public void PrintAllTrainersPerCourse()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT TrainerPerCourse.course_Id,Course.Title,Course.Stream,Course.Type,FirstName,LastName,Trainer.Subject " +
                    "FROM TrainerPerCourse INNER JOIN Course ON TrainerPerCourse.course_Id = Course.course_Id " +
                    "INNER JOIN Trainer ON TrainerPerCourse.trainer_Id = Trainer.trainer_Id " +
                    "ORDER BY TrainerPerCourse.course_Id", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["course_Id"];
                            string title = (string)reader["Title"];
                            string stream = (string)reader["Stream"];
                            string type = (string)reader["Type"];
                            string firstname = (string)reader["FirstName"];
                            string lastname = (string)reader["LastName"];
                            string subject = (string)reader["Subject"];

                            Console.WriteLine($"Course's id:{id} |Course's info: {title} | {stream} | {type} | Trainer's info: {firstname} | {lastname} | {subject}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//7.Print all assignments per course
        public void PrintAllAssignmentsPerCourse()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT AssignmentPerCourse.course_Id,Course.Title,Course.Stream,Course.Type,Assignment.Title as '@AsTitle',Assignment.Description,SubDateTime " +
                    "FROM AssignmentPerCourse INNER JOIN Course ON AssignmentPerCourse.course_Id = Course.course_Id " +
                    "INNER JOIN Assignment ON AssignmentPerCourse.assignment_Id = Assignment.assignment_Id " +
                    "ORDER BY AssignmentPerCourse.course_Id", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["course_Id"];
                            string title = (string)reader["Title"];
                            string stream = (string)reader["Stream"];
                            string type = (string)reader["Type"];
                            string assignmentTitle = (string)reader["@AsTitle"];
                            string description = (string)reader["Description"];
                            DateTime date = (DateTime)reader["SubDateTime"];

                            Console.WriteLine($"Course's id:{id} |Course's info: {title} | {stream} | {type} | Assignment's info: {assignmentTitle} | {description} | Submission date:{date.ToShortDateString()}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//8.Print all assignments per student per course
        public void PrintAllAssignmentsPerStudentPerCourse()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT FirstName,LastName, Assignment.Title as '@AsTitle',Description,SubDateTime,Course.Title as '@CoTitle',Stream,Type " +
                    "FROM AssignmentPerStudent INNER JOIN Course ON AssignmentPerStudent.course_Id = Course.course_Id " +
                    "INNER JOIN Student ON AssignmentPerStudent.student_Id = Student.student_Id " +
                    "INNER JOIN Assignment ON AssignmentPerStudent.assignment_Id = Assignment.assignment_Id " +
                    "ORDER BY AssignmentPerStudent.course_Id", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstname = (string)reader["FirstName"];
                            string lastname = (string)reader["LastName"];
                            string assignmenttitle = (string)reader["@AsTitle"];
                            string description = (string)reader["Description"];
                            DateTime date = (DateTime)reader["SubDateTime"];
                            string coursetitle = (string)reader["@CoTitle"];
                            string stream = (string)reader["Stream"];
                            string type = (string)reader["Type"];

                            Console.WriteLine($"Student's info:{firstname} | {lastname} | Assignment's info: {assignmenttitle} | {description} | Submission date:{date.ToShortDateString()} | Course's info: {coursetitle} | {stream} | {type}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//9.Print all students with more than one course
        public void PrintAllStudentsWithMoreThanOneCourse()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT FirstName,LastName,COUNT(StudentPerCourse.course_Id) as '@courseSum' " +
                    "FROM StudentPerCourse INNER JOIN Course ON StudentPerCourse.course_Id = Course.course_Id " +
                    "INNER JOIN Student ON StudentPerCourse.student_Id = Student.student_Id " +
                    "GROUP BY FirstName, LastName HAVING COUNT(StudentPerCourse.course_Id) > 1", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstname = (string)reader["FirstName"];
                            string lastname = (string)reader["LastName"];
                            int totalCourses = (int)reader["@courseSum"];
                            
                            Console.WriteLine($"Student's info:{firstname} | {lastname} | Number of courses attending: {totalCourses}");
                        }
                    }
                }
            }
        }
        #endregion
        #region//10.Insert data and student to database
        public void AddStudent()
        {
            string firstName="", lastName="";
            DateTime dateofBirth = new DateTime(1900,1,1);
            decimal tuitionFees=-1;
            try
            {
                Console.Write("Insert Student's First Name:");
                firstName = Console.ReadLine();

                Console.Write("Insert Student's Last Name:");
                lastName = Console.ReadLine();

                Console.Write("Insert Student's Date Of Birth:");
                dateofBirth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Insert Student's Tuition Fees:");
                tuitionFees = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!!! You can't continue typing specified student's data.");
                Console.WriteLine("Returning to Main Menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)" +
                    $" VALUES (@FirstName,@LastName,@DateOfBirth,@TuitionFees)", conn))
                {
                    if(!firstName.Equals("") && !lastName.Equals("") && dateofBirth.Year > 1900 && tuitionFees > -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
                        cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
                        cmd.Parameters.Add(new SqlParameter("@DateOfBirth", dateofBirth));
                        cmd.Parameters.Add(new SqlParameter("@TuitionFees", tuitionFees));
                        
                        Console.WriteLine("Entry created.");

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine("Entry not created.Not all required fields were valid.Try again.");
                        if (dateofBirth.Year <= 1900)
                        {
                            Console.WriteLine("Year should be after 1900! Try again.");
                        }
                        else if (tuitionFees <= -1)
                        {
                            Console.WriteLine("Tuition fees must be greater or equal to 0.Try again.");
                        }
                    }
                }
            }
        }
        #endregion
        #region//11.Insert data and trainer to database
        public void AddTrainer()
        {
            string firstName = "", lastName = "",subject = "";
            try
            {
                Console.Write("Insert Trainer's First Name:");
                firstName = Console.ReadLine();

                Console.Write("Insert Trainer's Last Name:");
                lastName = Console.ReadLine();

                Console.Write("Insert Trainer's Subject:");
                subject = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!!! You can't continue typing specified trainer's data.");
                Console.WriteLine("Returning to Main Menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Trainer(FirstName,LastName,Subject)" +
                    $" VALUES (@FirstName,@LastName,@Subject)", conn))
                {
                    if (!firstName.Equals("") && !lastName.Equals("") && !subject.Equals(""))
                    {
                        cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
                        cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
                        cmd.Parameters.Add(new SqlParameter("@Subject", subject));

                        Console.WriteLine("Entry created.");

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine("Entry not created. At least one of the required fields was empty.Try again.");
                    }
                }
            }
        }
        #endregion
        #region//12.Insert data and assignment to database
        public void AddAssignment()
        {
            string title = "", description = "";
            DateTime subdate = new DateTime(1900, 1, 1);
            int oralmark = -1, totalmark = -1 ;
            try
            {
                Console.Write("Insert Assignment's Title:");
                title = Console.ReadLine();

                Console.Write("Insert Assignment's Description:");
                description = Console.ReadLine();

                Console.Write("Insert Assignment's Submission Date:");
                subdate = Convert.ToDateTime(Console.ReadLine());
                
                Console.Write("Insert Assignment's Oral Mark:");
                oralmark = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Insert Assignment's Total Mark:");
                totalmark = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!!! You can't continue typing specified trainer's data.");
                Console.WriteLine("Returning to Main Menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Assignment(Title,Description,SubDateTime,OralMark,TotalMark)" +
                    $" VALUES (@Title,@Description,@SubDateTime,@OralMark,@TotalMark)", conn))
                {
                    if (!title.Equals("") && !description.Equals("") && subdate.Year >1900 
                        && oralmark > -1 && totalmark > -1 && totalmark >= oralmark && totalmark <= 100)
                    {
                        cmd.Parameters.Add(new SqlParameter("@Title", title));
                        cmd.Parameters.Add(new SqlParameter("@Description", description));
                        cmd.Parameters.Add(new SqlParameter("@SubDateTime", subdate));
                        cmd.Parameters.Add(new SqlParameter("@OralMark", oralmark));
                        cmd.Parameters.Add(new SqlParameter("@TotalMark", totalmark));
                        Console.WriteLine("Entry created.");
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine("Entry not created.Not all required fields were valid.Try again.");
                        if (totalmark < oralmark || totalmark > 100)
                        {
                            Console.WriteLine("Total and oral mark should both be lower than 100 and total mark must be greater than the oral mark!!");
                        }
                        else
                        {
                            Console.WriteLine("Date was out of bounds.Year should be after 1900.");
                        }
                    }
                    
                }
            }
        }
        #endregion
        #region//13.Insert data and course to database
        public void AddCourse()
        {
            string title = "", stream = "", type = "";
            DateTime startdate = new DateTime(1900, 1, 1), enddate = new DateTime(1900, 1, 1);
            try
            {
                Console.Write("Insert Course's Title:");
                title = Console.ReadLine();

                Console.Write("Insert Course's Stream:");
                stream = Console.ReadLine();

                Console.Write("Insert Course's Type:");
                type = Console.ReadLine();

                Console.Write("Insert Course's Start Date:");
                startdate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Insert Course's End Date:");
                enddate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!!! You can't continue typing specified trainer's data.");
                Console.WriteLine("Returning to Main Menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Course(Title,Stream,Type,StartDate,EndDate)" +
                    $" VALUES (@Title,@Stream,@Type,@StartDate,@EndDate)", conn))
                {
                    int isDateValid = enddate.CompareTo(startdate); //Earlier returns -1,later returns 1 same returns 0
                    if (!title.Equals("") && !stream.Equals("") && !type.Equals("")
                        && startdate.Year > 1900 && enddate.Year > 1900 && isDateValid != -1 )
                    {
                        cmd.Parameters.Add(new SqlParameter("@Title", title));
                        cmd.Parameters.Add(new SqlParameter("@Stream", stream));
                        cmd.Parameters.Add(new SqlParameter("@Type", type));
                        cmd.Parameters.Add(new SqlParameter("@StartDate", enddate));
                        cmd.Parameters.Add(new SqlParameter("@EndDate", startdate));
                        Console.WriteLine("Entry created.");
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine("Entry not created.Not all required fields were valid.Try again.");
                        if (isDateValid ==-1)
                        {
                            Console.WriteLine("End date cannot be before the start date! Year should be after 1900! Try again.");
                        }
                    }

                }
            }
        }
        #endregion
        #region//14.Insert student to a course
        public void InsertStudentToCourse()
        {
            try
            {
                int totalstudents = 0, totalcourses = 0;
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 student_Id FROM Student ORDER BY student_Id DESC", conn))
                    {
                        totalstudents = (int)cmd.ExecuteScalar();//find the max id an entry has right now.
                    }
                }
                int choiceStudent;
                do
                {
                    PrintAllStudents();
                    Console.Write("Choose a student:");
                    choiceStudent = Convert.ToInt32(Console.ReadLine());
                } while (choiceStudent < 1 || choiceStudent > totalstudents);

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 course_Id FROM Course ORDER BY course_Id DESC", conn))
                    {
                        totalcourses = (int)cmd.ExecuteScalar();//find the max id an entry has right now.
                    }
                }
                int choiceCourse;
                do
                {
                    PrintAllCourses();
                    Console.Write("Choose a course:");
                    choiceCourse = Convert.ToInt32(Console.ReadLine());
                } while (choiceCourse < 1 || choiceCourse > totalcourses);

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO StudentPerCourse (course_Id,student_Id) VALUES (@course_Id,@student_Id)", conn))
                {
                        cmd.Parameters.Add(new SqlParameter("@course_Id", choiceCourse));
                        cmd.Parameters.Add(new SqlParameter("@student_Id", choiceStudent));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        #endregion
        #region//15.Insert trainer to a course
        public void InsertTrainerToCourse()
        {
            try
            {
                int totaltrainers = 0, totalcourses = 0;
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 trainer_Id FROM Trainer ORDER BY trainer_Id DESC", conn))
                    {
                        totaltrainers = (int)cmd.ExecuteScalar();//find the max id an entry has right now.
                    }
                }
                int choiceTrainer;
                do
                {
                    PrintAllTrainers();
                    Console.Write("Choose a trainer:");
                    choiceTrainer = Convert.ToInt32(Console.ReadLine());
                } while (choiceTrainer < 1 || choiceTrainer > totaltrainers);

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 course_Id FROM Course ORDER BY course_Id DESC", conn))
                    {
                        totalcourses = (int)cmd.ExecuteScalar();//find the max id an entry has right now.
                    }
                }
                int choiceCourse;
                do
                {
                    PrintAllCourses();
                    Console.Write("Choose a course:");
                    choiceCourse = Convert.ToInt32(Console.ReadLine());
                } while (choiceCourse < 1 || choiceCourse > totalcourses);

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO TrainerPerCourse (trainer_Id,course_Id) VALUES (@trainer_Id,@course_Id)", conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@trainer_Id", choiceTrainer));
                        cmd.Parameters.Add(new SqlParameter("@course_Id", choiceCourse));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
        #region//Run
        public void Run()
        {
            try
            {
                int choice;
                while (true)
                {
                    do
                    {
                        PrintMenu();
                        Console.WriteLine();
                        Console.Write("Enter your choice:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice < 0 || choice > 16)
                        {
                            Console.WriteLine("Wrong input!Try a number between 0 and 16!");
                        }
                    } while (choice < 0 || choice > 16);
                    Console.WriteLine();
                    SwitchForAllCases(choice);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
        #region//A switch statement which includes all choices
        public void SwitchForAllCases(int choice)
        {
            switch (choice)
            {
                case 1:
                    PrintAllStudents();
                    break;
                case 2:
                    PrintAllTrainers();
                    break;
                case 3:
                    PrintAllAssignments();
                    break;
                case 4:
                    PrintAllCourses();
                    break;
                case 5:
                    PrintAllStudentsPerCourse();
                    break;
                case 6:
                    PrintAllTrainersPerCourse();
                    break;
                case 7:
                    PrintAllAssignmentsPerCourse();
                    break;
                case 8:
                    PrintAllAssignmentsPerStudentPerCourse();
                    break;
                case 9:
                    PrintAllStudentsWithMoreThanOneCourse();
                    break;
                case 10:
                    AddStudent();
                    break;
                case 11:
                    AddTrainer();
                    break;
                case 12:
                    AddAssignment();
                    break;
                case 13:
                    AddCourse();
                    break;
                case 14:
                    InsertStudentToCourse();
                    break;
                case 15:
                    InsertTrainerToCourse();
                    break;
                case 16:
                    Console.WriteLine("Not done.");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        #endregion
    }
}
