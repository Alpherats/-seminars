// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void Main()
{
  int size_arr = ReadInt("Insert size of array: ");
  int left_range = ReadInt("Insert left range of values of array: ");
  int right_range = ReadInt("Insert right range of values of array: ");
  PrintArray(FillArray(size_arr, left_range, right_range));

}


int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}


int[] FillArray(int size, int leftRange, int rightRange)
{
  int[] arr = new int[size];
  Random rand = new Random();

  for (int i = 0; i < size; i++)
  {
    arr[i] = rand.Next(leftRange, rightRange);
  }
  return arr;
}


void PrintArray(int[] Array)
{
  Console.WriteLine("[" + string.Join(", ", Array) + "]");
}

Main();