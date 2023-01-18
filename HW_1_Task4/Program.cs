// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i+=2)
{
    System.Console.WriteLine(i);
}


// for (int i = number; i > 1; i --)
/* while (number != 1)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number = number -1;
}
*/