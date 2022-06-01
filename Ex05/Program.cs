// Домашнее задание 1. Написать программу, которая обменивает элементы 
// первой строки и последней строки

// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             matrix[i, j] = rnd.Next(minValue, maxValue+1);
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine("Ваш массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int[,] ChangeFirstAndLastRows(int[,] matrix)
// {
//     int[] TempArray = new int[matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         TempArray[i] = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = TempArray[i];
//     }
//     return matrix;
// }

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите минимальное значение в массиве: ");
// int minValue = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите максимальное значение в массиве: ");
// int maxValue = int.Parse(Console.ReadLine() ?? "0");

// int[,] matrix = CreateMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(matrix);
// Comsole.WriteLine();
// ChangeFirstAndLastRows(matrix);
// PrintMatrix(matrix);



// Домашнее задание 2. Написать программу, упорядочивания по убыванию элементы 
// каждой строки двумерной массива

// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             matrix[i, j] = rnd.Next(minValue, maxValue + 1);
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine("Ваш массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int[,] SortMatrix(int[,] matrix)
// {
//     int tempNum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int maxPosition = j;
//             for (int k = j + 1; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i, k] > matrix[i, maxPosition])      // if (matrix[i,k] > matrix[i,j])
//                     maxPosition = k;                            //    (matrix[i,j], matrix[i,k]) = (matrix[i,k], matrix[i,j]);
//             }
//             tempNum = matrix[i, j];
//             matrix[i, j] = matrix[i, maxPosition];
//             matrix[i, maxPosition] = tempNum;

//         }
//     }
//     return matrix;
// }

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите минимальное значение в массиве: ");
// int minValue = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите максимальное значение в массиве: ");
// int maxValue = int.Parse(Console.ReadLine() ?? "0");

// int[,] matrix = CreateMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(matrix);
// Console.WriteLine();
// SortMatrix(matrix);
// PrintMatrix(matrix);


// Домашнее задание 3. Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             matrix[i, j] = rnd.Next(minValue, maxValue + 1);
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine("Ваш массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int[,] ChangeRowsVsColumns(int[,] matrix)
// {
//     int[,] matr = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matr[i,j] = matrix[j,i];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i,j] = matr[i,j];
//     return matrix;
// }
// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine() ?? "0");
// if (rows == columns)
// {
//     Console.Write("Введите минимальное значение в массиве: ");
//     int minValue = int.Parse(Console.ReadLine() ?? "0");
//     Console.Write("Введите максимальное значение в массиве: ");
//     int maxValue = int.Parse(Console.ReadLine() ?? "0");

//     int[,] matrix = CreateMatrix(rows, columns, minValue, maxValue);
//     PrintMatrix(matrix);
//     Console.WriteLine();
//     ChangeRowsVsColumns(matrix);
//     PrintMatrix(matrix);
// }
// else
//     Console.WriteLine("Количество строк и столбцов должно быть одинаковым.");



// Домашнее задание 4. В прямоугольной матрице найти строку с наименьшей
// суммой элементов.

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    var rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}

(int, int)? FindMaxRowsSummary(int[,] matrix)
{
    int[] rowssum = new int[matrix.GetLength(0)];
    int MaxRowsSum = 0;
    int MaxIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {    
        for (int j = 0; j < matrix.GetLength(1); j++)
            rowssum[i] += matrix[i,j];
        if (rowssum[i] > MaxRowsSum)
        {
            MaxRowsSum = rowssum[i];
            MaxIndex = i;
        }
    }
    return (MaxIndex, MaxRowsSum);
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение в массиве: ");
int minValue = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение в массиве: ");
int maxValue = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = CreateMatrix(rows, columns, minValue, maxValue);
PrintMatrix(matrix);
Console.WriteLine();
(int, int)? MaxRowsSummary = FindMaxRowsSummary (matrix);
Console.WriteLine ($"Строка с максимальной суммой элементов = {MaxRowsSummary.Value.Item2} - Номер {MaxRowsSummary.Value.Item1+1}");

