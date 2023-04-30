using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string username=PromptUserName();
        PromptUserNumber();
        int square=SquaredNumber();
        DisplayResult(username, square);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
                
    static string PromptUserName()
    {
        Console.Write("Put your UserName: ");
        string username = Console.ReadLine();
        Console.WriteLine($"The username is: {username}");
        return username;
    }  

    static int PromptUserNumber()
    {
        Console.Write("What is your Usernumber?:");
        string entrada = Console.ReadLine();
        int usn = int.Parse(entrada);
        Console.WriteLine("The UserNUmber enter is: " + usn);
        int userNumber = usn;
        return userNumber;

    }         
    static int SquaredNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string entrada = Console.ReadLine();
        int num = int.Parse(entrada);
        int  square= num * num;
        return square;
    }             
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is: {square}");
    }


}
