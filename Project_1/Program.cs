int NumberOne(int num, int NumberOfFirstNumbers)
{
    while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
    {
        num /= 10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine());
if (number < 0)
    number *= -1;
if (number > 99)
{
    int x = number % 100;
    int y = NumberOne(number, 2);
    if (x / 10 == y % 10 && x % 10 == y / 10)
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
else if (number > 9)
{
    int x = number % 10;
    int y = NumberOne(number, 1);
}
else
{
    Console.WriteLine("Введите число больше 9");
}
