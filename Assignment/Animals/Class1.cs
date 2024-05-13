using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace Animals
{
    internal class Class
    {
        private List<Animal> animals;
        string? readInput;
        int choice;
        bool exitMenu = false;
        int index;
        // Constructor
        public Class(List<Animal> animals)
        {
            this.animals = animals;
            Control();

        }
        /*
            This is to Control adding more pet and viewing it
         */
        public void Control()
        {
            // Ask user if they want to view pets, add pet, or exit
            Console.WriteLine();
            do
            {
                Console.WriteLine("Select from the following: Press number");
                Console.WriteLine("1.) View pets\n2.) Add more pet\n3.) Edit\n4.) Delete\n5.) Exit");
                readInput = Console.ReadLine();
                Console.Clear();

                if (readInput != null)
                {
                    if (int.TryParse(readInput, out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Animal in the list:");
                                foreach (var animal in animals)
                                    Console.WriteLine($"{animals.IndexOf(animal)}.) {animal}");
                                Console.WriteLine();
                                break;

                            case 2:
                                choice = 0;
                                bool insideMenu = false;
                                string? name;
                                int age;
                                string pet;
                                do
                                {
                                    Console.WriteLine("Choose a pet to add: Press number");
                                    Console.WriteLine("1.) Dog\n2.) Cat\n3.) Bird\n4.) Back");
                                    readInput = Console.ReadLine();
                                    if (int.TryParse(readInput, out choice))
                                    {
                                        switch (choice)
                                        {
                                            case 1:
                                                Console.Clear();
                                                pet = "Dog";
                                                Console.WriteLine(new string('-', 20));
                                                name = ValidateName(pet);
                                                age = ValidateAge(pet);
                                                animals.Add(new Dog(name, age));
                                                Console.WriteLine("Pet added!");
                                                Console.WriteLine();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                pet = "Cat";
                                                Console.WriteLine(new string('-', 20));
                                                name = ValidateName(pet);
                                                age = ValidateAge(pet);
                                                animals.Add(new Cat(name, age));
                                                Console.WriteLine("Pet added!");
                                                Console.WriteLine();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                pet = "Bird";
                                                Console.WriteLine(new string('-', 20));
                                                name = ValidateName(pet);
                                                age = ValidateAge(pet);
                                                animals.Add(new Bird(name, age));
                                                Console.WriteLine("Pet added!");
                                                Console.WriteLine();
                                                break;
                                            case 4:
                                                insideMenu = true;
                                                break;
                                            default:
                                                Console.WriteLine("Please select from the menu");
                                                break;
                                        }
                                    }
                                } while (insideMenu == false);
                                break;
                            case 3:
                                Console.Clear();
                                choice = 0;
                                index = PrintOutList(index);

                                do
                                {
                                    Console.WriteLine("Select what to edit: Type the number\n1.) NAME\n2.) AGE\n3.) Exit");
                                    readInput = Console.ReadLine();
                                    if (readInput != null)
                                        int.TryParse(readInput, out choice);

                                } while (choice == 0 || choice > 3);
   
                                if (choice == 1)
                                {
                                    string newName = "";
                                    do
                                    {
                                        Console.WriteLine($"{animals[index].GetType().Name} current name: {animals[index].Name}");
                                        Console.Write("Enter new name: ");
                                        readInput = Console.ReadLine();
                                        if (readInput != null)
                                        {
                                            if (!int.TryParse(readInput, out int input))
                                                newName = readInput;
                                        }
                                    } while (newName == "");

                                    animals[index].Name = newName;
                                }
   
                                if (choice == 2)
                                {
                                    int newAge = -1;
                                   
                                    do
                                    {
                                        Console.WriteLine($"{animals[index].Name} current age: {animals[index].Age}");
                                        Console.Write("Enter new age: ");
                                        readInput = Console.ReadLine();
                                        if (readInput != null)
                                            int.TryParse(readInput, out newAge);

                                    } while (newAge < 1);

                                    animals[index].Age = newAge;
                                }
                                Console.WriteLine((choice == 1) ? "Name Updated" : "Age Updated");
                                Console.WriteLine();

                                break;
                            case 4:
                                Console.Clear();
                                string? yesOrNo = "";
                                index = PrintOutList(index);
                                do
                                {
                                    Console.WriteLine("Are you sure you want to DELETE this pet? (Y/N)");
                                    Console.WriteLine($"{animals[index].GetType().Name} name: {animals[index].Name} age: {animals[index].Age}");
                                    readInput = Console.ReadLine();
                                    if (readInput != null)
                                        yesOrNo = readInput.ToUpper();
                                } while (yesOrNo != "Y" && yesOrNo != "N");

                                if (yesOrNo == "Y")
                                {
                                    animals.Remove(animals[index]);
                                    Console.WriteLine("Pet is Deleted");
                                }
                                Console.WriteLine();

                                break;
                            case 5:
                                exitMenu = true;
                                break;

                            default:
                                break;
                        }
                    }
                }
            } while (exitMenu == false);
            Console.WriteLine("Good bye!");
            Console.ReadLine();
        }

        // Helper methods
        string ValidateName(string pet)
        {
            readInput = "";
            do
            {
                Console.WriteLine($"Enter the name of the {pet} pet: ");
                readInput = Console.ReadLine();
            } while (readInput == "");

            return $"{readInput}";
        }

        int ValidateAge(string pet)
        {
            int result;
            readInput = "";
            do
            {
                Console.WriteLine($"Enter the age of the {pet} pet: ");
                readInput = Console.ReadLine();
            } while (!int.TryParse(readInput, out result));

            return result;
        }

        int PrintOutList(int index)
        {
            index = -1;
            Console.WriteLine("Index\tAnimal Type\tAnimal Name\tAnimal Age");
            foreach (var animal in animals)
                Console.WriteLine($"[{animals.IndexOf(animal)}]\t{animal.GetType().Name}\t\t{animal.Name}      \t{animal.Age}");

            Console.WriteLine(new string('-', 20));
            bool selected = false;
            do
            {
                Console.WriteLine("Select index: Type the index number");
                readInput = Console.ReadLine();
                if (readInput != null)
                    selected = int.TryParse(readInput, out index);

            } while (index > animals.Count - 1 || !selected || index < 0);
            return index;
        }
    }
}
