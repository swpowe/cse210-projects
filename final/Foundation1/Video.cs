// track the title, author, and length (in seconds) 
// Each video also has responsibility to store a list of comments
// have a method to return the number of comments. 

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(string username, string comment)
    {
        Comment c = new(username, comment);
        _comments.Add(c);
    }

    public void DisplayVideoDetails()
    {
        // display the title, author, length, number of comments (from the method) 
        // and then list out all of the comments for that video.
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        // for each comment in 
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment.DisplayCommentDetails());
        }
        Console.WriteLine("------------------------------");
    }
}
