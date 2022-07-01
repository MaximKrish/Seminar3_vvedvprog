int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
Console.WriteLine("I");
if (x < 0 && y > 0)
Console.WriteLine("II");
if (x < 0 && y < 0)
Console.WriteLine("III");
if (x > 0 && y < 0)
Console.WriteLine("IV");