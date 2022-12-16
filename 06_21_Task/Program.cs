Console.Clear();
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange + 1); //.NextDouble()  [0, 1]
    }
    return tempArr;
}

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

const int SIZE = 10;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);


// int inputNumber(string str)
// {
//     int number;
//     string text;

//     while (true)
//     {
//         System.Console.WriteLine(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }
//         System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
//     }
//     return number;
// }
