//interpulation
string name = "Alice";
string greeting = $"Hello, {name}!";

//string concatination
string part1 = "Hello, ";
string part2 = "World!";
string message = string.Concat(part1, part2);

//string format method
int age = 30;
string info = string.Format("Name: {0}, Age: {1}", name, age);

//verbatim string
string filePath = @"C:\Users\Alice\Documents\file.txt";
