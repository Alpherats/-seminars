//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
Console.WriteLine("Insert number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
  Console.WriteLine($"Max - {number1} , Min - {number2}");
}
else
{
  Console.WriteLine($"Max - {number2} , Min - {number1}");
}
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7

Console.WriteLine("Insert number 1: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert number 2: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert number 3: ");
int third = Convert.ToInt32(Console.ReadLine());

int max_num = first;
if (second>max_num && second>third)
{
  max_num = second;
  Console.WriteLine($"Max - {max_num}");
}
else if (third>max_num && third>second)
{
  max_num=third;
  Console.WriteLine($"Max - {max_num}");
}
else
{
  Console.WriteLine($"Max - {max_num}");
}

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да

Console.WriteLine("Insert number: ");
int even = Convert.ToInt32(Console.ReadLine());

if (even%2 ==0)
{
  Console.WriteLine($"{even} is even");
}
else
{
  Console.WriteLine($"{even} is odd");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4

Console.WriteLine("Insert number: ");
int end = Convert.ToInt32(Console.ReadLine());
int counter = 1;

if(end<0)
{
  Console.WriteLine("Insert positive number!");
}
else
{
  while (counter < end)
{
  if(counter%2==0)
  {
    Console.WriteLine(counter);
  }
  counter ++;
}
}


