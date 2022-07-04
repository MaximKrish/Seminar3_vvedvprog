// int n;
// n = Convert.ToInt32(Console.ReadLine());
// //n = n % 100/10;//1000; // 1000; // - n % 100000 / 10000;
// if ((n % 100000/10000 == n % 10 && n % 10000/1000==n % 100/10))
// {
//     Console.WriteLine("Число является палиндромом ");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом ");
// }

int n = Convert.ToInt32(Console.ReadLine());
int n1, n2, n4, n5;
n1 = n / 10000;
n2 = (n % 10000) / 1000;
n4 = (n % 100) / 10;
n5 = n % 10;
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("Является палендромом");
}
else
{
    Console.WriteLine("Не является палендромом");
}

