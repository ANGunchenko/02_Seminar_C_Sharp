// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



Console.Clear();
int A = InputNumber("Введите число: ");
Console.WriteLine(sumNumber(A));

int sumNumber(int a)
{
    if (a <= 0)
    {
        return 0;
    }
    int sum = a % 10 + sumNumber (a/10);
    return sum;
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
