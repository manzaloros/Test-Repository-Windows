using System;
using System.Collections;
using System.Collections.Generic;

namespace ModuleEightAssignment
{
    internal class Student
    {
        //properties
        public static int EnrollCount;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Grades { get; set; }

        
        //constructor
        public Student()
        {
            this.Grades = new List<int>();
        }

    }
}