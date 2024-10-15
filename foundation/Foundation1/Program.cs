using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation #1: Abstraction with YouTube Videos");
        
        List<Video> videos= new List<Video>();

        Video video1 = new Video("Video #1", "Author #1", 60);
        video1.AddComment(new Comment("User1", "Comment1"));
        video1.AddComment(new Comment("User2", "Comment2"));
        video1.AddComment(new Comment("User3", "Comment3"));

        Video video2 = new Video("Video #2", "Author #2", 120);
        video2.AddComment(new Comment("User4", "Comment1"));
        video2.AddComment(new Comment("User5", "Comment2"));
        video2.AddComment(new Comment("User6", "Comment3"));

        Video video3 = new Video("Video #3", "Author #3", 180);
        video3.AddComment(new Comment("User7", "Comment1"));
        video3.AddComment(new Comment("User8", "Comment2"));
        video3.AddComment(new Comment("User9", "Comment3"));
        video3.AddComment(new Comment("User10", "Comment4"));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine(video.DisplayVideo());
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayComment());
            }
            Console.WriteLine();
        }

    }
}