public class Comment
{
    private string _name;
    private string _text;
    
    List<Video> _comments = new List<Video>();
    public Comment(string name, string text){
        _name = name;
        _text = text;
    }



    public void DisplayComment(){
        Console.WriteLine($"{_name}: {_text}");
    }
}