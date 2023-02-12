// Решение в группах задач:
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



Console.Clear();

int[] arr = Generation();//{ -4, -8, 8, 2 };
Metod(arr);

System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

int[] Metod(int[] ar)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }

    return arr;
}

int[] Generation()
{
    Random rand = new Random();
    int[] array = new int[4];
        for (int i = 0; i < 4; i++)
        {
            array[i] = rand.Next(-99, 100);
           
            
        }
        System.Console.WriteLine("[" + string.Join(", ", array) + "]");
        return array;
}
