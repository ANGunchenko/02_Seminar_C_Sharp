﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет



Console.Clear();
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number2 * number2) == number1)
{
   Console.WriteLine("Число 1 является квадратом числа 2");
}
else
{
    Console.WriteLine("Число 1 не является квадратом числа 2"); 
}
