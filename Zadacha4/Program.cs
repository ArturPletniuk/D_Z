//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int num_max  = 0;
if(num1 >= num2)
{
    num_max = num1;
}
else if (num1 < num2)
{
    num_max = num2;
}    
if (num_max <= num3)
{
    Console.Write("Max = ");
    Console.WriteLine(num3);
}
else if (num_max > num3)
{
    Console.Write("Max = ");
    Console.WriteLine(num_max);
}
Console.WriteLine("Exit.");
Console.ReadLine();
