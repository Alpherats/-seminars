// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
  int[] arr = GenerateArr(6, 100, 999);
  Print_Arr(arr);
  EvenNumInArr(arr);

}

int[] GenerateArr(int size, int leftBorder, int rightBorder)
{
  int[] temp_arr = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    temp_arr[i] = rand.Next(leftBorder, rightBorder + 1);
  }
  return temp_arr;
}

void Print_Arr(int[] arr)
{
  System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int EvenNumInArr(int[] arr)
{
  int even_numbers = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      even_numbers += 1;
    }
  }
  System.Console.WriteLine(even_numbers);
  return even_numbers;
}
Main();