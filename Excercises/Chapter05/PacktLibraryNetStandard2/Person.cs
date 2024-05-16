using System.Data;
using System.Diagnostics;

namespace Packt.Shared;
public partial class Person : object
{
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();

    // constants
    public const string Species = "Homo Spiens";

    // read-only fields
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    // constructors
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    // decontructors
    public void Deconstruct(out string? name, out DateTime dob)
    {
        name = Name;
        dob = DateOfBirth;
    }
    public void Deconstruct(out string? name, out DateTime dbo, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dbo = DateOfBirth;
        fav = FavoriteAncientWonder;
    }


    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a  {DateOfBirth}.");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    // Overload methods
    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHello(string? Name)
    {
        return $"{Name} says 'Hello, {Name}!'";
    }

    // Overload simplify
    public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
    }

    // Controlling how parameters are passed
    public void PassingParameters(int x, ref int y, out int z)
    {
        // out parameters cannot have a default
        // AND must be initialized inside the method
        z = 99;
        // increment each parameter
        x++;
        y++;
        z++;
    }
}
