// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write($"Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());


Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();

    return (start + "\t" + PrintNumbers(start + 1, end));

}

Console.WriteLine(PrintNumbers(M, N));