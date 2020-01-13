using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Trainer
    {
        //private properties
        private string _firstName;
        private string _lastName;
        private string _subject;

        //public properties
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Subject {
            get { return _subject; }
            set { _subject = value; }
        }

        //Constructors
        //Set default values to avoid null reference.
        public Trainer()
        {
            FirstName = "DEFAULT";
            LastName = "DEFAULT";
            Subject = "DEFAULT";
        }

        public Trainer(string firstname,string lastname,string subject)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
        }
    }
}
