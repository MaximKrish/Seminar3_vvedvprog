int n;
n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n < 5)
{

    if (n == 1)
    {
        Console.WriteLine("x = ( 0, +~)");
        Console.WriteLine("y = ( 0, +~)");
    }

    if (n == 2)
    {   
        Console.WriteLine("x = ( -~, 0)");
        Console.WriteLine("y = ( 0, +~)");
    }

    if (n == 3)
    {
        Console.WriteLine("x = ( -~, 0)");
        Console.WriteLine("y = ( -~, 0)");
    }

    if (n == 4)
    {
        Console.WriteLine("x = ( 0, +~)");
        Console.WriteLine("y = ( -~, 0)");
    }
}
else
{
    Console.WriteLine("Такой четверти не существует! Ты врун!");
}



// int x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("x = ( 0, +~)");
//     Console.WriteLine("y = ( 0, +~)");
// }

// if (x < 0 && y > 0)
// {
//     Console.WriteLine("x = ( -~, 0)");
//     Console.WriteLine("y = ( 0, +~)");
// }

// if (x < 0 && y < 0)
// {
//     Console.WriteLine("x = ( -~, 0)");
//     Console.WriteLine("y = ( -~, 0)");
// }

// if (x > 0 && y < 0)
// {
//     Console.WriteLine("x = ( 0, +~)");
//     Console.WriteLine("y = ( -~, 0)");
// }