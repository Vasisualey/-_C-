// Задача № 5. Напишите программу, которая на вход принимает одно число (N), а на выходе выводит все целые числа в промежутке от (-N....N)
// 4 -> [-4,-3,-2,-1,0,1,2,3,4]
// 2 -> [-2,-1,0,1,2]
Console.Clear();
Console.WriteLine("Введите Значение: ");
int N = int.Parse(Console.ReadLine());
int start = -N;
while(start <= N)
    {
        Console.Write(start + " ");
        start++;
    }