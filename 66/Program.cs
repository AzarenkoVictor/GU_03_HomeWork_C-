// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное значение массива N");
int startPoint = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение массива M");
int endPoint = Convert.ToInt32(Console.ReadLine());

SumNaturalNambers(startPoint, endPoint, 0);

void SumNaturalNambers(int startPoint, int endPoint, int sum)
{
    if (startPoint > endPoint)
    {
        Console.WriteLine("сумма натуральных элементов в промежутке равна:" + sum);
        return;
    }
    else
    {
        sum += startPoint;
    }
    SumNaturalNambers(startPoint + 1, endPoint, sum);
}