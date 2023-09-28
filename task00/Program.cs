// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Input the first number");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the first number");
int max = numberA;
int min = numberB;
if (numberA > numberB) max = numberA;
if (numberB > numberA) max = numberB;
if (numberB < numberA) min = numberB;
if (numberA < numberB) min = numberA;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

