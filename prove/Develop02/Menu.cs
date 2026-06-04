public class Menu
{
private List<string> _options;

public Menu()
    {
        _options = new List<string>
        {
            "Write a new entry",
            "Display the Journal", 
            "Save the journal to a file",
            "Load the journal from a file",
            "Quit"
        };
    }

public void Display()
    {
        Console.WriteLine("Please select one of the following options:");

        for(int i=0; i < _options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }
    }

    public int GetChoice()
    {
        Console.Write("What would you like to do? ");
        string userInput = Console.ReadLine();

        int choice = int.Parse(userInput);
        return choice;
        
    }
}