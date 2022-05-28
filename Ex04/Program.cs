// Домашнее задание 1. Показать двумерный массив размером m×n заполненный вещественными числами

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} ");
//         Console.WriteLine();
//     }

// }
// void FillArray(int[,] matr, int minValue, int maxValue)
// {
//     int factor = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             factor = new Random().Next(minValue, maxValue);
//             matr[i, j] = new Random().Nextint() * factor;
//             matr[i, j] = Math.Round(matr[i, j], 2);
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int m = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов: ");
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите минимальное значение в массиве: ");
// int start = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите максимальное значение в массиве: ");
// int finish = int.Parse(Console.ReadLine() ?? "0");

// int[,] matrix = new int[m, n];

// FillArray(matrix, start, finish);
// Console.WriteLine("Ваш массив:");
// PrintMatrix(matrix);


// Домашнее задание 2. Задать двумерный массив следующим правилом: Aₘₙ = m+n

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} ");
//         Console.WriteLine();
//     }

// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i + j;            
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int m = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов: ");
// int n = int.Parse(Console.ReadLine() ?? "0");

// int[,] matrix = new int[m, n];

// FillArray(matrix);
// Console.WriteLine("Ваш массив:");
// PrintMatrix(matrix);


// Домашнее задание 3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }

}
void FillArray(int[,] matr, int minValue, int maxValue)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}

void ChangeArray(int[,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i++)         // счетчик с 1, чтобы не брал в расчет значения индекса = 0
    {
        for (int j = 1; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) 
                matr[i, j] = Convert.ToInt32(Math.Pow(matr[i, j], 2));
        }
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение в массиве: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение в массиве: ");
int finish = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

FillArray(matrix, start, finish);
Console.WriteLine("Ваш массив:");
PrintMatrix(matrix);
ChangeArray(matrix);
Console.WriteLine("Ваш массив с заменой значений:");
PrintMatrix(matrix);
