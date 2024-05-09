
namespace Persons;
internal class Program
{
    private static void Main(string[] args)
    {
        // Add Person object
        Person marvin = new Person("Marvin", 50);
        Person maria = new Person("Maria", 49);
        Person mario = new Person("mario", 17);
        Person peach = new Person("Peach", 18);

        Person apolonio = new Person("Apolonio", 0);
        Person ambrocia = new Person("Ambrocia", 0);
        Person arnulfo = new Person("Arnulfo", 0);
        Person edna = new Person("Edna", 0);

        // Parents
        marvin.Parents.Add(apolonio);
        marvin.Parents.Add(ambrocia);

        maria.Parents.Add(arnulfo);
        maria.Parents.Add(edna);

        mario.Parents.Add(marvin);
        mario.Parents.Add(maria);

        Family family = new Family();
        family.AddMember(marvin);
        family.AddMember(maria);
        family.AddMember(mario);
        family.AddMember(peach);

        foreach (Person person in family)
            person.DisplayInfor();

        Console.ReadKey();
    }
}