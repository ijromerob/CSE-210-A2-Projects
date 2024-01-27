using System;
//LOOK AT THIS COMENT FOR SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS

// I added the class Scripture Generator that generate different scriptures to memorize
// this comes as a string and then it is splitted and then introduced into the other classes
class Program
{
    static void Main(string[] args)
    {
        
        ScriptureGenerator gen = new ScriptureGenerator();
        string script = gen.GetRandomScripture();
        string[] splittedstring = script.Split("--");
        string[] splittedstring2 = splittedstring[0].Split("~");
        int size = splittedstring2.Length;

        string book = splittedstring2[0];
        int chapter = int.Parse(splittedstring2[1]);
        int verse = int.Parse(splittedstring2[2]);
        
        Reference f;

        if (size > 3)
        {
            int end = int.Parse(splittedstring2[3]);
            f = new Reference(book,chapter,verse,end);
        }
        else
        {
            f = new Reference(book,chapter,verse);
        }
        
        Scripture Scrip1 = new Scripture(f,splittedstring[1]);

        //this will be the variables that will store the changing text and the response of the user
        string displayText;

        List<int> chosen = new List<int>();
        List<int> items = new List<int>();
        for (int i = 0; i < Scrip1.WordCount();i++)
        {
            items.Add(i);
        }

        displayText = Scrip1.GetDisplayText();
        Console.WriteLine(displayText);
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string response = Console.ReadLine();

        while (Scrip1.IsCompletelyHidden() ==false && response !="quit")
        {
            int remainder = items.Count;

            if (remainder >= 3)
            {
                Random randomNum1 = new Random();
                int index11 = randomNum1.Next(items.Count);
                int index1 = items[index11];

                Scrip1.HideRandomWords(index1);
                chosen.Add(index1);
                items.Remove(index1);

                Random randomNum2 = new Random();
                int index22 = randomNum2.Next(items.Count);
                int index2 = items[index22];

                Scrip1.HideRandomWords(index2);
                chosen.Add(index2);
                items.Remove(index2);

                Random randomNum3 = new Random();
                int index33 = randomNum3.Next(items.Count);
                int index3 = items[index33];
                             
                Scrip1.HideRandomWords(index3);
                chosen.Add(index3);
                items.Remove(index3);

            }
            else if(remainder == 2)
            {
                Random randomNum1 = new Random();
                int index11 = randomNum1.Next(items.Count);
                int index1 = items[index11];

                Scrip1.HideRandomWords(index1);
                chosen.Add(index1);
                items.Remove(index1);

                Random randomNum2 = new Random();
                int index22 = randomNum2.Next(items.Count);
                int index2 = items[index22];

                Scrip1.HideRandomWords(index2);
                chosen.Add(index2);
                items.Remove(index2);
            }

            else
            {
                Random randomNum1 = new Random();
                int index11 = randomNum1.Next(items.Count);
                int index1 = items[index11];

                Scrip1.HideRandomWords(index1);

                chosen.Add(index1);

                items.Remove(index1);
            }
            Console.Clear();

            displayText = Scrip1.GetDisplayText();
            Console.WriteLine(displayText);
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
        }
    }
}