﻿// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница



Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int number1 = Convert.ToInt32 (Console.ReadLine());

if (number1 == 1)
{
    Console.WriteLine ("Понедельник");
}

else if (number1 == 2)
{
    Console.WriteLine ("Вторник");
}

else if (number1 == 3)
{
    Console.WriteLine ("Среда");
}

else if (number1 == 4)
{
    Console.WriteLine ("Четверг");
}

else if (number1 == 5)
{
    Console.WriteLine ("Пятница");
}

else if (number1 == 6)
{
    Console.WriteLine ("Суббота");
}

else if (number1 == 7)
{
    Console.WriteLine ("Воскресенье");
}

else 
{
    Console.WriteLine ("Введено не верное число");
}
