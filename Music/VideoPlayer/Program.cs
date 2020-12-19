using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidoPalyer
{
    class Program
    {
        static void Main(string[] args)
        {
            autoplay me = new autoplay();

            me.playvideo("my First Video", "MP3");
            me.playvideo("my Second Video", "MP4");
            me.playvideo("my Third Video", "VLC");
            me.playvideo("my Third Video", "WAV");

            Console.ReadKey(); 
        }
    }
}
