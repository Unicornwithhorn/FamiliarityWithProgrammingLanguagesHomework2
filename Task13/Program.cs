Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
if (b>99||b<-99)
{
  int i = 1;
  while (b>10)
  {
    b = b/10;
    i=i*10;
  }
  Console.WriteLine((a*100/i)%10);
}
else
  Console.WriteLine("Третьей цифры нет");
