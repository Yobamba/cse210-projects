public class Video 
{
    private string _title;
    private string _author;
    private float _videoLength;

    private string _commentAuthor;
    private string _commentText;
    private List<Comment> _commentList = new List<Comment>();
    private Comment _commentPlaceHolder = new Comment();

    public Video() 
    {
        
    }
    public Video(string title, string author, float videoLength, List<Comment> commentItems) 
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        
        _commentList = commentItems;

    }

    public Video CreateVideo(string title, string author, float videoLength, List<Comment> commentItems) 
    {
        Video newVid = new Video(title, author, videoLength, commentItems);
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

        

        
        
        
       

        return assistingList;
    }

    public void ShowVideoDetails() 
    {
        Console.WriteLine("Title: " + this._title);
        Console.WriteLine("Author: " + this._author);
        Console.WriteLine("Video length: " + this._videoLength + " s");
        for (int i = 0; i < _commentList.Count; i++) 
        {
            _commentPlaceHolder.ShowComment(this._commentList[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Total comments: " + _commentList.Count);
        Console.WriteLine();
    }
}

