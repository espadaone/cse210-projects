using System;

class Program
{
    static void Main(string[] args)
    
    
    {
        
        string high="Higher";
        string low="Lower";
        string guess="You guessed it!";
    
    
        
        Random randomGenerator = new Random();
        int y = randomGenerator.Next(1,101);
        
        int x = -1;
        
        while ( x !=y)
        {   
            Console.Write("What is your guess? ");
            string valueFromguess = Console.ReadLine();
            x = int.Parse(valueFromguess);

            if (x < y)
            {
                Console.WriteLine($"{low}");
            }
            else if (x > y)
            {
                Console.WriteLine($"{high}.");
            }
            else
            {
                Console.WriteLine($"{guess}");
            }
        }
    } 
    
}