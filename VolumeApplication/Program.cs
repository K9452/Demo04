using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           Volume volume = new Volume();

            int luku = 0;
            do
            {

                Console.WriteLine("Give a new volume value (1-100 ja 0 = off)" );
                string line = Console.ReadLine();
                luku = int.Parse(line);
                volume.Voluumi = luku;
                {
                    Console.WriteLine("Amplifier volume is set to :" + volume.Voluumi);
                }
            }


           while (luku != 0);
           Console.WriteLine("Käänsit volumen 0 asentoon, sammutetaan....");
        }
    }
}
