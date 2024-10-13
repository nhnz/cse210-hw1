
//A Video class exists to track the title, author, and length.
using System.Transactions;

class Video
 {
    public string _title;
    public string _author;
    public int _lenght;  //Should give lenght in seconds
    public List<Comment> _comments;

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
        _comments = new List<Comment>();
    }

    //returns the number of comments directly from the way comments are stored (for example returns the length of the list).
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentLenght()
    {
        return _comments.Count;
    }

 }
