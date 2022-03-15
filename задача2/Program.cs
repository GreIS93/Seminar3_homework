
Console.WriteLine("Введите числа a и b");
Console.Write("Введите a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b = ");
int b = int.Parse(Console.ReadLine());
int n = 1;
for (int i = 1; i <= b; i++)
{
    n = n * a;
}
Console.WriteLine(a + " в степени " + b + " = " + n);
