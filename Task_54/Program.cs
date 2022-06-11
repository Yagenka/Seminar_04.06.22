// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк - ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов - ");
int column = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
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


void SortArrayMimRow (int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            for (int n = 1; n < array.GetLength(1); n++)
            {
                if (array[i, n] > array[i, n - 1])
                {
                    temp = array[i, n - 1];
                    array[i, n - 1] = array[i, n];
                    array[i, n] = temp;
                }
            }
             
        }
         
    }
   
}

int[,] arrayResult = GetArray(row, column);
PrintArray(arrayResult);
Console.WriteLine();
SortArrayMimRow(arrayResult);
PrintArray(arrayResult);