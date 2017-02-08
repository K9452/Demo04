using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //tehdään olio
            Boss boss1 = new Boss();
            //annetaan pomon tiedot
            boss1.Name = "Jussi Jurkka";
            boss1.Profession = "head of institute";
            boss1.Salary = 9000;
            boss1.Car = "Audi";
            boss1.Bonus = 5000;
            //annetaan työntekijän tiedot(tehdään toinen olio)
            Employee employee1 = new Employee();
            employee1.Name = "Kirsi kernel";
            employee1.Profession = "Teacher";
            employee1.Salary = 1200;
            //Tulostetaan
            Console.WriteLine("Employee:");
            Console.WriteLine("- Name: {0} Profession: {1} Salary: {2}", employee1.Name, employee1.Profession, employee1.Salary);
            
            Console.WriteLine("Boss:");
            Console.WriteLine("- Name: {0} Profession: {1} Salary: {2} Car: {3} Bonus: {4}", boss1.Name, boss1.Profession, boss1.Salary, boss1.Car, boss1.Bonus);
            
            employee1.Profession = "Principal Teacher";
            employee1.Salary = 2200;
            Console.WriteLine("Employee:");
            Console.WriteLine("- Name: {0} Profession: {1} Salary: {2}", employee1.Name, employee1.Profession, employee1.Salary);
        }
    }
}
