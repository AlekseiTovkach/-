// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.Write($"Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());


// Console.Write($"Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();

//     return (start + "\t" + PrintNumbers(start + 1, end));

// }

// Console.WriteLine(PrintNumbers(M, N));


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int Sum(int M, int N)
// {
//     if (M == N) return M;
//     return M + Sum(M + 1, N);

// }

// Console.WriteLine($"Сумма чисел от {M} до {N} = {Sum(M, N)}");



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


// Console.Write("Введите число M: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Ackerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (n == 0)
//         return Ackerman(m - 1, 1);
//     else
//         return Ackerman(m - 1, Ackerman(m, n - 1));
// }


// Console.WriteLine($"n = {B}; m = {A} -> {Ackerman(B, A)}");



