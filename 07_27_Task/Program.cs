// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();
int m = inputNumber("Введите значение m");
int n = inputNumber("Введите значение n");
int[,] arr = FillAndPrintArray(m,n);


int[,] FillAndPrintArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i+j;
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}
    return array;
}



int inputNumber(string str)
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

// Console.Clear();
// System.Console.WriteLine("Введите размер массив M x N");
// int m = inputNumber("М = ");
// int n = inputNumber("N = ");
// int[,] array = new int[m,n]; // 0 символов - одномерный массив, 1  запятая - двумерный массив, 2 запятые - трёхмерный мамсиив
// Random rand = new Random();

// // System.Console.WriteLine(array.GetLength(0));
// // System.Console.WriteLine(array.GetLength(1));
// // System.Console.WriteLine(array.Length);

// for(int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         array[i,j] = rand.Next(-10, 10);
//         System.Console.Write(array[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }
