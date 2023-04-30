
string? str = Console.ReadLine();

int num = Convert.ToInt32(Convert.ToString(str![0]));

if(str.Length ==5)
{
  if(str[0]==str[4] && str[1]==str[3])
  {
    System.Console.WriteLine("Palindrome");  
  }
  System.Console.WriteLine(str.Length);  
}
else
{
System.Console.WriteLine("Insert number with 5 figures!");
}

