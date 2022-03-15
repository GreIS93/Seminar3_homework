Console.WriteLine("Введите число n");

int n = int.Parse(Console.ReadLine());
int i = 0;
int n1 = n;
if (n == 0) i = 1;
while (n>0)
{
    i++;
    n = n / 10;
}
Console.Write("в числе " + n1 + " " + i + " цифр");