// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int minNum = SetNumber("Min");
int maxNum = SetNumber("Max");
var matrix = GetMatrix(numRows, numColumns, minNum, maxNum);
ShowMatrix(matrix);

double[] GetAverage = AverageNumber(matrix);
System.Console.WriteLine(String.Join(" " ,GetAverage));

double[] AverageNumber(int [,] matrix)
{
    double sum = 0;
    double[] MyArray = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            sum = sum + matrix[l,i];
        }
        MyArray[i] = sum/numRows;
    }
    return MyArray;
}


int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max);
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
void ShowMatrix(int [,] matrix)
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