//conversion Helpers Parse and Convert
string numberSting = "12345";
int result =  int.Parse(numberSting);
int result2 = Convert.ToInt32(numberSting);

string myBoolString = "true";
bool myBool =  bool.Parse(myBoolString);
bool myBool2 = Convert.ToBoolean(myBoolString);

Console.WriteLine($"The number is {result} and {result2}");
Console.WriteLine($"The boolean value is {myBool} and {myBool2}");