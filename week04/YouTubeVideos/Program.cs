using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video1 = new Video("Introduction to OOP", "Mtende Mwanza", 1200);
        video1.AddComment(new Comment("Emily", "This makes sense, thank for the clarification."));
        video1.AddComment(new Comment("Lonjezo", "What a great video, keep up."));
        video1.AddComment(new Comment("Emma", "Can you share a link to the code repo?"));

        Video video2 = new Video("How to efficiently utilize AI", "Chancy", 7000);
        video2.AddComment(new Comment("Smith", "AI is helpful when used properly."));
        video2.AddComment(new Comment("Yassin", "How can develop and app using AI."));
        video2.AddComment(new Comment("Gau", "Very this is about AI nowadays"));

        Video video3 = new Video("Software Testing 101", "Smith", 3200);
        video3.AddComment(new Comment("Rodwell", "This video has convinced me to start testing my code."));
        video3.AddComment(new Comment("Yassin", "We need a separate video on End-to-End Testing."));
        video3.AddComment(new Comment("Bertha", "Testing saved me from pushing bug to production server"));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"\n{video.GetTitle()} - {video.GetAuthor()} ({video.GetLength()} seconds)");

            Console.WriteLine($"Comments ({video.GetCommentsCount()})");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommentText()} - {comment.GetPersonName()}");
            }
        }



    }
}