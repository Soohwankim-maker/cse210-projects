using System;

class Program
{   

    public static void Greeting()
    {
        Console.WriteLine("Hello Bob");
    }

    public static int Addnumbers(int n1, int n2)
    {
        Console.WriteLine("Bob");
        return n1 + n2;
    }
    static void Main(string[] args)
    {
        Greeting();

        int total = Addnumbers(10, 20);

        Console.WriteLine(total);
        // Console.WriteLine("Hello Sandbox World!");
        
        //     int age;

        //     Console.Write("Please enter your age: ");
        //     string responese = Console.ReadLine();
        //     age = int.Parse(responese);

        //     Console.WriteLine($"Your age is: {age}");
        //     int x = 20;
        //     double z =12.23;
        
        //     if (age <= 100 && age >= 0 &&x <= 30 || z < 6)
        //     {
        //         Console.WriteLine("You are cool");
        //     }
        //     else if (age <= 100)
        //     {
        //         Console.WriteLine("You are sort of cool");
        //     }

        //     else 
        //     {
        //         Console.WriteLine("Wow you have had a lot of brithdays");
        //     }

        // for(int i = 0; i < 10; i+=3)
        // {
        //    Console.WriteLine(i);
        // }

        // int y =10;
        // int z = y++;
        // Console.WriteLine(y);
        // Console.WriteLine(z);


        //  for(int i = 100000; i >= -100000; i-= 10000)
        // {
        //    Console.WriteLine(i);
        //    Console.WriteLine(i + 10000);
        // }

        // bool done;
        // do
        // {
        //     Console.Write("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine("Thank you.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please input a valid age.");
        //     }
        // } while(! done);

        List<int> myData = new List<int>();
        myData.Add(10);
        myData.Add(11);
        myData.Add(12);
        myData.Add(13);
        myData.Add(14);
        myData.Add(15);

        Console.WriteLine(myData.Count);

        foreach (int i in myData)
        {
            Console.WriteLine(i);
        }

        List<string> myFriends = ["Bob", "Betty", "Jaennie"];
        myFriends.Add("Bubba");
        myFriends.Add("23423");
        // myFriends.Add("12123");

        foreach (string friend in myFriends)
        {
            Console.WriteLine(friend);
        }    
    }
}