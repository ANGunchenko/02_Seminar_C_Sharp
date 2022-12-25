// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");

if (!Merge(N, M))
{
    Swap();
}
Number(N,M);
// System.Console.WriteLine($"{M}, {N}");

bool Merge(int n,int m) 
{
    if(n>m)
    return true;
    else
    return false;
}

void Swap()
{
    int temp=N;
    N=M;
    M=temp;
// 	int temp = n;
// 	n = m; 
// 	m = temp;
// System.Console.WriteLine($"{m}, {n}");
}

void Number(int n,int m)
{
    if (n==m-1)
    {
        return;
    }
 Number(n-1,m);
 System.Console.Write($" {n};");
}

int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
