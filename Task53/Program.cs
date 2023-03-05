// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int numberRows = Promt("Введите количество строк в двумерном массиве: ");
int numberCols = Promt("Введите количество столцов в двумерном массиве: ");
int[,] matrixInt = CreateMatrixInt(numberRows, numberCols);
Console.WriteLine();
Console.WriteLine("Ваш массив:");
PrintMatrix(matrixInt);
double[] getArrayAverage = CreateMatrixAverageCols(matrixInt);
Console.WriteLine();
PrintArray (getArrayAverage);

// методы
int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],10} " + "|");
        }
        Console.WriteLine();
    }
}

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[] CreateMatrixAverageCols(int[,] matrix)
{
    int number = matrix.GetLength(1);
    double[] matrixAverage = new double[number];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        matrixAverage[j] += matrix[i, j];
         
        }
        matrixAverage[j] = Math.Round(matrixAverage[j] / matrix.GetLength(0), 1, MidpointRounding.ToZero);
    }
    
    return matrixAverage;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце Ваше массива:");
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j], 10} | ");
    }
}