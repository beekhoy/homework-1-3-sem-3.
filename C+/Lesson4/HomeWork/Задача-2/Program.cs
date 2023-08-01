// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int N)
{
    string sum = N.ToString();
    int answer = 0;
    for (int i=0; i < sum.Length; i++)
    {
        answer = answer + sum[i];
        Console.WriteLine(sum[i]);
    }
    return answer;
}

Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(N));