// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.



Console.Clear();

System.Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) 
{
    System.Console.Write($"{i * i} ");
}
