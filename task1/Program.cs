﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

 System.Console.WriteLine("Введите первое число");
 int valueOne = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите второе число");
 int valueTwo = Convert.ToInt32(Console.ReadLine());


if (valueOne > valueTwo)
{
    System.Console.WriteLine($"Число {valueOne} больше числа {valueTwo}");
}
else
{
    System.Console.WriteLine($"Число {valueTwo} больше числа {valueOne}");
}