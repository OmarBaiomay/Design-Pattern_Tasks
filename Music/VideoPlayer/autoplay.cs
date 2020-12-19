using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidoPalyer
{
    public interface video{
         void playvideo(string Name, string Type); 
    } 
    class autoplay : video
    {
        public void playvideo(string Name, string Type)
        {
            if (Type == "MP3")
            {
                Console.WriteLine("You Played \"{0}\" , and it's Type is {1}", Name, Type);

            } 
            else if (Type == "MP4" || Type == "VLC")
            {
                AnotherVideo video = new AnotherVideo();

                video.play(Type, Name);

            } 
            else
            {
                Console.WriteLine("You Should Enter A Valid Value Type " );
            }

        }
    } 

    class AnotherVideo
    {
        Anothervideo mp4 = new MP4(); 
        Anothervideo vlc = new VLC(); 
        
        public void play(string type, string name)
        {
            if(type == "MP4")
            {
                mp4.Play(name);
            } else if (type == "VLC")
            {
                vlc.Play(name);
            } else
            {
                Console.WriteLine("The Video Type is not Clear" );
            }
        }
    }
}
