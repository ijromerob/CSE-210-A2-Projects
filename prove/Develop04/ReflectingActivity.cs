public class ReflectingActivity:Activity
{
    //Attributes ---------------------------------
    private List<string> _prompts =  new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //Constructor --------------------------------
    public ReflectingActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    // Methods -----------------------------------
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        ShowSpinner(6);
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        string response = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may start in: ");
        ShowCountDown(10);
        Console.WriteLine("");
        Console.Clear();
        DisplayQuestion();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
    public string GetRamdomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        // I will determine 15 seconds of reflection per question
        int questionTime = 15;
        int totalTime = 0;
        while (totalTime <_duration)
        {
            Console.Write(GetRamdomQuestion());
            ShowSpinner(questionTime);
            totalTime += questionTime;
            Console.WriteLine("");
        }
    }
}