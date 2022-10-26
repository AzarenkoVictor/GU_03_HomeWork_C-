// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого элемента в массиве нет

Console.WriteLine("Введите размерность массива");
int line = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[line, column];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.WriteLine("Введите позицию элемента");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

FillArray(array);


if (x > line || y > column)
{
    Console.Write("Такого элемента в массиве нет");
}
else Console.Write($" Искомое значение {array[x, y]} ");