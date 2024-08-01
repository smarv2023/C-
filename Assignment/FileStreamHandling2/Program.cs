using FileStreamHandling2;
using System.Runtime.Serialization;

StreetAddress add1 = new StreetAddress { StreetNumber = 123, StreetName = "Portage street", City = "Winnipeg" };
StreetAddress add2 = new StreetAddress { StreetNumber = 456, StreetName = "Inkster Street", City = "Winnipeg" };
StreetAddress add3 = new StreetAddress { StreetNumber = 789, StreetName = "Main street", City = "Winnipeg" };

Person person1 = new Person { FirstName = "John", LastName = "Doe", Addresses = new List<StreetAddress>() { add1, add2, add3 } };

Person person2 = new Person { FirstName = "Johnson", LastName = "Deer", Addresses = new List<StreetAddress>() { add2 } };

Person person3 = new Person { FirstName = "Johnny", LastName = "Doo", Addresses = new List<StreetAddress>() { add3, add2 } };

List<Person> people = new List<Person> { person1, person2, person3 };

ConsoleColor foregroundColor = Console.ForegroundColor;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("BinaryFormatter is Deprecated so I use JSON Serializer");
Console.WriteLine();
//This will catch the file from JSON DeserializationFile
List<Person>? deserializeOutput = new List<Person>();
try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("JSON Serialization");
    Control.SerializeFile(people);
    Console.ForegroundColor = foregroundColor;

    Console.ReadKey();

    Console.WriteLine("\nJSON Deserialize");
    deserializeOutput = Control.DeserializeFile();
    if (deserializeOutput != null )
    {
        foreach (Person deserializePerson in deserializeOutput)
        {
            Console.WriteLine(deserializePerson);
            if (deserializePerson.Addresses != null)
            {
                foreach (StreetAddress deserializeAddress in deserializePerson.Addresses)
                {
                    Console.WriteLine(deserializeAddress);
                }
            }    
        }
    }
    Console.ReadKey();
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine(ex.Message);
}
catch (SerializationException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred while writing to the file.");
    Console.WriteLine($"Exception Message: {ex.Message}");
}

