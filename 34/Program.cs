// 34. Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] a = new int[12];

int[] RandomIntArray(int size = 12, int min = -9, int max = 10)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max);
    return a;
}

int SumNeg(int[] a)
{
    int s = 0;
    foreach (int el in a)
        if (el < 0) s = s + el;
    return s;
}

int SumPos(int[] a)
{
    int s = 0;
    foreach (int el in a)
        if (el > 0) s = s + el;
    return s;
}

void Print(int[] a)
{
    foreach (int el in a)
        System.Console.Write($"{el} ");
}

int[] m = RandomIntArray();
Print(m);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных чисел {SumPos(m)}");
System.Console.WriteLine($"Сумма отрицательных чисел {SumNeg(m)}");

