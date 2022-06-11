// Задача 62: Заполните спирально массив 4 на 4.

int row = 4;
int column = 4;

int[,] GetArraySpiral(int[,] array, int a, int b)
{
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= a * b)
    {
        array[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < b - 1) j++;
        else if (i < j && i + j >= a - 1) i++;
        else if (i >= j && i + j > b - 1) j--;
        else i--;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] spiralArray = new int[row, column];
GetArraySpiral(spiralArray, row, column);
Console.WriteLine("Спиральная матрица:");
PrintArray(spiralArray);