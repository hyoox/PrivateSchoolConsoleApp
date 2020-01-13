//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PrivateSchool
//{
//    class Menu : School
//    {
//        //We check if the user wants to add the data manually or if i need to use the synthetic data i created.
//        public bool InputDataManually()
//        {
//            string input;
//            do
//            {
//                Console.WriteLine("Would you like to set your data manually? Type (Y/y) for yes and (N/n) for no.");
//                input = Console.ReadLine();
//                if (!input.ToUpper().Equals("Y") && !input.ToUpper().Equals("N"))
//                {
//                    Console.WriteLine("Wrong input!Please press a valid button!");
//                }
//            } while (!input.ToUpper().Equals("Y") && !input.ToUpper().Equals("N"));
//            if (input.ToUpper().Equals("Y"))
//            {
//                return true;
//            }
//            return false;
//        }
//        //Basic menu for the Synthetic Data choice.
//        public bool PrintSyntheticMenu()
//        {
//            int choice;
//            do
//            {
//                Console.WriteLine("----------Menu Choices-----------");
//                Console.WriteLine("1.Print Data.");
//                Console.WriteLine("2.Modify Data.");
//                Console.WriteLine("0.Exit");
//                choice = Convert.ToInt32(Console.ReadLine());
//                if (choice < 0 || choice > 2)
//                {
//                    Console.WriteLine("Wrong input! Try again!!");
//                }
//                if(choice == 0)
//                {
//                    return false;
//                }
//            } while (choice < 0 || choice > 2);
//            return true;
//        }
        
//        //Basic menu for the manual choice.
//        public void PrintBaseManualMenu()
//        {
//            try
//            {
//                int choice;
//                do
//                {
//                    Console.WriteLine("----------Menu Choices-----------");
//                    Console.WriteLine("1.Insert Data.");
//                    Console.WriteLine("2.Print Data.");
//                    Console.WriteLine("3.Modify Data.");
//                    Console.WriteLine("0.Exit");
//                    choice = Convert.ToInt32(Console.ReadLine());
//                    if (choice < 0 || choice > 3)
//                    {
//                        Console.WriteLine("Wrong input! Try again!!");
//                    }
//                } while (choice < 0 || choice > 3);

//                if (choice == 1)
//                {
//                    EntriesToSet();
//                }
//                else if (choice == 2)
//                {
//                    do
//                    {
//                        PrintData();
//                        choice = Convert.ToInt32(Console.ReadLine());
//                        if (choice < 1 || choice > 8)
//                        {
//                            Console.WriteLine("Wrong input! Try again!!");
//                        }
//                    } while (choice < 1 || choice > 8);
//                    PrintAllOfSelectedChoice(choice);
//                }
//                else if (choice == 3)
//                {
//                    ModifyData();
//                }
//                else
//                {
//                    Console.WriteLine("Ending program...");
//                    Environment.Exit(0); // command to exit the application.
//                }
//            }
//            catch(FormatException)
//            {
//                Console.WriteLine("Wrong input");
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
            
            
//        }
//        //Print all the choices.
//        public void PrintData()
//        {
//            Console.WriteLine("Print Menu");
//            Console.WriteLine("1.Print all students");
//            Console.WriteLine("2.Print all trainers");
//            Console.WriteLine("3.Print all courses");
//            Console.WriteLine("4.Print all assignments");
//            Console.WriteLine("5.Print all students per course");
//            Console.WriteLine("6.Print all trainers per course");
//            Console.WriteLine("7.Print all assignments per course");
//            Console.WriteLine("8.Print all assignments per student");
//            Console.WriteLine("9.Print all students that belong to more than one lesson.");
//            Console.WriteLine("10.List of students who should submit an assignment within a specific date.");
//        }
//        //Executes everything
//        public void Run()
//        {
//            int printDataChoice;
//            bool inputManually = InputDataManually();
//            if (!inputManually)
//            {
//                SyntheticData();
//                while (true)
//                {
//                    try
//                    {
//                        int choice;
//                        do
//                        {
//                            Console.WriteLine("----------Menu Choices-----------");
//                            Console.WriteLine("1.Print Data.");
//                            Console.WriteLine("2.Modify Data.");
//                            Console.WriteLine("0.Exit");
//                            choice = Convert.ToInt32(Console.ReadLine());
//                            if (choice < 0 || choice > 2)
//                            {
//                                Console.WriteLine("Wrong input! Try again!!");
//                            }
//                            if (choice == 0)
//                            {
//                                Environment.Exit(0);// Exit application
//                            }
//                        } while (choice < 0 || choice > 2);
//                        if(choice == 1)//Print Data function should be called.
//                        {
//                            do
//                            {
//                                PrintData();
//                                printDataChoice = Convert.ToInt32(Console.ReadLine());
//                                if (printDataChoice < 1 || printDataChoice > 10)
//                                {
//                                    Console.WriteLine("Wrong input! Number was out of bounds.Try again!");
//                                }
//                            } while (printDataChoice < 1 || printDataChoice > 10);
//                            PrintAllOfSelectedChoice(printDataChoice);
//                        }
//                        if (choice == 2) //Call modify data to insert a student to a course etc..
//                        {
//                            ModifyData();
//                        }
//                    }
//                    catch(FormatException)
//                    {
//                        Console.WriteLine("Wrong input!");
//                    }
//                    catch(Exception ex)
//                    {
//                        Console.WriteLine(ex.Message);
//                    }  
//                }
//            }
//            else
//            {
//                while (true)
//                {
//                    PrintBaseManualMenu();
//                }
//            }
//        }
        
