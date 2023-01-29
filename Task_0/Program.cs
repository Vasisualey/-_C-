Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); // Из консоли приходит символьный(строковый) тип данных, переводим их int.parce
int sqr = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + sqr +"."); // автоформатирование происходит с помощью shift + alt + F
