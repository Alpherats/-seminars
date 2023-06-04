// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
  System.Console.Write(SolveAkkerman(ReadInt("Insert m: "), ReadInt("Insert n: ")));
}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}


int SolveAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return SolveAkkerman(m - 1, 1);
  return SolveAkkerman(m - 1, SolveAkkerman(m, n - 1));
}

Main();