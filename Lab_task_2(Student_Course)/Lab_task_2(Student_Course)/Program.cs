using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2_Student_Course_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student 
            var s1 = new Student("Sreejan", "19-39737-1", 3.5F);
            var s2 = new Student("Roy", "19-39737-2", 3.7F);
            var s3 = new Student("Sreejan Roy", "19-39737-3", 3.8F);

            //Course 
            var c1 = new Course("OOP1", "CS01");
            var c2 = new Course("OOP2", "CS02");
            var c3 = new Course("C++", "CS03");

            //add and remove 
            c1.AddStudent(s1, s2, s3);
            c1.PrintStudent();

            c1.RemoveStudent(s3);

            Console.WriteLine("\nAfter Removing Student\n");

            s1.PrintCourse();
            c1.PrintStudent();

            Console.WriteLine("\n**************\n");

            s2.AddCourse(c1, c2, c3);
            s2.PrintCourse();

            s2.RemoveCourse(c2);
            Console.WriteLine("\nAfter Dropping Course\n");
            s2.PrintCourse();
            c2.PrintStudent();
        }
    }
}
