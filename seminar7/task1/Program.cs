// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Main()
{
    double[,] matrix = GenerateMatrix(ReadInt("Insert m: "), ReadInt("Insert n: "), 1, 10);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



double[,] GenerateMatrix(int m, int n, int leftBorder, int rightBorder)
{
    Random rand = new Random();
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          
            matrix[i, j] = Math.Round((rand.Next(leftBorder, rightBorder + 1) + rand.NextDouble()),2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      System.Console.Write(matr[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}

Main();