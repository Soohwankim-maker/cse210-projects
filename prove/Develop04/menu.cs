class Menu
{
    public void DisplayMenu()
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nSelect an option: ");
            choice = int.Parse(Console.ReadLine());

            StartSelectedActivity(choice);
        }
    }

    public void StartSelectedActivity(int choice)
    {
        switch (choice)
        {
            case 1:
                new BreathingActivity().Run();
                break;
            case 2:
                new ReflectingActivity().Run();
                break;
            case 3:
                new ListingActivity().Run();
                break;
        }
    }
}