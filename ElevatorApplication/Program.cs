using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();

            int luku = 0;
            do
            {

                Console.WriteLine("Anna kerros johon haluat siirtyä, paina painiketta 0 poistuaksesi");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                elevator.Kerros = luku;
                {
                    Console.WriteLine("Olet kerroksessa " + elevator.Kerros);
                }
            }

          
            while (luku  != 0);
            Console.WriteLine("Astu ulos, kiitos");







        }
    }
}
