//Operators and Order of Evaluation
int num1 = 10;
int num2 = 5;

Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");
Console.WriteLine($"Exponentiation: {num1} ^ {num2} = {Math.Pow(num1, num2)}");
Console.WriteLine();
//Order of Evaluation   
int result1 = num1 + num2 * 2; // Multiplication first
int result2 = (num1 + num2) * 2; // Parentheses change
Console.WriteLine($"Without parentheses: {num1} + {num2} * 2 = {result1}");
Console.WriteLine($"With parentheses: ({num1} + {num2}) * 2 = {result2}");


//Increment and Decrement Operators
int count = 0;
Console.WriteLine($"Initial count: {count}");
count++; // Post-increment
Console.WriteLine($"After post-increment: {count}");
++count; // Pre-increment
Console.WriteLine($"After pre-increment: {count}");
count--; // Post-decrement
Console.WriteLine($"After post-decrement: {count}");
--count; // Pre-decrement
Console.WriteLine($"After pre-decrement: {count}");
Console.WriteLine();
//Compound Assignment Operators
int value = 10;
Console.WriteLine($"Initial value: {value}");
value += 5; // value = value + 5
Console.WriteLine($"After += 5: {value}");
value -= 3; // value = value - 3
Console.WriteLine($"After -= 3: {value}");
value *= 2; // value = value * 2
Console.WriteLine($"After *= 2: {value}");
value /= 4; // value = value / 4
Console.WriteLine($"After /= 4: {value}");
value %= 3; // value = value % 3
Console.WriteLine($"After %= 3: {value}");
Console.WriteLine();
//Comparison Operators
int a = 10;
int b = 20;
Console.WriteLine($"{a} == {b}: {a == b}");
Console.WriteLine($"{a} != {b}: {a != b}");
Console.WriteLine($"{a} > {b}: {a > b}");
Console.WriteLine($"{a} < {b}: {a < b}");
Console.WriteLine($"{a} >= {b}: {a >= b}");
Console.WriteLine($"{a} <= {b}: {a <= b}");
Console.WriteLine();

//Logical Operators
bool condition1 = true;
bool condition2 = false;
Console.WriteLine($"condition1 && condition2: {condition1 && condition2}");
Console.WriteLine($"condition1 || condition2: {condition1 || condition2}");
Console.WriteLine($"!condition1: {!condition1}");
Console.WriteLine($"!condition2: {!condition2}");
Console.WriteLine();
//Ternary Operator
int age = 18;
string eligibility = (age >= 18) ? "Eligible to vote" : "Not eligible to vote";
Console.WriteLine($"Age: {age} - {eligibility}");
//Null-Coalescing Operator
string? input = null;
string output = input ?? "Default Value";
Console.WriteLine($"Output: {output}");
Console.WriteLine();
//Bitwise Operators
int bitA = 5;  // 0101 in binary
int bitB = 3;  // 0011 in binary
Console.WriteLine($"Bitwise AND: {bitA} & {bitB} = {bitA & bitB}");
Console.WriteLine($"Bitwise OR: {bitA} | {bitB} = {bitA | bitB}");
Console.WriteLine($"Bitwise XOR: {bitA} ^ {bitB} = {bitA ^ bitB}");
Console.WriteLine($"Bitwise NOT: ~{bitA} = {~bitA}");
Console.WriteLine($"Left Shift: {bitA} << 1 = {bitA << 1}");
Console.WriteLine($"Right Shift: {bitA} >> 1 = {bitA >> 1}");
Console.WriteLine();

//Operator Precedence Example
int precedenceResult = 10 + 5 * 2 - 8 / 4; // Multiplication and division first
Console.WriteLine($"Operator Precedence Result: 10 + 5 * 2 - 8 / 4 = {precedenceResult}");
int precedenceResultWithParentheses = (10 + 5) * (2 - 8) / 4; // Parentheses change order
Console.WriteLine($"With Parentheses: (10 + 5) * (2 - 8) / 4 = {precedenceResultWithParentheses}");
Console.WriteLine();

