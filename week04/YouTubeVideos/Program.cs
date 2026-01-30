using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        // Create videos
        Video video1 = new Video("Introduction to Python", "John Doe", 120);
        Video video2 = new Video("Advanced C#", "Jane Smith", 180);
        Video video3 = new Video("Web Development Basics", "Alice Johnson", 90);

        // Add comments to videos
        video1.AddComment(new Comment("Bob", "Great video!"));
        video1.AddComment(new Comment("Carol", "Very helpful."));
        video1.AddComment(new Comment("David", "Thanks for the tutorial."));

        video2.AddComment(new Comment("Eve", "I learned a lot."));
        video2.AddComment(new Comment("Frank", "Clear explanations."));
        video2.AddComment(new Comment("Grace", "Highly recommended."));

        video3.AddComment(new Comment("Hank", "Very informative."));
        video3.AddComment(new Comment("Ivy", "Easy to follow."));
        video3.AddComment(new Comment("Jack", "Thanks for sharing."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display all videos
        Console.WriteLine("========== VIDEOS AND COMMENTS ==========\n");
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
