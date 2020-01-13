using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Student
    {
        //private properties 
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private decimal _tuitionFees;

        //public properties
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public decimal TuitionFees {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }
        //Constructors
        
        //Set default values to avoid null reference.
        public Student()
        {
            FirstName = "DEFAULT";
            LastName = "DEFAULT";
            DateOfBirth = Convert.ToDateTime(new DateTime(1900,1,1));
            TuitionFees = 0;
        }
        public Student(string firstname,string lastname,DateTime date,decimal tuitionfees)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = date;
            TuitionFees = tuitionfees;
        }
       
    }
}
