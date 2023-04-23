using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade percent:");
        string valueFromGrade = Console.ReadLine();

        int x = int.Parse(valueFromGrade);
        int y = 90;
        int w = 80;
        int u = 70;
        int z = 60;
        
        string gradeA = "A";
        string gradeB = "B";
        string gradeC = "C";
        string gradeD = "D";
        string gradeF = "F";


        if (x == y || x > y)
        {
            Console.Write($"Your Grade is {gradeA}.");
        }
        else if (x == w || (x > w && x < y))
        {
            Console.Write($"Your Grade is {gradeB}.");
        }
        else if (x == u || (x > u && x < w))
        {
            Console.Write($"Your Grade is {gradeC}.");
        }
        else if (x == z || (x > z && x < u))
        {
            Console.Write($"Your Grade is {gradeD}.");
        }
        
        else
        {
            Console.Write($"Your Grade is {gradeF}.");
        }
        
        if (x > u || x == u)
        {
            Console.Write(" Congratulations!! You Pass the exam!!");
        }
        else
        {
            Console.Write("Sorry try the next time");
        }
    }
}