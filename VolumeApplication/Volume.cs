using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeApplication
{
    class Volume
    {
        private readonly int MaxVolume = 100;
        private readonly int MinVolume = 0;

        private int volume;

        public int Voluumi
        {
            get
            {
                return volume;
            }
            set
            {
                if             
                {
                    volume = MinVolume;
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum :" + Voluumi);
                   

                }
                if else
                {
                    volume = MaxVolume;
                    Console.WriteLine("Too much volume - Amplifier volume is set to minimum :" + Voluumi);
                }
               
                
            }
        }
    }
}
