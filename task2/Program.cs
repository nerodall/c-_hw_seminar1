//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
 
 System.Console.WriteLine("Введите первое число");
 int valueOne = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите второе число");
 int valueTwo = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите третье число");
 int valueThree = Convert.ToInt32(Console.ReadLine());

int max = valueOne;

if (max < valueTwo)
{
    max = valueTwo;
}
if (max < valueThree)
{
    max = valueThree;
}

System.Console.WriteLine($"Самое больше число из введенных является число {max}");