using System.ComponentModel.DataAnnotations;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// System.Console.WriteLine("Отчёт");
// Console.Write("Введите число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// CountDown(num1);

// System.Console.WriteLine("Сумма");
// sumToN(num1);

// CountDownWithDepth(num1);

// Broken(num1);


// Часть 4
// System.Console.WriteLine("Задача A. Сумма цифр числа");
// Console.Write("Введите число: ");
// int numA = int.Parse(Console.ReadLine()!);

// System.Console.WriteLine($"Сумма цифр числа {numA}: {sumDigits(numA)}");

// System.Console.WriteLine();
// System.Console.WriteLine("Задача B. Возведение в степень");
// Console.Write("Введите число, возводимое в степень: ");
// int numB1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// int numB2 = int.Parse(Console.ReadLine()!);

// System.Console.WriteLine($"{numB1}^{numB2} = {Power(numB1, numB2)}");


// Итоговая задача
// System.Console.WriteLine("Рекурсивный анализ числа");
// Console.Write("Введите положительное целое число: ");
// int number = int.Parse(Console.ReadLine()!);

// System.Console.WriteLine();
// System.Console.WriteLine($"Количество цифр: {CountDigits(number)}");
// System.Console.WriteLine($"Сумма цифр: {sumDigits(number)}");
// System.Console.WriteLine($"Максимальная цифра: {MaxDigit(number)}");
// Console.Write("Цифры: "); PrintDigits(number);


// Бонус
System.Console.WriteLine("Бонус");
Console.Write("Введите число: ");
int len = int.Parse(Console.ReadLine()!);

System.Console.WriteLine();
PrintPattern(len);
System.Console.WriteLine();
PrintPattern(len, false);


// Я поставил Console.WriteLine после рекурсивного вызова, из-за этого программа сначала доходит до минимального значения (0), а уже потом выводит их по очереди (от меньшего к большему) на экран
// void CountDown(int n) {
//     if (n == 0) {
//         return;
//     }

//     CountDown(n - 1);
//     System.Console.WriteLine(n);
// }


// int sumToN(int n) {
//     System.Console.WriteLine($"Вход: {n}");

//     if (n == 1) {
//         return 1;
//     }

//     int result = n;
//     result += sumToN(n - 1);

//     System.Console.WriteLine($"Выход: {n}, result = {result}");
//     return result;
// }


// void CountDownWithDepth(int n, int depth = 0) {
//     System.Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n = {n}");

//     if (n == 0) return;

//     CountDownWithDepth(n - 1, depth + 1);
// }

// void Broken(int n) {
//     Broken(n + 1);
// }

// Часть 4
// int sumDigits(int n) {
//     if (n == 0) {
//         return 0;
//     }

//     int result = n % 10;
//     result += sumDigits(n / 10);

//     return result;
// }

// int Power(int x, int n) {
//     if (n == 0) {
//         return 1;
//     }

//     int result = Power(x, n - 1);
//     result *= x;

//     return result;
// }


// Итоговая задача
// int CountDigits(int n) {
//     if (n == 0) return 0;

//     int result = 1;
//     result += CountDigits(n / 10);

//     return result;
// }

// void PrintDigits(int n) {
//     if (n == 0) return;

//     PrintDigits(n / 10);
//     Console.Write($"{n % 10} ");
// }

// int MaxDigit(int n) {
//     if (n == 0) return 0;

//     int max = MaxDigit(n / 10);

//     if (n % 10 >= max) return n % 10;
//     else return max;
// }


// Бонус
void PrintPattern(int n, bool topDown = true) {
    if (n == 0) {
        return;
    }

    if (topDown) {
        PrintPattern(n - 1);
        string result = new string('*', n);
        System.Console.WriteLine(result);
    } else {
        string result = new string('*', n);
        System.Console.WriteLine(result);
        PrintPattern(n - 1, false);
    }
}