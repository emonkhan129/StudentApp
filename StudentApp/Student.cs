using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp
{
    public class Student
    {
        public int RegNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public String GetFullName(string firstName, string lastName)
        {
            return FirstName + " " + LastName;
        }
    }
}