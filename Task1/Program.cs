#nullable disable
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int minNum = SetNumber("Min");
int maxNum = SetNumber("Max");
var matrix = GetMatrix(numRows, numColumns, minNum, maxNum);
ShowMatrix(matrix);
double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = Math.Round(new Random(). Next(min, max)+ new Random().NextDouble(), 2);
        }
    }
    return matrix;
}

int SetNumber(string numberName)

{
    Console.Write($"Enter number of {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void ShowMatrix(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();        
    }
}