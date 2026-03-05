public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What challenge helped me grow today?",
        "What is something small that made me happy today?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("How would you describe your mood today? ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(date, prompt, response, mood);
        _entries.Add(entry);

        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayEntries()
    {
        Console.WriteLine($"\nYou have {_entries.Count} journal entries.");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}|{entry.Mood}");
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 4)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}