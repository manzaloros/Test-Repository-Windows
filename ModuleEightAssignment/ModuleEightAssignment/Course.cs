using System;
using System.Collections;
using System.Collections.Generic;

namespace ModuleEightAssignment
{
    class Course
    {

        //properties
        public string Title { get; set; }
        public string Summary { get; set; }
        public List<Student> Students { get; set; }
        
        //constructor
        public Course()
        {
            this.Students = new List<Student>();
        }

        //methods
        public void ListStudents()
        {
            foreach (Student student in Students)
            {
                var gTS = string.Join(",", student.Grades.ToArray());
                Console.WriteLine("First name: {0}, Last Name: {1}, Test Scores: {2} ", student.FirstName, student.LastName, gTS);
            }
            Console.ReadLine();
        }
    }
}
