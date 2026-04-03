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
       
        Video v3 = new Video("Workout Tips", "FitnessPro", 500);
        v3.AddComment(new Comment("Jake", "Nice tips!"));
        v3.AddComment(new Comment("Lily", "Very useful"));
        v3.AddComment(new Comment("Sam", "Thanks!"));

        Video v4 = new Video("Travel Vlog: Japan Trip", "WanderWithMe", 720);
        v4.AddComment(new Comment("Mia", "This makes me want to travel!"));
        v4.AddComment(new Comment("Noah", "The scenery is amazing"));
        v4.AddComment(new Comment("Ethan", "Great editing and music"));
        v4.AddComment(new Comment("Sophia", "Very relaxing video"));



        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplay());
        }
    }
}