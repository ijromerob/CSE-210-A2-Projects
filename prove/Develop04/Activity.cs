public class Activity
{
    //Attributes -------------------------------------
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructors-----------------------------------
    public Activity()
    {
        _name = "Activity";
        _description = "description";
    }
    //Methods ---------------------------------------
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds, would you like for your session? ");
        string textValue = Console.ReadLine();
        _duration = int.Parse(textValue);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(6);
        Console.WriteLine();
        Thread.Sleep(500);
        Console.WriteLine($"You have compleated {_duration} seconds of the {_name} activity");
        ShowSpinner(6);

    }
    public void ShowSpinner(int seconds)
    {
        int totalSeconds = 0;

        while (totalSeconds < seconds)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            totalSeconds += 1;
        } 
    }
    public void ShowCountDown(int seconds)
    {
        while (seconds>0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            int secondsLenght = seconds.ToString().Length;
            seconds -= 1;
            for (int i = 0; i < secondsLenght; i++)
            {
                Console.Write("\b \b");
            }
        }
        Console.Write(seconds);

    }
}