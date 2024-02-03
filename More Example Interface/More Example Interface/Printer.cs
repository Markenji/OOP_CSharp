using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scan_1;
using Fax_1;
using Print_1;


namespace More_Example_Interface
{
    public class Printer : IScan, IFax, IPrint
    {
        public void Fax()
        {
            Console.WriteLine("Fax aja");
        }

        public void Print()
        {
            Console.WriteLine("Print aja");
        }

        public void Scan()
        {
            Console.WriteLine("Scan aja");
        }
    }
}
