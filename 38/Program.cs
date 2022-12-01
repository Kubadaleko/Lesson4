// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] a = new int[123];
int k = 0;
Random rend = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = rend.Next(0, 123);
    if (a[i] > 10 && a[i] < 99) k++;
}

System.Console.WriteLine($"количество элементов из отрезка [10,99] = {k}");
System.Console.Write("[{0}]", String.Join(", ", a));