//        //Check for the user input
//        private void EntriesToSet()
//        {
//            int entries;
//            do
//            {
//                Console.WriteLine("How many entries would you like to create?");
//                entries = Convert.ToInt32(Console.ReadLine());
//                if(entries < 0)
//                {
//                    Console.WriteLine("Number typed was less than 0. Please try a valid number.");
//                }
//            }while(entries < 0);

//            for(int i = 0; i < entries; i++)
//            {
//                string input;
//                int choice;
//                do
//                {
//                    Console.WriteLine("What type of entry would you like to make? Type the number that describes your entry type.");
//                    Console.WriteLine("1.Course");
//                    Console.WriteLine("2.Trainer");
//                    Console.WriteLine("3.Student");
//                    Console.WriteLine("4.Assignment");
//                    input = Console.ReadLine();
//                    if (int.TryParse(input, out choice) == false)
//                    {
//                        Console.WriteLine("Wrong input!Press a valid number.");
//                    }
//                } while (int.TryParse(input, out choice) == false && (choice < 1 || choice > 4));
//                PrintManualInputSwitch(choice);
//            }
//        }

//        //Is used to add add a student to a course etc...
//        private void ModifyData()
//        {
//            try
//            {
//                int choice;
//                do
//                {
//                    Console.WriteLine("1.Insert Student to Course");
//                    Console.WriteLine("2.Insert Assignment to Course ");
//                    Console.WriteLine("3.Insert Trainer to Course");
//                    Console.WriteLine("4.Insert Assignment to Student");
//                    choice = Convert.ToInt32(Console.ReadLine());
//                    if (choice < 1 || choice > 4)
//                    {
//                        Console.WriteLine("Wrong input! Try again.");
//                    }
//                } while (choice < 1 || choice > 4);
//                if (choice == 1)//Insert Student to a Course
//                {
//                    if (courseList.Count > 0 && studentList.Count > 0)
//                    {
//                        int st, cr;
//                        do
//                        {
//                            PrintAllStudents();
//                            Console.Write("Choose a student:");
//                            st = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (st < 0 || st > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (st < 0 || st > studentList.Count);
//                        do
//                        {
//                            PrintAllCourses();
//                            Console.Write("Choose a course: ");
//                            cr = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (cr < 0 || cr > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (cr < 0 || cr > courseList.Count);
//                        if (stdsPerCourse.Count == 0)
//                        {
//                            stdsPerCourse.Add(new StudentPerCourse(courseList[cr], studentList[st]));
//                        }
//                        else
//                        {
//                            int x = CourseExistsInStudent(cr);
//                            if (x == -1)//course was not found,so create a new entry in the list.
//                            {
//                                stdsPerCourse.Add(new StudentPerCourse(courseList[cr], studentList[st]));
//                            }
//                            else
//                            {
//                                AddToExistingList(x, studentList[st]);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("There were either no courses or students available.");
//                    }
//                }
//                else if (choice == 2)//Insert Assignment to a Course.
//                {
//                    if (courseList.Count > 0 && assignmentList.Count > 0)
//                    {
//                        int asg, cr;
//                        do
//                        {
//                            PrintAllAssignments();
//                            Console.Write("Choose an assignment:");
//                            asg = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (asg < 0 || asg > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (asg < 0 || asg > assignmentList.Count);
//                        do
//                        {
//                            PrintAllCourses();
//                            Console.Write("Choose a course: ");
//                            cr = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (cr < 0 || cr > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (cr < 0 || cr > courseList.Count);
//                        if (asgsPerCourse.Count == 0)
//                        {
//                            asgsPerCourse.Add(new AssignmentPerCourse(courseList[cr], assignmentList[asg]));
//                        }
//                        else
//                        {
//                            int x = CourseExistsInAssignment(cr);
//                            if (x == -1)//course was not found,so create a new entry in the list.
//                            {
//                                asgsPerCourse.Add(new AssignmentPerCourse(courseList[cr], assignmentList[asg]));
//                            }
//                            else
//                            {
//                                AddAssignmentToExistingList(x, assignmentList[asg]);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("There were either no courses or assignments available.");
//                    }
//                }
//                else if (choice == 3)//Insert trainer to course.
//                {
//                    if (courseList.Count > 0 && trainerList.Count > 0)
//                    {
//                        int tr, cr;
//                        do
//                        {
//                            PrintAllTrainers();
//                            Console.Write("Choose a trainer:");
//                            tr = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (tr < 0 || tr > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (tr < 0 || tr > trainerList.Count);
//                        do
//                        {
//                            PrintAllCourses();
//                            Console.Write("Choose a course: ");
//                            cr = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (cr < 0 || cr > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (cr < 0 || cr > courseList.Count);
//                        if (trPerCourse.Count == 0)
//                        {
//                            trPerCourse.Add(new TrainerPerCourse(courseList[cr], trainerList[tr]));
//                        }
//                        else
//                        {
//                            int x = CourseExistsInTrainer(cr);
//                            if (x == -1)//course was not found,so create a new entry in the list.
//                            {
//                                trPerCourse.Add(new TrainerPerCourse(courseList[cr], trainerList[tr]));
//                            }
//                            else
//                            {
//                                AddTrainerToExistingList(x, trainerList[tr]);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("There were either no courses or trainers available.");
//                    }
//                }
//                else//Add Assignment to Student
//                {
//                    if (assignmentList.Count > 0 && studentList.Count > 0)//If there are students and assignments
//                    {
//                        int st, asgm;
//                        do
//                        {
//                            PrintAllStudents();
//                            Console.Write("Choose a student:");
//                            st = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (st < 0 || st > studentList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (st < 0 || st > studentList.Count);
//                        do
//                        {
//                            PrintAllAssignments();
//                            Console.Write("Choose an assignment: ");
//                            asgm = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (asgm < 0 || asgm > assignmentList.Count)
//                            {
//                                Console.WriteLine("Wrong input!Try again.");
//                            }
//                        } while (asgm < 0 || asgm > assignmentList.Count);

