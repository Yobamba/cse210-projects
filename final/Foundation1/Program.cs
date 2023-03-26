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
            Console.WriteLine($"Create video {i + 1}");
            Console.WriteLine();
            List<string> videoInputs = new List<string>();
            videoInputs = vid.AssistVideoCreation();

            Comment userComment = comentObj.CreateComment(videoInputs[3], videoInputs[4]);
            Video videoItem = vid.CreateVideo(videoInputs[0], videoInputs[1], float.Parse(videoInputs[2]), userComment);
            videoStorage.Add(videoItem);

        }

        for (int i = 0; i < videoStorage.Count; i++) 
        {
            videoStorage[i].ShowVideoDetails();
            
        }
    }
}