//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
while(num1 != num)    
{
    num1 += 1;
    int num2 = num1 % 2;
    if (num2 == 0)
        Console.WriteLine(num1);
}
Console.Write("Exit.");
Console.ReadLine();
