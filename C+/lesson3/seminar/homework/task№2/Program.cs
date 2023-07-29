double Distance3d(int x1,int x2,int y1,int y2,int z1,int z2)
{
    double distance = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
    return distance;
}








Console.WriteLine("Введите данные о двух точках на 3д координатной плоскости, чтоб получить расстояние между ними.");

int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = {Distance3d}");



