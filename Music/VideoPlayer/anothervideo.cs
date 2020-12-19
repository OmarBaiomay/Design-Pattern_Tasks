 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidoPalyer
{ 
    interface Anothervideo
    {
        void Play(string Name);
    }
    class MP4 : Anothervideo
    { 
        public void Play(string Name)
        {
            Console.WriteLine("You Played \"{0}\" , and it's Type is MP4", Name);
        }

    }

    class VLC : Anothervideo
    {
        public void Play(string Name)
        {
            Console.WriteLine("You Played \"{0}\" , and it's Type is VLC", Name);
        }

    }
}
