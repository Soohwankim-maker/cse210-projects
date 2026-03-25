class Program
{

    public static void ProcessPerson(Person person)
    {
        Console.Write(person.GetPersonInformation());

        Console.WriteLine($", My Salary is: {person.GetSalary()}");
    }
    public static void Main(string[] args)
    {
        Doctor myDoctor, myDoctor2;

        myDoctor = new Doctor("Ax", "Bob", "Budge", 75, 210);

        myDoctor2 = new Doctor("Knife", "Bobby", "Billy", 75, 210);

        Police myPolice = new Police("Gun", "Lance", "Bob", 43, 198);

        myPolice.SetWeight(myPolice.GetWeight() + 5);
        myPolice.SetAge(myPolice.GetAge() + 1);


        List<Person> myPeople = new List<Person>();
        myPeople.Add(myDoctor);
        myPeople.Add(myDoctor2);
        myPeople.Add(myPolice);

        myDoctor.SetSalary(23424234.0);
        myDoctor2.SetSalary(2398435.0);

        foreach(Person tempPerson in myPeople)
        {
            ProcessPerson(tempPerson);
        }

    }
}