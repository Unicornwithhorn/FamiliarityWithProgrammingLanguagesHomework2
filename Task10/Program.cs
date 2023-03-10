Console.Clear();
while (1==1)
{
Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 999||a < 100)
  Console.WriteLine("Это число не трёхзначное");
else
  {
    a=(a-(a/100)*100-a%10)/10;
  Console.WriteLine(a);
  break;
  }
}

