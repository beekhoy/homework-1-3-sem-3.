// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int answer = a;

for (int i=1;i<b;i++)
{
    answer = answer * a;
}

Console.WriteLine(answer);


