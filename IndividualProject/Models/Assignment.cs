using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Assignment
    { 
    private string _title;
    private string _decreption;
    private DateTime _subdatetime;
    private string _getoralmark;
    private string _gettotalmark;




    public string Title
    {
        get { return (this._title); }
        set { this._title = value.ToUpper(); }
    }

    public string Decreption
    {
        get { return (this._decreption); }
        set { this._decreption = value.ToUpper(); }
    }

        public string SubDateTime
        {
            get { return _subdatetime.ToString(); }
            set { DateTime.TryParse(value, out _subdatetime); }

        }
        public string GetOralMark
        {
            get { return (this._getoralmark); }
            set { this._getoralmark = value.ToUpper(); }
        }
        public string GetTotalMark
        {
            get { return (this._gettotalmark); }
            set { this._gettotalmark = value.ToUpper(); }
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
        return ($"Ttile: {_title}\tDescreption: {_decreption}\tSub date: {_subdatetime.ToString("dd/MM/yyyy")}\tOral mark: {_getoralmark} \tTotal mark: {_gettotalmark}");
    }
}
}
