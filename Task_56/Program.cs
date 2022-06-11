// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк - ");
int row = int.Parse(Console.ReadLine());

Random rnd = new Random();
int column = rnd.Next(1, 2) + row;

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

int[] minRes = new int[row];
void MinSum(int[,] array, int[] result)
{

    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min = min + array[i, j];
        }
        result[i] = min;
        min = 0;
    }

}


int[,] arrayResult = GetArray(row, column);
PrintArray(arrayResult);
Console.WriteLine();
MinSum(arrayResult, minRes);



int index = 0;
for (int i = 0; i < minRes.Length; i++)
{
    if (minRes[i] < minRes[index])
    {
        index = i;
    }
}

Console.Write($"{index + 1} cтрока с наименьшей суммой");