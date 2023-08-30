using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("박나경", 4.5));
            students.Add(new Student("떡볶이", 1.2));
            students.Add(new Student("마라탕", 2.5));
            students.Add(new Student("햄버거", 3.4));

            students.Print();
            students.Print((student) =>
            {
                Console.WriteLine("***************");
                Console.WriteLine("이름: " + student.Name);
                Console.WriteLine("학점: " + student.Score);
            });
            Console.WriteLine("<students>");
            students.Print((s) =>
            {
                Console.WriteLine(" <student>");
                Console.WriteLine("     <name>" + s.Name + "</name>");
                Console.WriteLine("     <score>" + s.Score + "</score>");
                Console.WriteLine(" </student>");
            });
            Console.WriteLine("</students>");
        }
    }
}
