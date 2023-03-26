using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid = new Video();
        Comment comentObj = new Comment();
        List<Video> videoStorage = new List<Video>();
        // Let the user create 3 videos
        Console.WriteLine("Let's create a few videos! ");
        Console.WriteLine();

        for (int i = 0; i < 2; i++) 
        {
            List<Comment> commentList = new List<Comment>();
            Console.WriteLine();
            Console.WriteLine($"Create video {i + 1}");
            Console.WriteLine();
            List<string> videoInputs = new List<string>();
            videoInputs = vid.AssistVideoCreation();

            Console.Write("What's your name? ");
            string commenter = Console.ReadLine();

            Console.Write("Add a comment: ");
            string comment1 = Console.ReadLine();
            Console.WriteLine();
            
            Comment userComment1 = comentObj.CreateComment(commenter, comment1);
            commentList.Add(userComment1);

            Console.Write("Add a comment: ");
            string comment2 = Console.ReadLine();
            Console.WriteLine();
            
            Comment userComment2 = comentObj.CreateComment(commenter, comment2);
            commentList.Add(userComment2);

            Console.Write("Add a comment: ");
            string comment3 = Console.ReadLine();
            Console.WriteLine();
            
            Comment userComment3 = comentObj.CreateComment(commenter, comment3);
            commentList.Add(userComment3);

            Video videoItem = vid.CreateVideo(videoInputs[0], videoInputs[1], float.Parse(videoInputs[2]), commentList);
            videoStorage.Add(videoItem);

        }

        for (int i = 0; i < videoStorage.Count; i++) 
        {
            videoStorage[i].ShowVideoDetails();
            
            
        }
    }
}