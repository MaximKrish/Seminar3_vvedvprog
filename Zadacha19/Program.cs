double x, y, x1, y1, len;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());

len = Math.Sqrt((x - x1) * (x - x1) + (y -y1) * (y - y1));
Console.WriteLine(len);


