// See https://aka.ms/new-console-template for more information
var Rocket = @"
            ^
           / \
           | |
           | |
           | |
          /___\
            W";
string space = "\n";

for (int i = 10; i >= 0; i--)
{

    Console.WriteLine(String.Concat(Enumerable.Repeat(space, 10-i)));
    Console.WriteLine(Rocket);
    Console.WriteLine(String.Concat(Enumerable.Repeat(space, i)));
    Console.WriteLine("________________________________________");
    Thread.Sleep(1000);
    Console.Clear();

}

Console.WriteLine("You have reached the moon!");
Console.WriteLine(String.Concat(Enumerable.Repeat(space, 10)));
Console.WriteLine(Rocket);
Console.WriteLine("________________________________________");
Thread.Sleep(6000);
Console.Clear();