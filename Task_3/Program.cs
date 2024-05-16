// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    InvertArray(array);
    System.Console.WriteLine();
    PrintArray(array);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange);
    return tempArray;
}
void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");
}
void InvertArray(int[] array, int i = 0)
{
    if (i != array.Length)
    {
        InvertArray(array, i + 1);
        Console.Write($"{array[i]} ");
    }
}

Main();