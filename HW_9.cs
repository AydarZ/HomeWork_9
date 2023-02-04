// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string PrintNumbers(int n)
// {
//     string result = string.Empty;
//     if (n == 1) return "1";
//     else
//     {
//         result = Convert.ToString(n) + ", " + PrintNumbers(n - 1);
//     }
//     return result;
// }


// System.Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(PrintNumbers(N));





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SummOfElements(int m, int n)
// {
//     if (m <= n) // 
//     {
//         int summ = m;
//         if (m == n) return n;
//         else summ += SummOfElements(m + 1, n);
//         return summ;
//     }
//     else  // на случай если M > N
//     {
//         int summ = m;
//         if (m == n) return n;
//         else summ += SummOfElements(m - 1, n);
//         return summ;
//     }
// }

// int M = GetNumber("M");
// int N = GetNumber("N");
// System.Console.WriteLine("Сумма элементов от М до N равна: " + SummOfElements(M, N));




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int AnkermanFuction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return AnkermanFuction(m - 1, 1);
//     return AnkermanFuction(m - 1, AnkermanFuction(m, n - 1));
// }

// int M = GetNumber("m");
// int N = GetNumber("n");
// System.Console.WriteLine("А(m,n) = " + AnkermanFuction(M, N));