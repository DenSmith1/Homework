// Домашнее задание 1. Показать натуральные числа от M до N

// void ShowNumbersDown(int M, int N)
// {
//     if (M < N) return;
//     Console.Write(M + " ");
//     ShowNumbersDown(M - 1, N);
// }

// void ShowNumbersUp(int M, int N)
// {
//     if (M < N) return;
//     ShowNumbersUp(M - 1, N);
//     Console.Write(M + " ");
// }

// Console.Clear();
// Console.Write("Введите натуральное число (M): ");
// int M = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите натуральное число (N): ");
// int N = int.Parse(Console.ReadLine() ?? "0");

// if (N >= M) ShowNumbersUp(N, M);
// else ShowNumbersDown(M, N);



// Домашнее задание 2. Найти сумму элементов от M до N, N и M заданы

double ElementsSummary(int M, int N)
{
    double Sum = M;
    if (M >= N) return Sum;
    else return Sum + ElementsSummary(M + 1, N);
}

Console.Clear();
Console.Write("Введите натуральное число (M): ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число (N): ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Сумма элементов от {M} до {N} = {ElementsSummary(M, N)}");