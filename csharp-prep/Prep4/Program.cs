using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> words = new List<int>();
        
        
    
        int x = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while ( x !=0)
        {   

            Console.Write("Enter number: ");
            string valueFromEnter = Console.ReadLine();
            x = int.Parse(valueFromEnter);

            if (x!=0)
            {
                words.Add(x);
            }

        }
        int suma = words.Sum();
        Console.WriteLine($"The sum is: {suma}");
        double avera=words.Average();
        Console.WriteLine($"The Average is: {avera}");
        int max = words.Max();
        Console.WriteLine($"The Largest Number is: {max}");
        int min = words.Min();
        Console.WriteLine($"The smallest positive number is: {min}");
        words.Sort();
        Console.WriteLine($"The sorted list is: ");

        foreach (int word in words)
        {
            Console.WriteLine(word);
        }
            
    }
}