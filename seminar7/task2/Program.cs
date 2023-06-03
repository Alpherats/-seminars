//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void Main()
{
  int row = ReadInt("Insert row: ");
  int col = ReadInt("Insert col: ");
  int[,] matrix = GenerateMatrix(4, 5, 1, 10);
  PrintMatrix(matrix);
  FindNumber(matrix, row, col);
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

bool IsInMatrix(int row, int col, int[,] matrix)
{
  if (row * col <= matrix.Length)
  {
    return true;
  }
  else
  {
    return false;
  }
}

int FindNumber(int[,] matrix, int row, int col)
{
  int num = 0;
  if (IsInMatrix(row, col, matrix))
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (i == row && j == col)
        {
          num = matrix[i,j];
          System.Console.WriteLine(num);
        }
      }
    }
  else
  {
    System.Console.WriteLine("NO!!!!!!!");
  }
  return num;
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

