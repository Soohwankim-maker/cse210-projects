
class ReflectingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you did something difficult.",
        "Think of a time you helped someone.",
        "Think of a time you showed strength."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made this different?",
        "How can you use this again?"
    };

    private Random _random = new Random();

    public ReflectingActivity()
        : base("Reflection Activity",
        "Reflect on times of strength and growth.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Reflect on the following questions...");

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.Write($"\n> {question} ");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}

