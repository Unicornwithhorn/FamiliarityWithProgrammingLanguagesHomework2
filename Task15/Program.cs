Console.Clear();
Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a>7||a<1)
  Console.WriteLine("На номер дня недели не похоже");
else if (a>5)
  Console.WriteLine("выходной");
else
  Console.WriteLine("будень");