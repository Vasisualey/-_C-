// Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
    {
        Console.Write(number1 + " больше чем " + number2);
    }
if(number1 < number2)
    {
        Console.Write(number2 + " больше чем " + number1);
    }

if(number1 == number2)
    {
        Console.Write("Эти числа равны");
    }