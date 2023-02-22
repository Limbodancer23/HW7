// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int minNum = SetNumber("Min");
int maxNum = SetNumber("Max");

var matrix = GetMatrix(numRows, numColumns, minNum, maxNum);
ShowMatrix(matrix);
int RowPosition = SetNumber("position i");
int ColumnPosition = SetNumber("position l");
var GetNumber = FindPosition(RowPosition, ColumnPosition);
System.Console.WriteLine(GetNumber);

int FindPosition(int i, int l)
{
    int result = 0;
    if (i > numRows && l > numColumns)
    {
       Console.WriteLine($"Number with positionts rows = {i}, columns = {l} is not existing in this array!");
       return  i*10+l;
    }
    else return result = matrix[i-1,l-1];
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