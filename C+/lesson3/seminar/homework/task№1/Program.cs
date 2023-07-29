//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

string NumCheck(int x)
{
    if ((x<100000) && (x>9999))
    {
        string x = x.ToString();
        if ((x[0]==x[4])&&(x[1]==x[3]))
        {
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
    else
    {
        Console.WriteLine("Введено не 5-значное число");
    }
    }
return x;
}

Console.WriteLine("Введите 5-значное число, чтобы узнать является ли оно палиндромом.");
int x = int.Parse(Console.ReadLine());

string NumCheck(int x);
