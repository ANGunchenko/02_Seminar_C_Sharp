// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



// Console.Clear();

// int[,] FillAndPrintArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = i+j;
//         System.Console.Write(array[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }
//     return array;
// }

// int inputNumber(string str)
// {
//     int number;
//     string text;

//     while (true)
//     {
//         System.Console.Write(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }
//         System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
//     }
//     return number;
// }


// int m = inputNumber("Введите значение m: ");
// int n = inputNumber("Введите значение n: ");
// int[,] arr = FillAndPrintArray(m,n);


// int [] arrLastString = new int [n];

// for (int i = 0; i < arr.GetLength (0); i++)
// {
//     arrLastString [n] = arr [i, n-1];
// }


Console.Clear();

int[,] FillAndPrintArray(int m, int n)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 11);
        }
    }
    return array;
}

void PrintArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }

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

int m = inputNumber("Введите m: ");  //GetLength(0) 
int n = inputNumber("Введите n: ");  //GetLenght(1)
int[,] matrix = FillAndPrintArray(m, n);
PrintArray2D(matrix); 
System.Console.WriteLine();
for(int i = 0; i<matrix.GetLength(1); i++)
{
    int temp = matrix[0,i];
    matrix[0, i] = matrix[matrix.GetLength(0)-1, i];
    matrix[matrix.GetLength(0)-1, i] = temp;
}

PrintArray2D(matrix);
