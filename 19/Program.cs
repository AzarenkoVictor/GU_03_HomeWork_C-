﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a / 10000 == a % 10) || (a / 1000 == a % 100))
{
    Console.WriteLine("Введенно число " + a + " является полиндромом");
}
else
{
    Console.WriteLine("Введенно число " + a + " не является полиндромом");
}