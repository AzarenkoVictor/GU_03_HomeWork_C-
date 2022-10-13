// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Ввелите число"); int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввелите степень числа"); int b = Convert.ToInt32(Console.ReadLine());
double result = Convert.ToDouble(a);
int stepen = b;
if (b > 0)
{
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
}

if (b < 0)
{
    b = b * -1;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    result = 1 / result;
}

if (b == 0)
{ result = 1; }

Console.WriteLine($"{a} в стеипени {stepen} равно {result} ");
