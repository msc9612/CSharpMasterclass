//lgoicaal operators: && (AND), || (OR), ! (NOT), ^ (XOR)

//Variants of OR statements
//true || true -> true
//true || false -> true
//false || true -> true
//false || false -> false

//Variants of AND statements
//true && true -> true
//true && false -> false
//false && true -> false
//false && false -> false



using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

bool isRainy = false;
bool hasUmbrella = true;

if (isRainy && hasUmbrella)
{
    Console.WriteLine("You can go outside with your umbrella.");
}
else if (isRainy && !hasUmbrella)
{
    Console.WriteLine("It's raining! You should stay inside.");
}
else if (!isRainy || hasUmbrella)
{
    Console.WriteLine("The weather is fine, you can go outside.");
}


int age = 18;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else if  (age > 12 && age < 18)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are a minor.");
}

int num1 = 5;
int num2 = 5;

bool isEqual = (num1 == num2); // true
bool isNotEqual = (num1 != num2); // false
bool isGreater = (num1 > num2); // false
bool isLessOrEqual = (num1 <= num2); // true
Console.WriteLine($"isEqual: {isEqual}, isNotEqual: {isNotEqual}, isGreater: {isGreater}, isLessOrEqual: {isLessOrEqual}");

Console.Write("Enter month number (1-12): ");
int month = int.Parse(Console.ReadLine());

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("It's winter.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("It's spring.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("It's summer.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("It's autumn.");
        break;
    default:
        Console.WriteLine("Invalid month.");
        break;
}