//                        asgmPerStudent.Add(new AssignmentPerStudent(studentList[st], assignmentList[asgm]));
//                    }
//                    else
//                    {
//                        Console.WriteLine("There were either no students or assignments available.");
//                    }
//                }
//            }
//            catch (FormatException )
//            {
//                Console.WriteLine("Wrong input!!! You typed it all the way wrong.");
//                Console.WriteLine("Returning to Main Menu...");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }

//        //The method that fills the project with the synthetic data.
//        private void SyntheticData()
//        {
//            Student student1 = new Student("Ioannis", "Poulopoulos", new DateTime(1993, 12, 14), 1300);
//            Student student2 = new Student("Maria", "Papadopoulou", new DateTime(1998, 5, 5), 3200);
//            Student student3 = new Student("Nikos", "Kalantas", new DateTime(1978, 7, 13), 2100);
//            Student student4 = new Student("Niki", "Kalanta", new DateTime(2000, 3, 26), 200);
//            studentList.Add(student1);
//            studentList.Add(student2);
//            studentList.Add(student3);
//            studentList.Add(student4);

//            Course course1 = new Course("Coding Bootcamp 6", "Java", "Full-Time", new DateTime(2017, 3, 26), new DateTime(2017, 6, 26));
//            Course course2 = new Course("Coding Bootcamp 7", "Java", "Part-Time", new DateTime(2017, 8, 14), new DateTime(2017, 11, 14));
//            Course course3 = new Course("CB9", "C#", "Full-Time", new DateTime(2019, 10, 14), new DateTime(2020, 1, 18));
//            courseList.Add(course1);
//            courseList.Add(course2);
//            courseList.Add(course3);

