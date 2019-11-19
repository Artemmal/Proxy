using System;

namespace HW23._5
{
    abstract class Youtube
    {
        public abstract void VideoCast();
    }
    class Video : Youtube
    {
        string name = "Movie";
        int duration = 56;
        public override void VideoCast()
        {
            Console.WriteLine($"Casting video {name} during {duration} minutes");
        }
    }
    class OfflineStorage : Youtube
    {
        Video video;
        public override void VideoCast()
        {
            if(video == null)
            {
                Console.WriteLine("Adding video to the offline storage");
                video = new Video();
            }
            video.VideoCast();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Youtube youtubeVideo = new OfflineStorage();
            youtubeVideo.VideoCast();
            youtubeVideo = new Video();
            youtubeVideo.VideoCast();
        }
    }
}
