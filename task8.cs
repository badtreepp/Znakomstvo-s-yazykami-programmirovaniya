// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;

while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + " ");
        not = false;
    }
      i++;  
}
if (not)
{
    Console.WriteLine("Четных чисел нет");
}
