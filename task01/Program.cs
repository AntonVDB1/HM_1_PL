
Console.WriteLine("Input three numbers");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > numberB ) max = numberA;
if (numberB > numberA ) max = numberB;
if (numberC > numberA ) max = numberC;
Console.Write("max = ");
Console.WriteLine(max);
