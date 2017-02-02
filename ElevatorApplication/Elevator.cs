using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {
        private readonly int maxKerros = 5;
        private readonly int minKerros = 1;

        private int kerros;
        public int Kerros
        {
            //annetaan min arvot
            get
            {
                return kerros;
            }
            set
            {
                if (value <= maxKerros && value >= minKerros) kerros = value;
                else
                {
                    Console.WriteLine("Tässä rakennuksessa ei ole kyseistä kerrosta");
                    kerros = maxKerros;
               
                }
            }
        }
    }
}
