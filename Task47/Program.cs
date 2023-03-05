// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int numberRows = Promt("Введите количество строк в двумерном массиве:");
int numberCols = Promt("Введите количество столцов в двумерном массиве:");
double[,] matrixDouble = CreateMatrixDouble(numberRows, numberCols);
Console.WriteLine("Ваш массив:");
PrintArray(matrixDouble);

// методы
double[,] CreateMatrixDouble(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble(),1);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
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