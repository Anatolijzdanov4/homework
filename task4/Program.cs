// Напишите программу которая принимает на вход число (N) а на выходе показывает все четные числа.

System.Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int index = -number;
while(index <= number)
{
if((index % 2) == 0)
    System.Console.WriteLine(index + " ");
index = index + 1;
}

