class BreathingActivity : BaseActivity
{
    public BreathingActivity()
        : base("Breathing Activity",
        "This activity will help you relax by guiding your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}