using System.IO.Pipelines;

// System.Console.WriteLine("Отчёт");
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
// CountDown(num1);

// System.Console.WriteLine("Сумма");
// sumToN(num1);

// CountDownWithDepth(num1);

Broken(num1);


// Я поставил Console.WriteLine после рекурсивного вызова, из-за этого программа сначала доходит до минимального значения (0), а уже потом выводит их по очереди (от меньшего к большему) на экран
void CountDown(int n) {
    if (n == 0) {
        return;
    }

    CountDown(n - 1);
    System.Console.WriteLine(n);
}


int sumToN(int n) {
    System.Console.WriteLine($"Вход: {n}");

    if (n == 1) {
        return 1;
    }

    int result = n;
    result += sumToN(n - 1);

    System.Console.WriteLine($"Выход: {n}, result = {result}");
    return result;
}


void CountDownWithDepth(int n, int depth = 0) {
    System.Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n = {n}");

    if (n == 0) return;

    CountDownWithDepth(n - 1, depth + 1);
}

void Broken(int n) {
    Broken(n + 1);
}