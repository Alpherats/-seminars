// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

double CalcRate(int first, int second)
{
  return Math.Pow(first, second);
}

int a = ReadInt("Insert a: ");
int b = ReadInt("Insert b: ");
System.Console.WriteLine(CalcRate(a,b));
