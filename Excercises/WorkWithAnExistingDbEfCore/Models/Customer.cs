
namespace WorkingWithEFCore.Models;

public partial class Customer
{
    public string FirstLast
    {
        get => $"{FirstName} {LastName}";
    }

    public string Contact
    {
        get => $"Phone number: {Phone} Email:{Email}";
    }
}