//            Trainer trainer1 = new Trainer("Vyron", "Vasileiadis", "C#");
//            Trainer trainer2 = new Trainer("George", "Pasparakis", "Back-End");
//            Trainer trainer3 = new Trainer("Bill", "Gates", "Java");
//            Trainer trainer4 = new Trainer("Manolis", "Manolakis", "Javascript");
//            trainerList.Add(trainer1);
//            trainerList.Add(trainer2);
//            trainerList.Add(trainer3);
//            trainerList.Add(trainer4);

//            Assignment asgn1 = new Assignment("Individual Project A", "First Checkpoint", new DateTime(2019, 11, 4), 87, 96);
//            Assignment asgn2 = new Assignment("Individual Project B", "Second Checkpoint", new DateTime(2019, 12, 6), 68, 86);
//            Assignment asgn3 = new Assignment("Web Browser Application", "Web page", new DateTime(2019, 11, 28), 90, 98);
//            assignmentList.Add(asgn1);
//            assignmentList.Add(asgn2);
//            assignmentList.Add(asgn3);
//        }

//        //Used just to group up all the cases in a new method. 
//        //It is called in the manual menu,after the user types his valid choice. 
        
//        private void PrintManualInputSwitch(int input)
//        {
//            switch (input)
//            {
//                case 1:
//                    InsertCourseData();
//                    break;
//                case 2:
//                    InsertTrainerData();
//                    break;
//                case 3:
//                    InsertStudentData();
//                    break;
//                case 4:
//                    InsertAssignmentData();
//                    break;
//            }
//        }

//        //Switch with all the menu cases.
//        private void PrintAllOfSelectedChoice(int input)
//        {
//            int choice;
//            switch (input)
//            {
//                case 1:
//                    PrintAllStudents();
//                    break;
//                case 2:
//                    PrintAllTrainers();
//                    break;
//                case 3:
//                    PrintAllCourses();
//                    break;
//                case 4:
//                    PrintAllAssignments();
//                    break;
//                case 5:
//                    if (courseList.Count > 0)
//                    {
//                        do
//                        {
//                            PrintAllCourses();
//                            Console.Write("Choose a course to see the students: ");
//                            choice = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (choice < 0 || choice > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input.Try again!");
//                            }
//                        } while (choice < 0 || choice > courseList.Count);
//                        PrintStudentsInCourse(choice);
//                    }
//                    else
//                    {
//                        Console.WriteLine("No courses available.");
//                    }
//                    break;
//                case 6:
//                    if (courseList.Count > 0)
//                    {
//                        do
//                        {
//                            PrintAllCourses();
//                            Console.Write("Choose a course to see the trainers: ");
//                            choice = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (choice < 0 || choice > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input.Try again!");
//                            }
//                        } while (choice < 0 || choice > courseList.Count);
//                        PrintTrainersInCourse(choice);
//                    }
//                    else
//                    {
//                        Console.WriteLine("No courses available.");
//                    }
//                    break;
//                case 7:
//                    if (courseList.Count > 0)
//                    {
//                        do
//                        {
//                            PrintAllCourses();
//                            Console.Write("Choose a course to see the assignments: ");
//                            choice = Convert.ToInt32(Console.ReadLine()) - 1;
//                            if (choice < 0 || choice > courseList.Count)
//                            {
//                                Console.WriteLine("Wrong input.Try again!");
//                            }
//                        } while (choice < 0 || choice > courseList.Count);
//                        PrintAssignmentsInCourse(choice);
//                    }
//                    else
//                    {
//                        Console.WriteLine("No courses available.");
//                    }
//                    break;
//                    //case 8:
//                    //    if(studentList.Count > 0)
//                    //    {
//                    //        do
//                    //        {
//                    //            PrintAllStudents();
//                    //            Console.Write("Choose a student to see the assignments: ");
//                    //            choice = Convert.ToInt32(Console.ReadLine()) - 1;
//                    //            if (choice < 0 || choice > studentList.Count)
//                    //            {
//                    //                Console.WriteLine("Wrong input.Try again!");
//                    //            }
//                    //        } while (choice < 0 || choice > studentList.Count);
//                    //        AssignmentPerStudent.PrintAllAssignmentsPerStudent(studentList[choice]);
//                    //    }
//                    //    else
//                    //    {
//                    //        Console.WriteLine("No students available.");
//                    //    }
//                    //    break;
//                    //case 10:
//                    //    try
//                    //    {
//                    //        Console.Write("Enter a date:");
//                    //        DateTime date = Convert.ToDateTime(Console.ReadLine());
//                    //        AssignmentPerStudent.PrintAllStudentsThatHaveAssignmentInTheWeek(date);
//                    //    }
//                    //    catch(FormatException e)
//                    //    {
//                    //        Console.WriteLine("Wrong input! {0}",e.Message);
//                    //    }
//                    //    break;
//            }
//        }

