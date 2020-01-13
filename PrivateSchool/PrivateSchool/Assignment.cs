using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Assignment
    {
        //private properties
        private string _title;
        private string _description;
        private DateTime _subDateTime;
        private int _oralMark;
        private int _totalMark;

        //public properties
        public string Title {
            get { return _title; }
            set { _title = value; }
        }

        public string Description {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime SubDateTime {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }

        public int OralMark {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        public int TotalMark {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        //Constructors
        
        //Set default values to avoid null reference.
        public Assignment()
        {
            Title = "DEFAULT";
            Description = "DEFAULT";
            SubDateTime = Convert.ToDateTime(new DateTime(1900,1,1));
            OralMark = 0;
            TotalMark = 0;
        }

        public Assignment(string title,string description,DateTime submissionDate, int oralMark, int totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = submissionDate;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
        
    }
}
