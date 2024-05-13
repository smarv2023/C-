using Animals;
using System.Xml.Linq;

// Create instance of class
var rex = new Dog("Rex", 5);
var whiskers = new Cat("Whiskers", 3);
var tweety = new Bird("Tweety", 1);
Console.WriteLine($"Initial object of class:\n{rex}\n{whiskers}\n{tweety}");

var animals = new List<Animal>();
animals = [rex, whiskers, tweety];

// added class1 to add edit delete pet
new Class(animals);

