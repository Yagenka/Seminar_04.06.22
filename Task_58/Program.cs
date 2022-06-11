// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Write("Введите количество строк для матриц - ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов для матриц - ");
int column = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(5);
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

int[,] arrayA = GetArray(row, column);
Console.WriteLine("Матрица А");
PrintArray(arrayA);
Console.WriteLine();
int[,] arrayB = GetArray(row, column);
Console.WriteLine("Матрица B");
PrintArray(arrayB);

int[,] multArray = new int[arrayA.GetLength(1), arrayB.GetLength(0)];

void GetMultiArray(int[,] first, int[,] second, int[,]result)
{
    for (int i = 0; i < first.GetLength(1); i++)
    {
        for (int j = 0; j < second.GetLength(0); j++)
        {
            for (int n = 0; n < first.GetLength(1); n++)
            {
                result[i, j] += first[i, n] * second[n, j];
            }
        }
    }
    
}

Console.WriteLine();
GetMultiArray(arrayA, arrayB, multArray);
Console.WriteLine("Произведение матрицы А и В");
PrintArray(multArray);