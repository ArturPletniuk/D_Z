//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 % 2;
if(num2 == 0)
{
    Console.WriteLine("Да");  
}
else if (num2 == 1)
{
    Console.WriteLine("Нет");
}
Console.WriteLine("Exit.");
Console.ReadLine();
