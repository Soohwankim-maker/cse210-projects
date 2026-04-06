using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("C# Basics", "Learn C#", "May 1", "10:00 AM", "Room 101", "Dr. Smith", 50);
        Reception reception = new Reception("Networking", "Meet people", "May 2", "6:00 PM", "Hall A", "rsvp@email.com");
        OutdoorGathering outdoor = new OutdoorGathering("Picnic", "Fun outside", "May 3", "12:00 PM", "Park", "Sunny");

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}