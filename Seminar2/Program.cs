// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Random rand = new Random();
int number = rand.Next(100, 1000);
int sec_position = (number / 10) % 10;
System.Console.WriteLine($"Цифра - {number} и вторая цифра - {sec_position}");
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Insert number");
int num1 = Convert.ToInt32(System.Console.ReadLine());

if (num1 > 99)
{
  int find_second = num1;
  if (num1 > 999)
  {
    find_second = num1 / 10;
  }
  find_second %= 10;
  System.Console.WriteLine($"number - {num1} third pos - {find_second}");
}
else
{
  System.Console.WriteLine("Третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Insert number");
int num = Convert.ToInt32(System.Console.ReadLine());
if (num > 0 && num < 7)
{
  if (num == 6 || num == 7)
  {
    System.Console.WriteLine("It's weekned!");
  }
  else
  {
    System.Console.WriteLine("Time to work(");
  }
}
else
{
  System.Console.WriteLine("Out of range");
}