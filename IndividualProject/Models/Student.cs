using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student : Course
    {

        private List<Student> students = new List<Student>();
        private string _firstname;
        private string _lastname;
        private float _tuitionfees;
        private DateTime _dateofbirth;


        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value.ToUpper(); }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        }

        public float TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; }
        }

        public string dt
        {
            get { return _dateofbirth.ToString(); }
            set { DateTime.TryParse(value, out _dateofbirth); }
            
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
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tTuition fees: {_tuitionfees}\tDate of birth: {_dateofbirth.ToString("dd/MM/yyyy")}");
        }

        
    }
}
