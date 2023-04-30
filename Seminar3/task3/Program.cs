int  ReadInt(string text)
{
  System.Console.Write(text);
  return Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
}

void TableOfCubics(int number)
{
  for (int i=1; i<=number;i++)
  {
    System.Console.WriteLine(Math.Pow(i,3));  
  }
}


int n  = ReadInt("Введите N ");
TableOfCubics(n);