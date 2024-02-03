using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Kelas smartphone yang mengimplementasikan kedua interface
    public class Smartphone : IConnectable, IMediaPlayer
    {
        public void Connect()
        {
            Console.WriteLine("Smartphone connected to the internet.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Smartphone disconnected from the internet.");
        }

        public void Play()
        {
            Console.WriteLine("Playing media on the smartphone.");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing media on the smartphone.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping media on the smartphone.");
        }
    }

}
