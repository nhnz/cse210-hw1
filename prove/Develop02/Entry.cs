
public class Entry
{
    //storation of date of journal Entry, prompt Question, and storation of user response to prompt
    public string _date;
    public string _promptText;
    public string _entryText;


//constructor to initialize an entry with prompt and user's response.
    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }


//Display the journal entry details to the console
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(new string('-',40));
    
    }
    
}

