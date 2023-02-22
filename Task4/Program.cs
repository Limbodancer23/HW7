// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int numRows = 4;
int numColumns = 4;
int k = 1;
int iAngle = 0;
int jAngle = 0;
int[,] matrix = new int[numRows, numColumns];
ShowMatrix(matrix);
System.Console.WriteLine();
FillArray(0, 0);
ShowMatrix(matrix);


void FillArray(int i, int j)
{

    if (matrix[i, j] == 0 && i == iAngle && j < numColumns - jAngle - 1)
    {
        matrix[i, j] = k;
        k++;
        FillArray(i, j + 1);
    }
    else if (matrix[i, j] == 0 && i == iAngle && j == numColumns - jAngle - 1)
    {
        matrix[i, j] = k;
        k++;
        FillArray(i + 1, j);
    }
    else if (matrix[i, j] == 0 && i < numRows - 1 - iAngle && j == numColumns - jAngle - 1)
    {
        matrix[i, j] = k;
        k++;
        FillArray(i + 1, j);
    }
    else if (matrix[i, j] == 0 && i == numRows - iAngle - 1 && j - jAngle > 0)
    {
        matrix[i, j] = k;
        k++;
        FillArray(i, j - 1);
    }
    else if (matrix[i, j] == 0 && j - jAngle == 0 && i - iAngle > 1)
    {
        matrix[i, j] = k;
        k++;
        FillArray(i - 1, j);
    }
    if ((i == iAngle + 1) && (j == jAngle) && (jAngle != j - numColumns - jAngle - 1))
    {
        iAngle += 1;
        jAngle += 1;
        FillArray(i, j);
    }
}


void ShowMatrix(int[,] matrix)
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
