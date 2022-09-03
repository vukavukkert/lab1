using System;

int x, y;
Console.WriteLine("Введите число X");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y");
y = Convert.ToInt32(Console.ReadLine());

//int z = x;
//x = y;
//y = z;
y = x + y;
x = y - x;
y = y - x;


Console.WriteLine($"x ={x}, y = {y}");
Console.ReadKey();