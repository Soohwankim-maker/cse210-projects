using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        int age;

        Console.Write("Please enter your age: ");
        string responese = Console.ReadLine();
        age = int.Parse(responese);

        Console.WriteLine($"Your age is: {age}");
        int x = 20;
        double z =12.23;
    
        if (age <= 100 && age >= 0 &&x <= 30 || z < 6)
        {
            Console.WriteLine("You are cool");
        }
        else if (age <= 100)
        {
            Console.WriteLine("You are sort of cool");
        }

        else 
        {
            Console.WriteLine("Wow you have had a lot of brithdays");
        }
    }
}