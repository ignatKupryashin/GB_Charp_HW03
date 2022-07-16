//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Task19()
{
    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа проверяет, является ли введённое пятизначное число палиндромом");
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    bool answer = true;
    for (int i = 0; i <= (number.Length / 2); i++)
    {
        if (number[i] != number[number.Length - 1 - i])
        {
            answer = false;
            break;
        };
    }
    if (answer)
    {
        Console.WriteLine("Введёное значение является палиндромом");
    }
    else
    {
        Console.WriteLine("Введёное значение не является палиндромом");
    }
    Console.WriteLine(""); //пустая строка для красоты
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Task21()
{
    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа вычисляет расстояние между двумя точкам ивв 3D пространстве");
    Console.Write("Введите координату x1: ");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y1: ");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z1: ");
    double z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Координата первой точки {x1},{y1},{z1}");

    Console.Write("Введите координату x2: ");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y2: ");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z2: ");
    double z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Координата второй точки {x2},{y2},{z2}");


    double dist = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
    dist = Math.Round(Math.Sqrt((dist + Math.Pow(z1 - z2, 2))), 2);
    Console.WriteLine($"Дистанция между двумя точками составляет {dist}");
    Console.WriteLine(""); //пустая строка для красоты

}
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Task23()
{
    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа выводит таблицу квадратов от введённого числа до 1");
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    n = Math.Abs(n);
    Console.WriteLine($"Введено число {n}.");
    while (n > 0)
    {
        Console.WriteLine(n * n * n);
        n--;
    }
    Console.WriteLine(""); //пустая строка для красоты

}
Task19();
Task21();
Task23();