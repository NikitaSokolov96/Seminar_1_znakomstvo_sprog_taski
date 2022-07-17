// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет

Console.WriteLine ("The number is :");
int evenNumber = Convert.ToInt32(Console.ReadLine());

if (evenNumber % 2==1)
            {
                Console.WriteLine("число нечетное");
           
            }
            else
            {
                Console.WriteLine("Число четное");
            }  
            if (evenNumber % 2==1)
            {
                Console.WriteLine("Число делится c остатком при делении на 2");
            }
            else
            { 
                Console.WriteLine ("Число делится без остатка при делении на 2");
            }
