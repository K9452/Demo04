using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeApplication
{
    public class Vehicle
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Vari { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string nimi, string malli, int vuosimalli, string vari)

        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Vari = vari;
        }
        public override string ToString()
        {
            return "- Name: " + Nimi + " Model: " + Malli + " ModelYear: " + Vuosimalli + "Color: " + Vari;
        }
    }
}
