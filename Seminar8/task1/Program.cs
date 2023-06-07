// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



void Main()
{
  int[,] matrix = GenerateMatrix(ReadInt("Insert m: "), ReadInt("Insert n: "), 1, 10);
  PrintMatrix(matrix);
  SortMatrix(matrix);
  System.Console.WriteLine();
  PrintMatrix(matrix);
}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateMatrix(int m, int n, int leftBorder, int rightBorder)
{
  Random rand = new Random();
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

      matrix[i, j] = rand.Next(leftBorder, rightBorder + 1);
    }
  }
  return matrix;
}


void SortMatrix(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns - 1; j++)
    {
      for (int k = 0; k < columns - j - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {

          int temp = matrix[i, k];
          matrix[i, k] = matrix[i, k + 1];
          matrix[i, k + 1] = temp;
        }
      }
    }
  }
}

void PrintMatrix(int[,] matr)
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