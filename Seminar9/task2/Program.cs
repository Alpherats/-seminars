// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
  int m = ReadInt("Insert m: ");
  int n = ReadInt("Insert n: ");
  if (m > n)
  {
    System.Console.WriteLine(FindSum(n, m));
  }
  else
  {
    System.Console.WriteLine(FindSum(m, n));
  }

}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}


int FindSum(int m, int n)
{
  if (m > n)
  {
    return 0;
  }
  return m + FindSum(m + 1, n);
}
Main();
