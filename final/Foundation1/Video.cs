using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private float _lengthOfVideo;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, float lengthOfVideo ){
        _title = title;
        _author = author;
        _lengthOfVideo = lengthOfVideo;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }


    public void DisplayVideo(){
        Console.WriteLine($"{_title}, {_author}, {_lengthOfVideo}");
        Console.WriteLine($"Number of comments: {_comments.Count}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
    }
  
}