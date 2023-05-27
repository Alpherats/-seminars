//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void Main()
{
  int[] inputArray = Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);
  System.Console.WriteLine(CountNegative(inputArray));
}

int CountNegative(int [] arr){
  int counter = 0;
  for(int i =0; i<arr.Length; i++){
    if (arr[i]  < 0)
    {
      counter++;
    }
  }
  return counter;
}

Main();