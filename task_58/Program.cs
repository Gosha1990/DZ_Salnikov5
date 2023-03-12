// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.WriteLine("Введите размер матриц: ");
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрици и строк 2-й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Первая матрица");
int[,] firstMatrix = new int[m, n];
GetMatrix(firstMatrix);
PrintMatrix(firstMatrix);


System.Console.WriteLine("Вторая матрица");
int[,] sekondMatrix = new int[n, k];
GetMatrix(sekondMatrix);
PrintMatrix(sekondMatrix);
int[,] resultMayrix = new int[m,k];
MatrixMultiplication(firstMatrix,sekondMatrix,resultMayrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintMatrix(resultMayrix);

/// <summary>
/// Метод находит произведение двух матриц
/// </summary>
/// <param name="firstMatrix">Первая матрица</param>
/// <param name="sekondMatrix">Вторая матрица</param>
/// <param name="resultMayrix">Результат умножения двух матриц</param>
void MatrixMultiplication(int[,] firstMatrix, int[,] sekondMatrix, int[,] resultMayrix)
{
    for (int i = 0; i < resultMayrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMayrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int m = 0; m < firstMatrix.GetLength(1); m++)
            {
                sum += firstMatrix[i, m] * sekondMatrix[m,j];
            }
            resultMayrix[i,j] = sum;
        }

    }

}

/// <summary>
/// Метод создает матрицу
/// </summary>
/// <param name="matrix"></param>
void GetMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }

    // return matrix;
}
/// <summary>
/// Метод печатает матрицу
/// </summary>
/// <param name="inputMatrix"></param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}