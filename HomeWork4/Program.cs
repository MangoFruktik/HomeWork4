#region Задание 1

Random r = new Random();

Console.WriteLine("Введите кол-во строк: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int y = int.Parse(Console.ReadLine());

int[,] matrix = new int[x, y];
int sum = 0;
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        matrix[i, j] = r.Next(1, 11);
        sum += matrix[i, j];
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма всех чисел в матрице = {sum} ");
Console.ReadKey();
#endregion

#region Задание 2

Console.WriteLine("Введите длину последовательности: ");
int len = int.Parse(Console.ReadLine());

int[] sequence = new int[len];
for (int i = 0; i < sequence.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} число последовательности");
    int memory = int.Parse(Console.ReadLine());
    sequence[i] = memory;
}
Console.WriteLine("Последовательность:");
for (int i = 0; i < len; i++)
{
    Console.Write($"{sequence[i]} ");
}
Console.ReadKey();

int min = sequence[0];

for (int i = 1; i < sequence.Length; i++)
{
    if (sequence[i] < min)
    {
        min = sequence[i];
    }
}
Console.WriteLine($"\nМинимальное число в массиве {min}");
Console.ReadKey();
#endregion

#region Задание 3

Console.WriteLine("Введите максимальное число диапазона:");
int num = int.Parse(Console.ReadLine());

num = r.Next(num + 1);
bool end = true;
while (end)
{
    Console.WriteLine("Введите загаданное число...");
    int a = int.Parse(Console.ReadLine());
   
    if (num < a)
    {
        Console.WriteLine("Введенное число больше загаданного!");
    }
    else if (num > a)
    {
        Console.WriteLine("Введенное число меньше загаданного!");
    }
    else if (num == a)
    {
        Console.WriteLine("Вы угадали!");
        break;
    }
}

Console.ReadKey();







#endregion