public class Comment 
{
    private string _nameOfCommenter;
    private string _commentTxt;

    public Comment() 
    {

    }

    public Comment(string nameOfCommenter) 
    {
        _nameOfCommenter = nameOfCommenter;
    }
    public Comment(string nameOfCommenter, string commentTxt) 
    {
        _nameOfCommenter = nameOfCommenter;
        _commentTxt = commentTxt;
    }

    

    public string GetCommentAuthor() 
    {
        string nameOfCommenter = _nameOfCommenter;
        return nameOfCommenter;
    }

    public Comment CreateComment(string nameOfCommenter, string commentTxt) 
    {
        Comment comentario = new Comment(nameOfCommenter, commentTxt);

        return comentario;

    }

    public void ShowComment(Comment insertComment) 
    {
        Console.WriteLine("Comment by: " + insertComment._nameOfCommenter);
        Console.WriteLine("> " + insertComment._commentTxt);
        Console.WriteLine();
        
    }

}

