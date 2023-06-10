// Напишите программу которая принимает на вход 3 числа и выдаёт максимальное из этих чисел

System.Console.WriteLine("Введите первое число");
int Number1 = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int Number2 = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int Number3 = Convert.ToInt16(Console.ReadLine());
if(Number1 > Number2 && Number1 > Number3)
{
    System.Console.WriteLine(Number1);
}
else if(Number2 > Number1 && Number2 > Number3)
{
    System.Console.WriteLine(Number2);
}
else if(Number3 > Number1 && Number3 > Number2)
{
    System.Console.WriteLine(Number3);
}