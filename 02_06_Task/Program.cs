Console.Clear();
int number = new Random().Next(100, 1000);
string number2 = Convert.ToString(number);
Console.WriteLine(number);
Console.WriteLine($"{number2[0]} {number2[2]}");
