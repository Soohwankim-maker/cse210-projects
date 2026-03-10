using System;

class Program
{
    static void Main(string[] args)
    {
        Angle myAngle = new Angle(180);
        Console.Clear();

        Console.WriteLine(myAngle.GetRadians());

        Console.WriteLine(myAngle.GetDegrees());

        myAngle.SetDegrees(270);

        Console.WriteLine(myAngle.GetRadians());
    }
}