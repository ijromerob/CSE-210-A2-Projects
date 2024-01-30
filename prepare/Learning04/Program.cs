using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Multiplication","Samuel Bennett");
        Console.WriteLine(a.GetSummary());

        MathAssignment t = new MathAssignment("7.3","8-9","Fractions","Roberto Rodriguez");
        Console.WriteLine(t.GetSummary());
        Console.WriteLine(t.GetHomeworkList());

        WritingAssignment n = new WritingAssignment("The Causes of World War II","Mary Waters","European History");
        Console.WriteLine(n.GetSummary());
        Console.WriteLine(n.GetHomeworkList());
    }
}