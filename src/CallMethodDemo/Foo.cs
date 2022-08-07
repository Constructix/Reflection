using System.Reflection;

public class Foo
{
    public void Bar()
    {
        Console.WriteLine($"In {MethodInfo.GetCurrentMethod().Name}");
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PassInPersonObject(Person person)
    {
        Console.WriteLine(person.ToString());
    }
}

