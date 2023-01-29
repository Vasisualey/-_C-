// Напишите программу, которая будет выдавать названия дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Введите день недели: ");
int number1 = int.Parse(Console.ReadLine());
    if(number1 == 1)
        {
            Console.Write("Понедельник");
        }
    if(number1 == 2)
        {
            Console.Write("Вторник");
        }
    if(number1 == 3)
        {
            Console.Write("Среда");
        }
    if(number1 == 4)
        {
            Console.Write("Четверг");
        }
    if(number1 == 5)
        {
            Console.Write("Пятница");
        }
    if(number1 == 6)
        {
            Console.Write("Суббота");
        }
    if(number1 == 7)
        {
            Console.Write("Воскресенье");
        }
    if(number1 > 7)
        {
            Console.Write("Неверно");
        }
    if(number1 < 1)
        {
            Console.Write("Неверно");
        }