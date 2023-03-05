// Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int numberRows = Promt("Введите количество строк в двумерном массиве: ");
int numberCols = Promt("Введите количество столцов в двумерном массиве: ");
int[,] matrixInt = CreateMatrixDouble(numberRows, numberCols);
Console.WriteLine();
Console.WriteLine("Ваш массив:");
PrintArray(matrixInt);
int numberFindRows = Promt($"Введите от 0 до {numberRows - 1} номер строки искомого элемента массива: ");
int numberFindCols = Promt($"Введите от 0 до {numberCols - 1} номер столбца искомого элемента массива: ");
bool resultFind = ResultFind(matrixInt, numberFindRows, numberFindCols);
Console.WriteLine();
if (resultFind == true) 
Console.WriteLine($"На позиции [{numberFindRows}, {numberFindCols}] находится элемент со значением ->" 
+ matrixInt[numberFindRows, numberFindCols]);
else Console.WriteLine($"На позиции [{numberFindRows}, {numberFindCols}] элемента НЕ существует");

// методы
int[,] CreateMatrixDouble(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next();
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
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

bool ResultFind(int[,] matrix, int numRow, int numCol)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (numRow < matrix.GetLength(0) && numCol < matrix.GetLength(1))
                return true;
        }
    }
    return false;
}
