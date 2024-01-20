public class Entry
{

    public string _date;
    public string _promptText; 
    public string _entryText;

    public string _blessings;
    
    // Methods ---------------------------
    public void Display()
    {
        //Following the format provided this will be the display method for each entry
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Some blessings that you have seen today: {_blessings}");
    }
}