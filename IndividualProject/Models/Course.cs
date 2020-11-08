using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course : Trainer

    {
        private List<Trainer> trainers = new List<Trainer>();
        //private List<Student> students = new List<Student>();
        //private List<Assignment> assignments = new List<Assignment>();
        // as above with Student, assingment
        // 3 list student trainer assigment
        // oxi sto course


        private string _title;
        private string _stream;
        private string _type;
        private DateTime _startdate;
        private DateTime _enddate;

        public string Title
        {
            get { return (this._title); }
            set { this._title = value.ToUpper(); }
        }

        public string Stream
        {
            get { return (this._stream); }
            set { this._stream = value.ToUpper(); }
        }

        public string Type
        {
            get { return (this._type); }
            set { this._type = value; }
        }
        public string Dt1
        {
            get { return _startdate.ToString(); }
            set { DateTime.TryParse(value, out _startdate); }
        }
        public string Dt2
        {
            get { return _enddate.ToString(); }
            set { DateTime.TryParse(value , out _enddate); }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return ($"Title: {_title}\tStream: {_stream}\tType: {_type} \tStart Date: {_startdate.ToString("dd/MM/yyyy")}\tEnd Date: {_enddate.ToString("dd/MM/yyyy")}");
        }
    }
}
