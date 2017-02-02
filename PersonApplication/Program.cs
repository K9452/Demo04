using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();

            //create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "010-123456789";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "Mallikas", "H9090");
            student.Address = "Kirkkokatu 10";
            student.Age = 20;
            student.PhoneNumber = "040-032198765";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
