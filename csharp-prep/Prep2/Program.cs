using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage letter grade? ");
        string textvalue = Console.ReadLine();

        float grade = float.Parse(textvalue);
        string letter ="";

        if (grade >= 90)
        {
            letter = "A";
            if (grade-90 < 3)
            {
                letter += "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade - 80 < 3)
            {
                letter += "-";
            }
            else if(grade - 80 >= 7)
            {
                letter += "+";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade - 70 < 3)
            {
                letter += "-";
            }
            else if(grade - 70 >= 7)
            {
                letter += "+";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade - 60 < 3)
            {
                letter += "-";
            }
            else if(grade - 60 >= 7)
            {
                letter += "+";
            }
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations! you passed this course!");
        }
        else 
        {
            Console.WriteLine("Better luck next time");
        }

    }
}