// 37. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

int[] a = new int[8];
Random rend = new Random();
int k = 0;
int j = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = rend.Next(100, 999);
    if (a[i] % 2 == 0)
    {
        System.Console.WriteLine($"{a[i]} четное число");
        k++;
    }
    else
    {
        System.Console.WriteLine($"{a[i]} не четное число");
        j++;
    }
}
System.Console.WriteLine($"Колличество четных чисел в массиве {k}");
System.Console.WriteLine($"Колличество не четных чисел в массиве {j}");
System.Console.Write("[{0}]", String.Join(", ", a));


