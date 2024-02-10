using System.ComponentModel;

public class GoalManager
{
    //Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int option = 0;
        
        while (option != 6)
        {
            // Create a goal
            if (option == 1)
            {
                CreateGoal();
            }
            // List Goals
            else if (option == 2)
            {
                ListGoalDetails();
            }
            // Save Goals
            else if (option == 3)
            {
                SaveGoals();
            }
            // Load Goals
            else if (option == 4)
            {
                LoadGoals();
            }
            // Record Event
            else if (option == 5)
            {
                RecordEvent();
            }

            DisplayPlayerInfo();

            //Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select the choice from the menu: ");
            string optionText = Console.ReadLine();
            option = int.Parse(optionText);

        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
        LevelDisplay(_score);
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetName()}");
            index ++;
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetDetailsString()}");
            index ++;
        }
    }
    public void CreateGoal()
    {
        //select what kind of goal do we want
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeText = Console.ReadLine();
        int goalType = int.Parse(goalTypeText);
        // More details of goals that are used accross every goal keeping the code short
        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsText = Console.ReadLine();
        int points = int.Parse(pointsText);
        
        // Simple Goal-----------
        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name,description,points));
        }
        //Eternal Goal ---------------
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name,description,points));
        }
        // Checklist Goals ------------------------
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal have to be accomplished for a bonus? ");
            string targetText = Console.ReadLine();
            int target = int.Parse(targetText);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusText = Console.ReadLine();
            int bonus = int.Parse(bonusText);
            _goals.Add(new ChecklistGoal(name,description,points,target,bonus));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal do you want to accomplish? ");
        string indexText = Console.ReadLine();
        int index = int.Parse(indexText) - 1;
        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You have now {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the name of the file you want to load? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        //defining indexes to make easier to see what I am calling later
        int classNameIndex = 0;
        int nameIndex = 1;
        int descriptionIndex = 2;
        int pointsIndex = 3;
        int boolIndex = 4;
        int bonusIndex = 4;
        int targetIndex = 5;
        int attemptsIndex = 6;

        int lenght = lines.Length;

        for (int i = 0; i< lenght; i++)
        {
            if (i == 0)
            {
                string scoreText = lines[i];
                _score = int.Parse(scoreText);
            }
            else
            {
                string[] parts = lines[i].Split("~");
                string className = parts[classNameIndex];
                string name = parts[nameIndex];
                string description = parts[descriptionIndex];
                string pointsText = parts[pointsIndex];
                int points = int.Parse(pointsText);

                if (className == "SimpleGoal")
                {
                    string boolText = parts[boolIndex];
                    bool boolValue = bool.Parse(boolText);
                    SimpleGoal s = new SimpleGoal(name,description,points);
                    s.SetCompletion(boolValue);
                    _goals.Add(s);
                }
                else if (className == "EternalGoal")
                {
                    EternalGoal e = new EternalGoal(name,description,points);
                    _goals.Add(e);
                }
                else if (className == "ChecklistGoal")
                {
                    string bonusText = parts[bonusIndex];
                    int bonus = int.Parse(bonusText);
                    string targetText = parts[targetIndex];
                    int target = int.Parse(targetText);
                    string attemptsText = parts[attemptsIndex];
                    int attempts = int.Parse(attemptsText);

                    ChecklistGoal c = new ChecklistGoal(name,description,points,target,bonus);
                    c.SetAttempts(attempts);
                    _goals.Add(c);
                }
            }
        }
    }
    public void LevelDisplay(int points)
    {
        if (points < 100)
        {
            Console.WriteLine("Level 1: Nephite kid");
        }
        else if (points < 200)
        {
            Console.WriteLine("Level 2: Nephite Farmer");
        }
        else if (points < 300)
        {
            Console.WriteLine("Level 3: Zarahemla Police Officer");
        }
        else if (points < 400)
        {
            Console.WriteLine("Level 4: Nephite Cadet");
        }
        else if (points < 500)
        {
            Console.WriteLine("Level 5: Nephite Captain");
        }
        else if (points < 600)
        {
            Console.WriteLine("Level 6: Nephite Major");
        }
        else if (points < 700)
        {
            Console.WriteLine("Level 7: Nephite Lieutenant-Colonel");
        }
        else if (points < 800)
        {
            Console.WriteLine("Level 8: Nephite Brigadier-General");
        }
        else if (points < 900)
        {
            Console.WriteLine("Level 9: Nephite Lieutenant-General");
        }
        else if (points >= 1000)
        {
            Console.WriteLine("Congratulations! you have reached the last level");
            Console.WriteLine("You are a Nephite General!");
        }
    }
}