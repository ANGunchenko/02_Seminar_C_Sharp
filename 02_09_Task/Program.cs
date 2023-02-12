Console.Clear();

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

string number3 = (Math.Pow(number1, 2) == number2) || (Math.Pow(number2, 2) == number1) ? "Да" : "Нет";
Console.WriteLine(number3);

// if ((Math.Pow(number1, 2) == number2) || (Math.Pow(number2, 2) == number1))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
