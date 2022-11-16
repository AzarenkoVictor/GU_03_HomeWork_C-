// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите начальное значение массива N");
int startPoint = Convert.ToInt32(Console.ReadLine());
int endPoint = 1;

Console.WriteLine();
PrintNaturalNambers(startPoint, endPoint);

int PrintNaturalNambers(int startPoint, int endPoint)
{
    if (startPoint == endPoint)
    {
        Console.Write(endPoint);
        return startPoint;
    }
    else
    {
        Console.Write($"{startPoint}, ");
    }
    return PrintNaturalNambers(startPoint - 1, endPoint);
}