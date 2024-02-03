public class ListingActivity:Activity
{
    //Attributes ---------------------------
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    //Constructor --------------------------
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        ShowSpinner(6);
        Console.WriteLine("");
        Console.WriteLine(GetRandomPrompt());
        
        List<string> responses = GetListFromUser();

        // creates a file to safe the responses of the Listing activity
        DateTime date = DateTime.Now;
        string listDate = $"Listing-Activity-{date.ToString("yyyy-MM-dd")}.txt";
        using (StreamWriter outputFile = new StreamWriter(listDate))
        {
            foreach (string response in responses)
            {
                outputFile.WriteLine(response);
            }
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
    public List<string> GetListFromUser()
    {
        // This creates a new list that will be used later
        List<string> responsesFromUser = new List<string>();
        
        Console.WriteLine("You may begin");
        
        //To work with time I will add the current time with the duration
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        // A while to work while the duration is still on
        while (currentTime < futureTime)
        {
            string response = Console.ReadLine();
            currentTime = DateTime.Now;
            responsesFromUser.Add(response);
            Console.WriteLine("");
        }
        _count = responsesFromUser.Count;
        Console.WriteLine($"Congratulations you listed {_count} items");
        return responsesFromUser;

    }
}