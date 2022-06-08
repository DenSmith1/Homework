//  Домашнее задание 1. Найти произведение двух матриц

// int[,] FillMatrix(int[,] matrix, int minValue, int maxValue)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] MultiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < MultiplyMatrix.GetLength(0); i++)
//         for (int j = 0; j < MultiplyMatrix.GetLength(1); j++)
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//                 MultiplyMatrix[i, j] = MultiplyMatrix[i, j] + matrix1[i, k] * matrix2[k, j];
//     return MultiplyMatrix;
// }

// Console.Clear();
// Console.Write("Введите количество строк в 1 матрицe: ");
// int rows1 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов в 1 матрице: ");
// int columns1 = int.Parse(Console.ReadLine() ?? "0");
// Console.Writeline("Количество столбцов первой матрице должно быть равно количеству строк во второй.")
// Console.Write("Введите количество столбцов во 2 матрице: ");
// int columns2 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите минимальное значение в матрицах: ");
// int start = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите максимальное значение в матрицах: ");
// int finish = int.Parse(Console.ReadLine() ?? "0");
// int[,] matrix1 = new int[rows1, columns1];
// int[,] matrix2 = new int[columns1, columns2];

// FillMatrix(matrix1, start, finish);
// FillMatrix(matrix2, start, finish);

// Console.WriteLine("Матрица №1: ");
// PrintMatrix(matrix1);
// Console.WriteLine();
// Console.WriteLine("Матрица №2: ");
// PrintMatrix(matrix2);
// Console.WriteLine();

// int[,] NewMatrix = MultiplyMatrix(matrix1, matrix2);
// Console.WriteLine("Произведение двух матриц:");
// PrintMatrix(NewMatrix);


// Домашнее задание 2. В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] matrix1 = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             matrix1[i, j] = new Random().Next(minValue, maxValue + 1);
//     return matrix1;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// (int, int)? FindMinElement(int[,] matrix, int maxValue)
// {
//     int MinElement = maxValue + 1;
//     int MinIndexRow = 0;
//     int MinIndexColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             if (matrix[i, j] < MinElement)
//             {
//                 MinElement = matrix[i, j];
//                 MinIndexRow = i;
//                 MinIndexColumn = j;
//             }
//     }
//     return (MinIndexRow, MinIndexColumn);
// }

// int[,] DeleteRowAndColumn(int[,] matrix, int MinIndexRow, int MinIndexColumn)
// {
//     for (int i = MinIndexRow; i < matrix.GetLength(0) - 1; i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = matrix[i + 1, j];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = MinIndexColumn; j < matrix.GetLength(1)-1; j++)
//             matrix[i,j] = matrix[i, j + 1];

//     int[,] NewMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     for (int i = 0; i < NewMatrix.GetLength(0); i++)
//         for (int j = 0; j < NewMatrix.GetLength(1); j++)
//             NewMatrix[i, j] = matrix[i, j];
//     return NewMatrix;
// }

// Console.Clear();
// Console.Write("Введите количество строк в матрицe: ");
// int rows = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите количество столбцов в матрицe: ");
// int columns = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите минимальное значение в матрицe: ");
// int start = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите максимальное значение в матрицe: ");
// int finish = int.Parse(Console.ReadLine() ?? "0");

// int[,] matrix1 = CreateMatrix(rows, columns, start, finish);
// Console.WriteLine("Ваша матрица: ");
// PrintMatrix(matrix1);

// (int, int)? position = FindMinElement(matrix1, finish);
// Console.WriteLine   ("Позиция минимального элемента: строка "+(position.Value.Item1+1) 
//                     + " столбец " + (position.Value.Item2+1));              

// int[,] newmatrix = DeleteRowAndColumn(matrix1, position.Value.Item1, position.Value.Item2);
// Console.WriteLine("Ваша матрица с удаленной строкой и столбцом: ");
// PrintMatrix(newmatrix);


// Домашнее задание 3. Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

// bool CheckingMatrixForRepeat(int[,,] matrix, int CheckingElement)
// {
//     bool Repeat = false;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             for (int k = 0; k < matrix.GetLength(2); k++)
//                 if (CheckingElement == matrix[i, j, k])
//                 {
//                     Repeat = true;
//                     break;
//                 }
//     return Repeat;
// }



// int[,,] CreateMatrix(int Index1, int Index2, int Index3, int minValue, int maxValue)
// {
//     int[,,] matrix = new int[Index1, Index2, Index3];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 if (i == 0 && j == 0 && k == 0)
//                     matrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
//                 else
//                 {
//                     bool RepeatCondition = true;
//                     int CheckingElement = 0;
//                     while (RepeatCondition)
//                     {
//                         CheckingElement = new Random().Next(minValue, maxValue + 1);
//                         RepeatCondition = CheckingMatrixForRepeat(matrix, CheckingElement);
//                     }
//                     matrix[i, j, k] = CheckingElement;
//                 }
//             }
//     return matrix;
// }


// void PrintMatrix(int[,,] matrix)
// {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 count++;
//                 Console.WriteLine(count + ".Element: " + matrix[i, j, k]
//                                     + " Index 1:" + i + " Index 2: " + j + " Index 3: " + k);
//             }
// }


// Console.Clear();
// Console.WriteLine("Программа формирования трехмерного массива из неповторяющихся двузначных чисел.");
// Console.WriteLine();
// Console.Write("Введите первый индекс матрицы: ");
// int FirstIndex = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите второй индекс матрицы: ");
// int SecondIndex = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите третий индекс матрицы: ");
// int ThirdIndex = int.Parse(Console.ReadLine() ?? "0");

// int CountElements = FirstIndex * SecondIndex * ThirdIndex;

// Console.Write("Введите минимальное значение в матрице(двузначное число): ");
// int minValue = int.Parse(Console.ReadLine() ?? "0");
// while (minValue < 10 || minValue > (99 - CountElements))
// {
//     Console.WriteLine($"Введенное значение не позволяет создать матрицу");
//     Console.Write("Попробуйте еще раз (введите двузначное число) не менее 10: ");
//     minValue = int.Parse(Console.ReadLine() ?? "0");
// }

// Console.Write("Введите максимальное значение в матрице(двузначное число): ");
// int maxValue = int.Parse(Console.ReadLine() ?? "0");
// while (maxValue > 99 || maxValue < (10 + CountElements) || (maxValue - minValue) < CountElements)
// {
//     Console.WriteLine($"Введенное значение не позволяет создать матрицу");
//     Console.Write($"Введите значение не менее {minValue + CountElements}: ");
//     maxValue = int.Parse(Console.ReadLine() ?? "0");
// }

// int[,,] ThreeDemMatrix = CreateMatrix(FirstIndex, SecondIndex, ThirdIndex, minValue, maxValue);
// Console.WriteLine();
// Console.WriteLine("Ваша матрица: ");
// PrintMatrix(ThreeDemMatrix);


// Домашнее задание 4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

double Factorial (double rows)
{
    int Factorial = 1;
    for (int i = 1; i <= rows; i++)
    {
        Factorial *= i;
    }
    return Factorial;
}

Console.WriteLine("Введите  количество строк треугольника Паскаля:");
double rows = double.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < rows; i++)
{
    for (int count = 0; count <= (rows - i); count++) 
           Console.Write(" "); 
    for (int count = 0; count <= i; count++)
    {
        Console.Write(" "); 
        Console.Write(Factorial(i) / (Factorial(count) * Factorial(i - count))); 
    }
    Console.WriteLine();
}

    