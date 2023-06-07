// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void Main()
{
  int[,] matrix = GenerateSpiralMatrix();
  PrintMatrix(matrix);
}

int[,] GenerateSpiralMatrix()
{
  int[,] matrix = new int[4, 4];
  int value = 1;
  int startX = 0;
  int startY = 0;
  int endX = 3;
  int endY = 3;

  while (startX <= endX && startY <= endY)
  {
    for (int i = startX; i <= endX; i++)
    {
      matrix[startY, i] = value++;
    }
    startY++;

    for (int i = startY; i <= endY; i++)
    {
      matrix[i, endX] = value++;
    }
    endX--;

    if (startY <= endY)
    {
      for (int i = endX; i >= startX; i--)
      {
        matrix[endY, i] = value++;
      }
      endY--;
    }

    if (startX <= endX)
    {
      for (int i = endY; i >= startY; i--)
      {
        matrix[i, startX] = value++;
      }
      startX++;
    }
  }
  return matrix;
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