//        //            STUDENTS
//        //Insert a student's data
//        public void InsertStudentData()
//        {
//            try
//            {
//                Student std = new Student();
//                Console.Write("Insert Student's First Name:");
//                std.FirstName = Console.ReadLine();

//                Console.Write("Insert Student's Last Name:");
//                std.LastName = Console.ReadLine();

//                Console.Write("Insert Student's Date Of Birth:");
//                std.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

//                Console.Write("Insert Student's Tuition Fees:");
//                std.TuitionFees = Convert.ToDecimal(Console.ReadLine());

//                studentList.Add(std);
//            }
//            catch (FormatException )
//            {
//                Console.WriteLine("Wrong input!!! You can't continue typing specified student's data.");
//                Console.WriteLine("Returning to Main Menu...");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }
//        //Print all students
//        public void PrintAllStudents()
//        {
//            for (int i = 0; i < studentList.Count; i++)
//            {
//                Console.WriteLine("Entry No{0}", (i + 1));
//                Console.WriteLine("{0,-15} ---> {1,-15}", "First name: ", studentList.ElementAt(i).FirstName);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Last name: ", studentList.ElementAt(i).LastName);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Date of Birth: ", studentList.ElementAt(i).DateOfBirth);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Tuition fees: ", studentList.ElementAt(i).TuitionFees);
//            }
//        }

//        //            COURSES
//        //Insert course's data
//        public void InsertCourseData()
//        {
//            try
//            {
//                Course crs = new Course();
//                Console.Write("Insert Course's Title:");
//                crs.Title = Console.ReadLine();

//                Console.Write("Insert Course's Stream:");
//                crs.Stream = Console.ReadLine();

//                Console.Write("Insert Course's Type:");
//                crs.Type = Console.ReadLine();

//                Console.Write("Insert Course's Starting Date:");
//                crs.StartDate = Convert.ToDateTime(Console.ReadLine());

//                Console.Write("Insert Course's Ending Date:");

//                crs.StartDate = Convert.ToDateTime(Console.ReadLine());

//                courseList.Add(crs);
//            }
//            catch (FormatException )
//            {
//                Console.WriteLine("Wrong input!!! You can't continue typing specified course's data.");
//                Console.WriteLine("Returning to Main Menu...");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }

//        //Print all courses
//        public void PrintAllCourses()
//        {
//            for (int i = 0; i < courseList.Count; i++)
//            {
//                Console.WriteLine("Entry No{0}", (i + 1));
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Title: ", courseList.ElementAt(i).Title);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Stream: ", courseList.ElementAt(i).Stream);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Type: ", courseList.ElementAt(i).Type);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Start Date: ", courseList.ElementAt(i).StartDate);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "End Date: ", courseList.ElementAt(i).EndDate);
//            }
//        }
//        //           ASSIGNMENTS
//        //Insert an assignments data.
//        public void InsertAssignmentData()
//        {
//            try
//            {
//                Assignment asg = new Assignment();

