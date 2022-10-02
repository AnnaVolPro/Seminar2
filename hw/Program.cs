int Random(int MinValue, int MaxValue)
{
    Random random = new Random();
    return random.Next(MinValue, MaxValue);
}

void ConverBinarSystem(int num)
{
    for (int n = num; n > 0; n = n / 2)
    {
        Console.Write(n % 2);
    }
}
double CoordDistance(int a, int b, int a1, int b1)
{
    return Math.Round(Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2)), 2);
}



void Task2()
{
    //Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
    int num = Random(100, 1000);
    Console.WriteLine(num);
    int hundred = num / 100;
    int tens = (num % 100) / 10;
    int ones = num % 10;
    if ((hundred + tens + ones) % 3 == 0) Console.Write("Кратно");
    else Console.Write("Не кратно");
}

void Task3()
{
    // Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
    int num = Random(100, 1000);
    Console.WriteLine(num);
    if (num / 100 == 7 || (num % 100) / 10 == 7 || num % 10 == 7) Console.WriteLine("В числе еcть цифра 7");
    else Console.WriteLine("Вчисле НЕТ цифры 7");
    if (num / 100 == 4 || (num % 100) / 10 == 4 || num % 10 == 4) Console.WriteLine("В числе еcть цифра 4");
    else Console.WriteLine("Вчисле НЕТ цифры 4");
}

void Task4()
{
    // Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + " ");
    }
}

void Zadacha1()
{
    // На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.

    Console.Write("Введите десятичное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num1=ConverBinarSystem(num);
    
}

// Task2();
// Task3();
// Task4();
Zadacha1();