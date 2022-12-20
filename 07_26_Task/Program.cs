Console.Clear();

int[] newArr = func(2, 3, 8);
System.Console.WriteLine($"{newArr[0]} - {newArr[1]}");

int[] func(int a, int b, int c)
{
    int[] arr = new int[2];
    arr[0] = a + b;
    arr[1] = b + c;
    return arr;
}

// Console.Clear();

// int[] newArr = func(2, 3, 8);
// System.Console.WriteLine($"{newArr[0]} - {newArr[1]}");

// int[] func(int a, int b, int c)
// {
//     int[] arr = new int[2];
//     arr[0] = a + b;
//     arr[1] = b + c;
//     return arr;
// }
