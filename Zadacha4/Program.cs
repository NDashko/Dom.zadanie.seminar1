//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c ");
int c = int.Parse(Console.ReadLine());
if (a>b && a>c) 
{
    Console.WriteLine("max="+a);
}
if (b>a && b>c) 
{
    Console.WriteLine("max="+b);
}
if (c>a && c>b) 
{
    Console.WriteLine("max="+c);
}