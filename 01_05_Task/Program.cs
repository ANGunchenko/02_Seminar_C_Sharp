﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8



Console.Clear();
Console.Write ("Введите трёхзначное число: ");
int num = Convert.ToInt32 (Console.ReadLine());
string str = Convert.ToString (num);
Console.Write (str [2]);



// Console.Write ("Введите трёхзначное число: ");
// int num = Convert.ToInt32 (Console.ReadLine());
// string str = Convert.ToString (num);
// Console.Write (str [2]);



//while ()
