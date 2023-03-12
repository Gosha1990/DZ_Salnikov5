// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите размер матриц: ");
Console.WriteLine("Глубина матрицы depth: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Строк в  матрице rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столбцов матрицы cols: ");
int cols = Convert.ToInt32(Console.ReadLine());




int[,,] resultMatrix = GetMatrix( rows,  cols, depth);
PrintMatrix(resultMatrix);
System.Console.WriteLine();

/// <summary>
/// Метод создает трех мерную матрицу
/// </summary>
/// <param name="rows"> Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="depth">Глубина матрицы</param>
/// <returns></returns>
int[,,] GetMatrix(int rows, int cols, int depth)
{
int[,,] matrix = new int[depth,rows,cols];
    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < cols; k++)
            {
                matrix[i, j, k] = new Random().Next(10);
            }

        }
    }

    return matrix;
}
/// <summary>
/// Метод печатает матрицу
/// </summary>
/// <param name="inputMatrix"></param>
void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
        System.Console.WriteLine();
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {

                Console.Write($"{inputMatrix[i, j, k]} ({i},{j},{k}) \t");
           
            }
        }
        Console.WriteLine();
    }
}