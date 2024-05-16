// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

using System.Globalization;

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    if (M > N)
        (M, N) = (N, M);
    PrintNumbers(M, N);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (N < M) return;
    PrintNumbers(M, N - 1);
    System.Console.Write(N + " ");
}

Main();