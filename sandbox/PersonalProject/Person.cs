
abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        SetWeight(weight);
    }

    public virtual string GetPersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }

    public abstract double GetSalary();
    
    public int GetAge()
    {
        return _age;
    }

    public int GetWeight()
    {
        return _weight;
    }

    public void SetWeight(int weight)
    {
        if(weight < 4 || weight > 500)
        {
            Console.WriteLine("Invalid weight");
        }
        else
        {
            _weight = weight;
        }
    }

    public void SetAge(int age)
    {
        if(age < 0 || age > 125)
        {
            Console.WriteLine("Invalid age");
        }
        else
        {
            _age = age;
        }
    }
}