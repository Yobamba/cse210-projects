using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid = new Video();
        Comment comentObj = new Comment();
        // Let the user create 3 videos
        Console.WriteLine("Let's create a few videos! ");
        Console.WriteLine();

        for (int i = 0; i < 2; i++) 
        {
            Console.WriteLine($"Create video {i + 1}");
            Console.WriteLine();
            List<string> videoInputs = new List<string>();
            videoInputs = vid.AssistVideoCreation();

            Comment userComment = comentObj.CreateComment(videoInputs[3], videoInputs[4]);
            vid.CreateVideo(videoInputs[0], videoInputs[1], float.Parse(videoInputs[2]), userComment);


        }
    }
}