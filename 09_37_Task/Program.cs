// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8




Console.Clear();
int A = InputNumber("Введите число: ");
int B = InputNumber("Введите степень: ");
Console.WriteLine(PowAToB(A,B));

int PowAToB(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    int result = a * PowAToB(a, b - 1);
    return result;
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
