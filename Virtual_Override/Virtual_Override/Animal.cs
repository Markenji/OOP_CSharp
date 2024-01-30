using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Hewan Berbunyi......");
        }
    }

    class Cat:Animal
    {
        public override void MakeSound() 
        {
            Console.WriteLine("MEOW MEOW MEWO");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("WUK WUK WUK");
        }
    }

}
