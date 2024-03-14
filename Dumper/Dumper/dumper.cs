using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumper
{
    public static class MyExtension
    {
        public static void Dump(this object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
