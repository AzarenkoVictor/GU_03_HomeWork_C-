// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x первой точки"); int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки"); int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки"); int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точки"); int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки"); int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй точки"); int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между точками = " + Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2));
