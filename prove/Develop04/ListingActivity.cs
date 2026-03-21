class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who are your heroes?"
    };

    private List<string> _items = new List<string>();
    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You may begin in...");
        ShowCountdown(5);

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            _items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {_items.Count} items!");

        DisplayEndingMessage();
    }
}