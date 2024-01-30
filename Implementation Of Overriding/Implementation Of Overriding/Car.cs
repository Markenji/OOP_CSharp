using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARCAR
{
    class Car
    {
        public Engine engine;
        public Car(Engine engine)
        {
            this.engine = engine;
        }
        public void EngineRun()
        {
            engine.Start();
        }

        
    }
    class Engine
    {
        public virtual void Start()
        {
            Console.WriteLine("Engine Starting");
        }
    }

    class ElectricEngine : Engine
    {
        public new void Start()
        {
            Console.WriteLine("ElectricEngine Starting");
        }
    }

    class HydroEngine : Engine
    {
        public void Start()
        {
            Console.WriteLine("HydroEngine Starting");
        }
    }
}
