// Написать программу вычисления произведения чисел от 1 до N   

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int S = 1;
for (int i = 1; i <= n; i++)
{
    S = S * i;
}
Console.WriteLine(S);
