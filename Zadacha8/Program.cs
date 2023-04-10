//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = 0;
while (b<(a-1))
{
    b=b+2;
    Console.WriteLine(b);
}
