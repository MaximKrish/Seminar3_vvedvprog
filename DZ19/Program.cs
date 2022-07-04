int n;
n = Convert.ToInt32(Console.ReadLine());
//n = n % 100/10;//1000; // 1000; // - n % 100000 / 10000;
if ((n % 100000/10000 == n % 10 && n % 10000/1000==n % 100/10))
{
    Console.WriteLine("Число является палиндромом ");
}
else
{
    Console.WriteLine("Число не является палиндромом ");
}
