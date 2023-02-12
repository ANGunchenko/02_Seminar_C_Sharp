// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



Console.Clear();

int num_1 = inputNumber("Введите 1-ое число: ");
int num_2 = inputNumber("Введите 2-ое число: ");
int num_3 = inputNumber("Введите 3-ое число: ");
func(num_1, num_2, num_3);




void func(int num_1, int num_2, int num_3)
{
    if ((num_1 > (num_2 + num_3)) || (num_2 > (num_1 + num_3)) || (num_3 > (num_1 + num_2)))
        System.Console.WriteLine("Треугольника с такими сторонами не существует!");
    else
        System.Console.WriteLine("Есть такой треугольник!");
}



int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
