using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Course
    {
        //private properties
        private string _title;
        private string _stream; //Java or C#.
        private string _type;
        private DateTime _start_Date;
        private DateTime _end_Date;

        //public properties
        public string Title {
            get { return _title; }
            set { _title = value; }
        }

        public string Stream {
            get { return _stream; }
            set { _stream = value; }
        }

        public string Type {
            get { return _type; }
            set { _type = value; }
        }

        public DateTime StartDate {
            get { return _start_Date; }
            set { _start_Date = value; }
        }

        public DateTime EndDate {
            get { return _end_Date; }
            set { _end_Date = value; }
        }
        //Constructors
        
        //Set default values to avoid null reference.
        public Course()
        {
            Title = "DEFAULT";
            Stream = "DEFAULT";
            Type = "DEFAULT";
            StartDate = Convert.ToDateTime(new DateTime(1900, 1, 1)); ;
            EndDate = Convert.ToDateTime(new DateTime(1900, 1, 1)); ;
        }
        public Course(string title,string stream,string type,DateTime startDate,DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }
        
    }
}
