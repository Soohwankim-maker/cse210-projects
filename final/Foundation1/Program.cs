using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to Cook Pasta", "Chef John", 600);
        v1.AddComment(new Comment("Alice", "Great video!"));
        v1.AddComment(new Comment("Bob", "Helpful!"));

        Video v2 = new Video("Gaming Highlights", "ProGamer", 900);
        v2.AddComment(new Comment("Dave", "Awesome!"));

        videos.Add(v1);
        videos.Add(v2);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplay());
        }
    }
}