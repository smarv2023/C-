﻿using DemoLibrary1;

Console.WriteLine("What is your first name?");
string firstName = Console.ReadLine();

Console.WriteLine("What is your last name?");
string lastName = Console.ReadLine();

string fullName = PersonProcessor.JoinName(firstName, lastName);

Console.WriteLine($"Your full name is {fullName}");