using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        //constructor
        public Teacher()
        {

        }

        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to teacher");
        }
        
        public override string ToString()
        {
            //base on tässä tapauksessa person luokka
            //"eli" kutsutaan Person luokan ToString()- metodia
            //return FirstName + " " + .... + room;
            return base.ToString() + " " + Room;
        }
        


    }
}
