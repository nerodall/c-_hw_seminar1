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