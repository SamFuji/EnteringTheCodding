// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();

Console.Write("Enter the number:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine(N);

if (N<2)
{
    Console.Write("false, the numbber must to be large");

}
else

    while (i <= N)
{
    Console.Write(i);
    i+=2;
}

