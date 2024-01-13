using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string value = Console.ReadLine();
        int number = int.Parse(value);
        List<int> numbers = new List<int>();

        do
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            value = Console.ReadLine();
            number = int.Parse(value);
        }while (number != 0);

        int addition = 0;
        float average;
        int smallest_positive = 1000000000;
        int maximum = numbers[0];

        foreach (int num in numbers)
        {
            addition += num;

            if (num > maximum)
            {
                maximum = num;
            }

            if(num > 0 && num < smallest_positive)
            {
                smallest_positive = num;
            }
        }

        float list_count = numbers.Count;
        average = addition / list_count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {addition}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}