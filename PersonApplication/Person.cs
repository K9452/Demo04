using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        
        //constructor
        public Person()
        {

        }

        //tehdään henkilön etunimestä ja sukunimestä parametrit
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        //toiminto/method
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        //putkittaa tulostuksen
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;
        }
    }
}
