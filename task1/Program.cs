// Напишите программу которая принимает на вход 2 числа и выдает какое число больше а какое меньше

System.Console.WriteLine("Введите первое число");
int Number1 = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int Number2 = Convert.ToInt16(Console.ReadLine());
if (Number1 > Number2)
{
    System.Console.WriteLine(Number1);
}
else
{
    System.Console.WriteLine(Number2);
}