//                Console.Write("Insert Assignment Title:");
//                asg.Title = Console.ReadLine();

//                Console.Write("Insert Assignment Description:");
//                asg.Description = Console.ReadLine();

//                Console.Write("Insert Assignment Submission Date:");
//                asg.SubDateTime = Convert.ToDateTime(Console.ReadLine());

//                Console.Write("Insert Assignment's Oral Mark:");
//                asg.OralMark = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Insert Assignment's Total Mark:");
//                asg.TotalMark = Convert.ToInt32(Console.ReadLine());

//                assignmentList.Add(asg);
//            }
//            catch (FormatException )
//            {
//                Console.WriteLine("Wrong input!!! You can't continue typing specified assignment's data.");
//                Console.WriteLine("Returning to Main Menu...");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }

//        //Print all assignments
//        public void PrintAllAssignments()
//        {
//            for (int i = 0; i < assignmentList.Count; i++)
//            {
//                Console.WriteLine("Entry No{0}", (i + 1));
//                Console.WriteLine("{0,-20} ---> {1,-15}", "Title: ", assignmentList.ElementAt(i).Title);
//                Console.WriteLine("{0,-20} ---> {1,-15}", "Description: ", assignmentList.ElementAt(i).Description);
//                Console.WriteLine("{0,-20} ---> {1,-15}", "Submission date: ", assignmentList.ElementAt(i).SubDateTime);
//                Console.WriteLine("{0,-20} ---> {1,-15}", "Oral Mark: ", assignmentList.ElementAt(i).OralMark);
//                Console.WriteLine("{0,-20} ---> {1,-15}", "Total Mark: ", assignmentList.ElementAt(i).TotalMark);
//            }
//        }
//        //             TRAINERS
//        //Insert trainer's data
//        public void InsertTrainerData()
//        {
//            try
//            {
//                Trainer tr = new Trainer();

//                Console.Write("Insert Trainer's First Name:");
//                tr.FirstName = Console.ReadLine();

//                Console.Write("Insert Trainer's Last Name:");
//                tr.LastName = Console.ReadLine();

//                Console.Write("Insert Trainer's Subject:");
//                tr.Subject = Console.ReadLine();

//                trainerList.Add(tr);
//            }
//            catch (FormatException )
//            {
//                Console.WriteLine("Wrong input!!! You can't continue typing specified trainer's data.");
//                Console.WriteLine("Returning to Main Menu...");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }

//        //Print all trainers
//        public void PrintAllTrainers()
//        {
//            for (int i = 0; i < trainerList.Count; i++)
//            {
//                Console.WriteLine("Entry No{0}", (i + 1));
//                Console.WriteLine("{0,-15} ---> {1,-15}", "First name: ", trainerList.ElementAt(i).FirstName);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Last name: ", trainerList.ElementAt(i).LastName);
//                Console.WriteLine("{0,-15} ---> {1,-15}", "Subject: ", trainerList.ElementAt(i).Subject);
//            }
//        }

//        //Print all students in a course
//        public void PrintStudentsInCourse(int choice)
//        {
//            int exists = CourseExistsInStudent(choice);
//            if (exists != -1)
//            {
//                Console.WriteLine("Students in course: {0}", stdsPerCourse.ElementAt(exists).Course.Title);
//                foreach (Student s in stdsPerCourse.ElementAt(exists).studentsPerCourse)
//                {
//                    Console.WriteLine("First name: {0}---Last name: {1}", s.FirstName, s.LastName);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Course not found...");
//            }
            
//        }

//        //Add student to an existing list
//        public void AddToExistingList(int choice, Student st)
//        {

//            stdsPerCourse.ElementAt(choice).studentsPerCourse.Add(st);
//        }
//        public int CourseExistsInStudent(int choice)
//        {
//            int target = -1;
//            for (int i = 0; i < stdsPerCourse.Count; i++)
//            {
//                if (courseList[choice].Title == stdsPerCourse.ElementAt(i).Course.Title && courseList[choice].Stream == stdsPerCourse.ElementAt(i).Course.Stream &&
//                    courseList[choice].Type == stdsPerCourse.ElementAt(i).Course.Type && courseList[choice].StartDate == stdsPerCourse.ElementAt(i).Course.StartDate &&
//                    courseList[choice].EndDate == stdsPerCourse.ElementAt(i).Course.EndDate)
//                {
//                    target = i;
//                    break;
//                }
//            }
//            return target;
//        }
        
