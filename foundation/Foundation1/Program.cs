using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //The program will track YouTube videos, including their titles, authors, lengths, and comments
        //The program will have two classes namely Video and Comment
        //Class Diagram

    //      +----------------------------+
    //      |          Video             | class to Store and manage video attributes, handle comments, and provide the count of comments.
    //      +----------------------------+
    //      | -Tile : string             |
    //      | -Author: string            |
    //      | -Lenght: int               | 
    //      | -List<Comment> comments    |
    //      |                            |
    //      +----------------------------+  
    //      | -AddComment(Comments)      | Handle comments
    //      +----------------------------+
    //      | -GetCommentlenght(): int   | Provide the count of comments
    //      +----------------------------+
    //                   |
    //                   |
    //      +----------------------------+
    //      |          Comment           | Store details about the commenter and their comment.
    //      +----------------------------+
    //      | -CommentorName             | Store the name of commentor 
    //      +----------------------------+
    //      | -CommentorInput            | Commentor input text
    //      +----------------------------+

        // Create a list to store video objects
        List<Video> videos = new List<Video>();

        //video instances
        Video video1 = new Video("Understanding Abstraction", "Alice", 300);
        Video video2 = new Video("Class in C#", "Bob", 240);
        Video video3 = new Video("Data Structures", "Charlie", 180);

        //Users video one comments
        video1.AddComment(new Comment("User 1","Very Informative"));
        video1.AddComment(new Comment("User 2","Useful information for a beginner"));
        video1.AddComment(new Comment("User 3","Well Done!"));

        //Users video two comments
        video2.AddComment(new Comment("User 4","Great explanation!"));
        video2.AddComment(new Comment("User 5","Cleared my confusion!"));

        //Usere video three comments
        video3.AddComment(new Comment("User 6","Useful content!"));
        video3.AddComment(new Comment("User 7","Need more clarity on some parts of the video"));
        video3.AddComment(new Comment("User 8","Great explanation!"));

        //video list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //display each video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Lenght: {video._lenght} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentLenght()}");
            foreach(Comment comment in video._comments)
            {
                Console.WriteLine(" "+ comment._commentorName+":"+comment._commentorInput);
            }
            Console.WriteLine();
        }
    }
}