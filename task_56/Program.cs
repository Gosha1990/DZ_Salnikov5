// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка




/// <summary>
/// Создает двумерную матрицу
/// </summary>
/// <param name="rows">кол-во строк</param>
/// <param name="cols">кол-во столбцов</param>
/// <param name="min">от мин значения</param>
/// <param name="max">до мах значения</param>
/// <returns>заполненый масив</returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// <summary>
/// печатает матрицу переданную на вход
/// </summary>
/// <param name="inputMatrix"> двумерный масив или таблица</param>
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
System.Console.WriteLine();
int[,] numbers = GetMatrix(5, 6, 0, 10);
PrintMatrix(numbers);
int minsum = Int32.MaxValue;
int rows = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        rows++;
    }

}
Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (rows) + ", с суммой елементов равной: " + (minsum));
