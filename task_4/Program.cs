Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("Чётные числа от 1 до " + a);
while (i <= a)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}

