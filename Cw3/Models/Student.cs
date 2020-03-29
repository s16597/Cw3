using System;
using System.Linq;
using Cw3.DAL;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Models
{
    public class Student
    {

        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string IndexNumber { get; set; }

        public override string ToString()
        {
            return IdStudent + ", " + FirstName + ", " + Lastname + ", " + IndexNumber;
        }
    }
}
