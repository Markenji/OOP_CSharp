using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Interface untuk perangkat yang dapat memutar media
    public interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
    }
}
