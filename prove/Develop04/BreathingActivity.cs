public class BreathingActivity: Activity
{
    // No attributes

    //Constructor------------------------------
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    //Methods-----------------------------------
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        ShowSpinner(6);
        Console.WriteLine("");
        int breathInTotalTime = _duration/2 - 1 ;
        int breathOutTotalTime = _duration - breathInTotalTime;
        int totalTime = 0;

        // These will be the amounts of time for each time there will be an inhalation and exhalation
        int breathInTime = breathInTotalTime / 4;
        int breathOutTime = breathOutTotalTime / 6;

        while (totalTime < _duration)
        {
            Console.Write($"Breathe in...");
            ShowCountDown(breathInTime);
            Console.WriteLine("");
            Console.Write($"Breathe out...");
            ShowCountDown(breathOutTime);
            Console.WriteLine("");
            Console.WriteLine("");
            totalTime += breathInTime + breathOutTime;

        }
        DisplayEndingMessage();

        

    }
}