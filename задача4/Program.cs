Console.WriteLine("Введите число 1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 4");
int n4 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 5");
int n5 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 6");
int n6 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 7");
int n7 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 8");
int n8 = int.Parse(Console.ReadLine());

int[] array = { n1, n2, n3, n4, n5, n6, n7, n8 };
for (int i = 0; i<array.Length; i++)
{
    Console.Write(array[i]+" ");
}