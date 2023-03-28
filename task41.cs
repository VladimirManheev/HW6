// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
array(n);
ReleaseArray(Array);

void array(int n)
{
    for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int ReleaseArray(int[] Array)
{
    int i=0;
    int sum = 0;
    while (i < Array.Length)
{
    if(Array[i]>0)
    sum++;
    i++;
}
    return sum;
}

Console.WriteLine($"[{string.Join(", ", Array)}]");
Console.Write($"Чисел больше нуля: {ReleaseArray(Array)}");
