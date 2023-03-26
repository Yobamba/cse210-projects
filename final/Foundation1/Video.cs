public class Video 
{
    private string _title;
    private string _author;
    private float _videoLength;
    private List<Comment> _commentList = new List<Comment>();

    public Video() 
    {

    }
    public Video(string title, string author, float videoLength, Comment commentItem) 
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _commentList.Add(commentItem);

    }

    public Video CreateVideo(string title, string author, float videoLength, Comment commentItem) 
    {
        Video newVid = new Video(title, author, videoLength, commentItem);
        return newVid; 
    }

    public List<string> AssistVideoCreation() 
    {
        List<string> assistingList = new List<string>();
        Console.WriteLine("What's the title? ");
        string userTitle = Console.ReadLine();
        assistingList.Add(userTitle);

        Console.WriteLine("Who's the author? ");
        string userAuthor = Console.ReadLine();
        assistingList.Add(userAuthor);

        Console.WriteLine("How long is the video (in seconds)? ");
        string vidLength = Console.ReadLine();
        assistingList.Add(vidLength);

        Console.WriteLine("Who's your name ? ");
        string comenterName = Console.ReadLine();
        assistingList.Add(comenterName);

        Console.WriteLine("Comment on the video. ");
        string comment = Console.ReadLine();
        assistingList.Add(comment);

        return assistingList;
    }
}

