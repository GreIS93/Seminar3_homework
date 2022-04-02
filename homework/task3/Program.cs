// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число n");

int n = int.Parse(Console.ReadLine());
int sum = 0;
while (Math.Abs(n) > 0)
{
    sum = sum + (n % 10);
    n = n / 10;
}
Console.WriteLine(Math.Abs(sum));