//        public int StudentExists(int choice)
//        {
//            int target = -1;
//            for (int i = 0; i < stdsPerCourse.Count; i++)
//            {
//                if (studentList[choice].FirstName == stdsPerCourse.ElementAt(i).studentsPerCourse.ElementAt(i).FirstName &&
//                    studentList[choice].LastName == stdsPerCourse.ElementAt(i).studentsPerCourse.ElementAt(i).LastName &&
//                    studentList[choice].DateOfBirth == stdsPerCourse.ElementAt(i).studentsPerCourse.ElementAt(i).DateOfBirth &&
//                    studentList[choice].TuitionFees == stdsPerCourse.ElementAt(i).studentsPerCourse.ElementAt(i).TuitionFees)
//                {
//                    target = i;
//                    break;
//                }
//            }
//            return target;
//        }
//        //Print all trainers in a course.
//        public void PrintTrainersInCourse(int choice)
//        {
//            int exists = CourseExistsInTrainer(choice);
//            if (exists != -1)
//            {
//                Console.WriteLine("Trainers in course: {0}", trPerCourse.ElementAt(exists).Course.Title);
//                foreach (Trainer t in trPerCourse.ElementAt(exists).trainersInCourse)
//                {
//                    Console.WriteLine("{0}---{1}", t.FirstName, t.LastName);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Course not found...");
//            }

//        }
//        //Add trainer to an existing list.
//        public void AddTrainerToExistingList(int choice, Trainer tr)
//        {

//            trPerCourse.ElementAt(choice).trainersInCourse.Add(tr);
//        }
//        public int CourseExistsInTrainer(int choice)
//        {
//            int target = -1;
//            for (int i = 0; i < trPerCourse.Count; i++)
//            {
//                if (courseList[choice].Title == trPerCourse.ElementAt(i).Course.Title && courseList[choice].Stream == trPerCourse.ElementAt(i).Course.Stream &&
//                    courseList[choice].Type == trPerCourse.ElementAt(i).Course.Type && courseList[choice].StartDate == trPerCourse.ElementAt(i).Course.StartDate &&
//                    courseList[choice].EndDate == trPerCourse.ElementAt(i).Course.EndDate)
//                {
//                    target = i;
//                    break;
//                }
//            }
//            return target;
//        }

//        //Print all assignments in a course
//        public void PrintAssignmentsInCourse(int choice)
//        {
//            int exists = CourseExistsInAssignment(choice);
//            if (exists != -1)
//            {
//                Console.WriteLine("Assignments in course: {0}", asgsPerCourse.ElementAt(exists).Course.Title);
//                foreach (Assignment s in asgsPerCourse.ElementAt(exists).asgmsPerCourse)
//                {
//                    Console.WriteLine("Assignment title: {0}---Assignment description: {1}", s.Title, s.Description);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Course not found...");
//            }
//        }
//        public int CourseExistsInAssignment(int choice)
//        {
//            int target = -1;
//            for (int i = 0; i < asgsPerCourse.Count; i++)
//            {
//                if (courseList[choice].Title == asgsPerCourse.ElementAt(i).Course.Title && courseList[choice].Stream == asgsPerCourse.ElementAt(i).Course.Stream &&
//                    courseList[choice].Type == asgsPerCourse.ElementAt(i).Course.Type && courseList[choice].StartDate == asgsPerCourse.ElementAt(i).Course.StartDate &&
//                    courseList[choice].EndDate == asgsPerCourse.ElementAt(i).Course.EndDate)
//                {
//                    target = i;
//                    break;
//                }
//            }
//            return target;
//        }
//        public void AddAssignmentToExistingList(int choice, Assignment asg)
//        {

//            asgsPerCourse.ElementAt(choice).asgmsPerCourse.Add(asg);
//        }

       
        
//    }
//}
