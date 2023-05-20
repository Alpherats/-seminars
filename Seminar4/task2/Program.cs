// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// ОФОРМИТЬ ЧЕРЕЗ VOID MAIN
void Main()
{
  int num = ReadInt("Insert number: ");
  System.Console.WriteLine(CountSum(num));
}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int CountSum(int num)
{
  int sum = 0;
  while(num!=0)
  {
    sum += num%10;
    num /=10;
  }
  return sum;
}
Main();