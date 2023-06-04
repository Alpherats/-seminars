// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void Main()
{
  ReturnNumbers(ReadInt("insert n: "));
}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

void ReturnNumbers(int n)
{
  if (n < 1)
  {
    return;
  }
  System.Console.Write(n + " ");
  ReturnNumbers(n - 1);
}
Main();