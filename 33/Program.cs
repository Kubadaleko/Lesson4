// 33. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] a = new int[8];


int[] RandomIntArray(int size, int min, int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max);
    return a;
}

void Print(int[] a)
{
    foreach (int el in a)
        System.Console.Write($"{el} ");
}

int[] m = RandomIntArray(8, 0, 2);
Print(m);