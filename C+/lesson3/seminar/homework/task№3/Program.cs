Console.WriteLine("введите число и получите числа в кубе от 1 до введеного числа");

int N = int.Parse(Console.ReadLine());


for (int i = 0; i <= N; i++)
{
    Console.WriteLine(Math.Pow((i), 3));
}