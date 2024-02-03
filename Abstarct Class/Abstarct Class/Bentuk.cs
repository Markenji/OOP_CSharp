using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    // Kelas abstract
    public abstract class Bentuk
    { 

        public abstract double HitungLuas();
        public void Tampilkan()
        {
            Console.WriteLine("Ini adalah suatu bentuk ");
        }
    }

}
