using System;

class Program
{
    static void Main()
    {
        int[,] array1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] array2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        int[,] sumResult = AddMatrices(array1, array2, out double averageSum);
        Console.WriteLine("Сумма массивов:");
        PrintMatrix(sumResult);
        Console.WriteLine($"Среднее значение всех элементов: {averageSum}");

        int[,] subtractResult = SubtractMatrices(array1, array2, out double averageSubtract);
        Console.WriteLine("Разность массивов:");
        PrintMatrix(subtractResult);
        Console.WriteLine($"Среднее значение всех элементов: {averageSubtract}");
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2, out double average)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        int sum = 0;
        int totalElements = rows * cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
                sum += result[i, j];
            }
        }

        average = (double)sum / totalElements;
        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2, out double average)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        int sum = 0;
        int totalElements = rows * cols;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
                sum += result[i, j];
            }
        }

        average = (double)sum / totalElements;
        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}