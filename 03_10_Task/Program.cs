//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string[] part = { "x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0" };
System.Console.Write("Введите № четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine(part[0]);
}
else if (n == 2)
{
    Console.WriteLine(part[1]);
}
else if (n == 3)
{
    Console.WriteLine(part[2]);
}
else if (n == 4)
{
    Console.WriteLine(part[3]);
}

else
{
Console.WriteLine("Не является четвертью координатной плоскости");
}
