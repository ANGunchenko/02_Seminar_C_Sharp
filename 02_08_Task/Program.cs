Console.Clear();

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());


// if (number1 % 7 == 0 &&  number1 % 23 == 0)
// {
//     Console.WriteLine("Ваше число кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Ваше число не кратно 7 и 23");
// }


string number3 = number1 % 7 == 0 && number1 % 23 == 0 ? "Ваше число кратно 7 и 23" : "Ваше число не кратно 7 и 23";
Console.WriteLine(number3);