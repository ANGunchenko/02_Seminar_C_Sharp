// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int[] array = Generation(20, 1, 200);
// int result = Counter(array);
// System.Console.WriteLine("Кол-во элементов:  " + result);



Console.Clear();

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;


}

int[] Generation(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange);


    }
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    return array;
}



