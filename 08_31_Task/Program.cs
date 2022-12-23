// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
//  если это невозможно, программа должна вывести сообщение для пользователя.



int[,] array1 = GetArr();
int[,] array2 = new int [array1.GetLength(0), array1.GetLength(1)];
ReverseArr("Новый массив", array1, array2);
PrintArray2D(array2);


int[,] GetArr()
{
    int rows = 3;
    int colums = 3;
    int[,] arr = new int[rows, colums];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + "     ");
        }
        Console.WriteLine();
    }
    return arr;
}

void ReverseArr(string text, int[,] arr1, int[,] arr2)
{
    Console.WriteLine(text);
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            // int temp = arr[i, j];
            arr2[i, j] = arr1[j, i];
            // arr[j, i] = temp;
        }
    }
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

