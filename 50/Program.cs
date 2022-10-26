// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого элемента в массиве нет

Console.WriteLine("Введите размерность массива");
int column = Convert.ToInt32(Console.ReadLine());
int line = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Введите позицию элемента");

int userColumn= Convert.ToInt32(Console.ReadLine());
int userLine = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);

if (userLine > line || userColumn > column)
{
    Console.Write("Такого элемента в массиве нет");
}
else Console.Write($" Искомое значение {array[userLine-1, userColumn-1]} ");