﻿using System;
using System.Collections.Generic;
using System.Collections;
using Cw3.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.DAL
{
    public class MockDbService : IDbService
    {

        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student {IdStudent = 1, FirstName = "Jan", Lastname = "Kowalski"},
                new Student {IdStudent = 2, FirstName = "Anna", Lastname = "Malewski"},
                new Student {IdStudent = 3, FirstName = "Andrzej", Lastname = "Andrzejewicz"},
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
