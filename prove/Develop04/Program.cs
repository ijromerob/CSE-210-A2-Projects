using System;
//FOR EXCEEDING REQUIREMENTS:
//I included some code in the Listing activity that saves the code into a text file
//the name of the file is included the date so that the user can check the entries later
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start Listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choiceText = Console.ReadLine();
        int choice = int.Parse(choiceText);

        while(choice != 4)
        {
            if (choice == 1)
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity d = new ReflectingActivity();
                d.Run();
            }
            else if (choice == 3)
            {
                ListingActivity c = new ListingActivity();
                c.Run();
            }
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choiceText = Console.ReadLine();
            choice = int.Parse(choiceText);
        }

    }
}