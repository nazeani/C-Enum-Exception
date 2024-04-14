using Core.Models;
using Core;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student();
            student1.Name = "Naz";
            student1.Surname = "Mustafayeva";
           Student student2 = new Student();
            student2.Name = "Narmin";
            student2.Surname = "Aliyeva";
           Student student3 = new Student();
            student3.Name = "Leyla";
            student3.Surname = "Nabiyeva";
            Classroom classroom1 = new Classroom();
            classroom1.Type = Core.Type.Student;
            classroom1.StudentAdd(student1);
            classroom1.StudentAdd(student3);
           Classroom classroom2 = new Classroom();
            classroom2.Type = Core.Type.Backend;
            classroom2.StudentAdd(student2);

            foreach (Student student in classroom1.GetStudents())
            {
                Console.WriteLine(student);

            }

            Console.WriteLine("---------------------------");
            foreach (Student student in classroom2.GetStudents())
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------------");
                classroom1.Delete(1);
          
            foreach (Student student in classroom1.GetStudents())
            {
                Console.WriteLine(student);

            }
        }
    }
}
