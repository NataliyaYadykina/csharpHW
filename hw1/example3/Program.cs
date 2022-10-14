// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int remains = num % 2;

if(remains == 0) Console.WriteLine($"Число {num} является четным."); 
else Console.WriteLine($"Число {num} не является четным."); 
