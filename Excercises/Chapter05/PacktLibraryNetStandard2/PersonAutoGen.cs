﻿namespace Packt.Shared;

public partial class Person
{
    // a readonly property defined using only get
    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}", arg0: Name, arg1: HomePlanet);
        }
    }
    // Simplify get
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;

    public string? FavoriteIceCream { get; set; }

    private string? favoritePrimaryColor;

    public string? FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }

        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is not a primary color. " +
                        $"Choose from: red, green, blue");
            }
        }
    }
    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person? this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
        set
        {
            Person? found = Children.Find(p => p.Name == name);
            if (found is not null) found = value;
        }
    }

    private bool married = false;
    private Person? spouse = null;
    // read only property
    public bool Married => married;
    public Person? Spouse => spouse;


    // static method to marry ex. Person.(p1, p2)
    public static void Marry(Person p1, Person p2)
    {
        p1.Marry(p2);
    }

    // instance method to marry ex. nameOfPerson.Marry
    public void Marry(Person partner)
    {
        if (married) return;

        spouse = partner;
        married = true;
        partner.Marry(this);
    }

    public static Person Procreate(Person p1, Person p2)
    {
        if (p1.Spouse != p2)
        {
            throw new ArgumentException("You must be married to procreate.");
        }
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            DateOfBirth = DateTime.Now
        };
        // This will add children to p1Husband and p2Wife
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    // instance method to "multiply" ex. nameOfPerson.ProcreateWith(adah);
    // this will return Procreate(this(nameOfPerson, Person partner)
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // operator to "marry"
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);
        return p1.Married && p2.Married;
    }

    // operator to "multiply"
    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }

    // method with a local function
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);
        // local function
        int localFactorial(int localNumber) 
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }
}
