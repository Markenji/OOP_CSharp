using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Interface untuk sebuah perangkat yang dapat terhubung ke internet
    public interface IConnectable
    {
        void Connect();
        void Disconnect();
    }
}
