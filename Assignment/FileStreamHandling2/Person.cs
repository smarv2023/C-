namespace FileStreamHandling2;

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<StreetAddress>? Addresses { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public class StreetAddress
{
    public int StreetNumber { get; set; }
    public string? StreetName { get; set; }
    public string? City { get; set; }

    public override string ToString()
    {
        return $"{StreetNumber} {StreetName} {City}";
    }
}
