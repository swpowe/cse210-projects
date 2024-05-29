// A comment should be defined by the Comment class which has the responsibility for 
// tracking both the name of the person who made the comment and the text of the comment.

public class Comment
{
    private string _username;
    private string _comment;
    public Comment(string username, string comment)
    {   
        _username = username;
        _comment = comment;
    }

    public string DisplayCommentDetails(){
        return $"{_comment} ({_username})";
    }
}