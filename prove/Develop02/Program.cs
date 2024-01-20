using System;
// For exceeding requirements I added another fix prompt to appear each time. 
// It asks what blessings Have I seen this day. This way I am able to remember in a positive
// light the events of the day. This can motivate me to write the Journal more often
// This is extra information that will be saved in the Journal

class Program
{
    static void Main(string[] args)
    {
        int option;
        Console.WriteLine("Welcome to the Journal Program!");
        Journal jour = new Journal();

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string textvalue = Console.ReadLine();
            option = int.Parse(textvalue);
            Console.WriteLine("");

            // option write
            if (option == 1)
            {
                //this will have the date saved as a string in dateText
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //Pulls a new prompt from the generator
                PromptGenerator gen = new PromptGenerator();
                string prompt = gen.GetRandomPrompt();
                Console.Write(prompt);
                string textEntry = Console.ReadLine();

                Console.Write("What blessings did you see in this day?");
                string textEntry2 = Console.ReadLine();

                // Creates a new object (Entry)
                Entry ent = new Entry();
                ent._promptText = prompt;
                ent._entryText = textEntry;
                ent._blessings = textEntry2;
                ent._date = dateText;

                // once it is established the new entry, it is saved in a list                
                jour.AddEntry(ent);
            }
            //Option for display
            else if(option == 2)
            {
                jour.DisplayAll();
            }
            // Option for Load
            else if(option == 3)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                jour.LoadFromFile(fileName);

            }
            // Option for Save
            else if(option == 4)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                jour.SaveToFile(fileName);
            }

        }while(option != 5);
        

    }
}