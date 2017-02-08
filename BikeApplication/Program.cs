using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan olito ja annetaan tiedot
            Bike bike1 = new Bike(" Jopo ", " Street ", 2016 , " Pink ", false, null);
            Bike bike2 = new Bike(" Tunturi ", " StreetPower ", 2010 , " Black ", true, " Shimano ");
            Boat boat1 = new Boat(" Yamaha ",  "S900 ", 1990 , " Matte BLack ", 3, " Militaryboat ");
            Boat boat2 = new Boat(" Yamaha ", " 1000 ", 2010 , " Yellow ", 3, " Motorboat ");

            //Tulostetaan tiedot kaikistaa
            Console.WriteLine("Bike info \n" + bike1);
            Console.WriteLine("Bike2 info \n" + bike2);
            Console.WriteLine("Boat info \n" + boat1);
            Console.WriteLine("Boat2 info \n" + boat2);
        }
    }
}
