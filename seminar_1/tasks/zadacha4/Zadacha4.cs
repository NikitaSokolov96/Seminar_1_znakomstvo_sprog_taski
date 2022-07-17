// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("The number 1 is :");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The number 2 is :");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The number 3 is :");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (max < secondNumber)
            {
               
           max = secondNumber;
            }
            else
            {
       
            }  
            if (max < thirdNumber)
            {
                max = thirdNumber;
            }
            else
            { 
       
            }
 Console.WriteLine("Максимальное из этих чисел = " + (max));