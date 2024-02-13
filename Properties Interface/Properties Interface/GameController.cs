using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Interface
{
    public class GameController : IGameController
    {
        public int MyProp { get; private set; }

        public void X()
        {
            Console.WriteLine("HAI");
        }
    }
}
