//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine ("First number:");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Second number:");

int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Выходит, большее число:");

if (numberA > numberB)
{
    Console.WriteLine (numberA);
}

else
{
    Console.WriteLine (numberB);
}