// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Write("Введите значение x для массива - ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите значение y для массива - ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите значение z для массива - ");
int z = int.Parse(Console.ReadLine());


int[,,] GetArray(int[,,] array, int a, int b, int c)
{
    Random rnd = new Random();
    int num = rnd.Next(10, 100);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[i, j, n] = num;
                if (num >= array[0, 0, 0] && num <= 99) num++;
                else num--;
                if (num > 99) num = array[0, 0, 0] - 1;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write(array[i, j, n] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

int[,,] newarray = new int[x, y, z];
Console.WriteLine();
GetArray(newarray, x, y, z);
PrintArray(newarray);