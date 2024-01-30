using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{

    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal Bunyi....");
        }
    }


    class Cat : Animal
    {
        public new void MakeSound()
        {
            Console.WriteLine("MOEW MOEW MOEW");
        }
    }

    class Dog : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("WUK WUK WUK");
        }
    }
}