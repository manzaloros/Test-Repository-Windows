using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEightAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiate Course
            Course programmingWithCSharp = new Course { Title = "Programming With C#" };

            //Create 3 student objects
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.FirstName = "John";
            student1.LastName = "Maxwell";

            student2.FirstName = "Gary";
            student2.LastName = "Simpleton";

            student3.FirstName = "Beth";
            student3.LastName = "Annery";

            //Add Grades
            student1.Grades.Add(95);
            student1.Grades.Add(76);
            student1.Grades.Add(85);
            student1.Grades.Add(94);
            student1.Grades.Add(87);

            student2.Grades.Add(90);
            student2.Grades.Add(98);
            student2.Grades.Add(90);
            student2.Grades.Add(89);
            student2.Grades.Add(92);

            student3.Grades.Add(100);
            student3.Grades.Add(85);
            student3.Grades.Add(83);
            student3.Grades.Add(99);
            student3.Grades.Add(96);

            Console.WriteLine(student3.Grades[4]);
            student3.Grades.Remove(96);
            student3.Grades.Insert(4, 95);
            Console.WriteLine(student3.Grades[4]);

            //Populate Course with students
            programmingWithCSharp.Students.Add(student1);
            programmingWithCSharp.Students.Add(student2);
            programmingWithCSharp.Students.Add(student3);

            
            //Write to Console
            programmingWithCSharp.ListStudents();
        }
    }
}
