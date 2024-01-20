public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Methods --------------------

    //The purpose of this method is to add any new entry to the list of entries
    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
    }
    
    // For display all it will go to the list of entries "._entries" and then in each
    // Entry will look for displaying
    public void DisplayAll()
    {
        foreach (Entry ent in _entries)
        {
            ent.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine($"{ent._date}~~{ent._promptText}~~{ent._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from file...");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            AddEntry(newEntry);
        }
    }
}