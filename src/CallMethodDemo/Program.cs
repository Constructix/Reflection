using System.Reflection;
using System.Reflection.Emit;

Type? t =  Type.GetType("Foo");
Object obj = Activator.CreateInstance(t);
MethodInfo mi = t.GetMethod("Bar");
mi.Invoke(obj, null);


mi = t.GetMethod("DisplayMessage");
mi.Invoke(obj, new object?[] { "Hello World"});


var p = new Person("Rodney", "Dangerfield");
mi = t.GetMethod("PassInPersonObject");
mi.Invoke(obj, new object?[] { p });

MethodInfo methodInfo = new MethodBuilder();

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



public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString() => $"{this.FirstName} {this.LastName}";

}

