// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    int result = Accerman(M, N);
    PrintNumbers(result);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int Accerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Accerman(m - 1, 1);
    else
        return Accerman(m - 1, Accerman(m, n - 1));
}
void PrintNumbers(int N)
{
    System.Console.Write(N + " ");
}
Main();