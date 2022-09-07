//-----------------------------Exercise # 19--------------------------------------------------------------
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
// ----------------------------SOLUTION-------------------------------------------------------------------
/*
void palindromeCheck(int num)   // Данное решение не больше чем шутка с целью рассмешить и закрепить результат по выбору цифр из чисел
{
    if (num > 9999)
    {
        if ((num / 10000) == (num % 10) && ((num / 1000 - (num / 10000) * 10) == ((num % 100 - num % 10) / 10)))
        {
            System.Console.WriteLine("PALINDROME");
        }
        else System.Console.WriteLine("NOT A PALINDROME");

    }
    else System.Console.WriteLine("NOT A FIVE SYMBOLS NUMBER");

}
try
{
    System.Console.Write("Введите число = ");
    int num = Convert.ToInt32(Console.ReadLine());
    palindromeCheck(num); // Ниже представленно решение с использованием массивов
}
catch
{
    System.Console.WriteLine("Вводите именно числа");
}
*/
/*
string palindromeCheck(int num)
{
    string result;
    int j = 0;
    string mutable = Convert.ToString(num);
    for (int i = 0; i < mutable.Length / 2; i++)
    {
        if (mutable[i] == mutable[mutable.Length - i - 1]) j++;
    }
    if (j * 2 + 1 == mutable.Length) result = "Число палиндром";
    else result = "Число не палиндром";
    return result;
}
try
{
    System.Console.Write("Введите число = ");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(palindromeCheck(num));
}
catch
{
    System.Console.WriteLine("Введено не число, или число больше, чем может вместить Int32");
}
*/

//-----------------------------Exercise # 21--------------------------------------------------------------
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
// ----------------------------SOLUTION-------------------------------------------------------------------
/*void frstPt(int N) // Неудача с возвратом массива из функции
{
    int[] Pt_one = new int[N];
    for (int i = 0; i < N; i++)
    {
        System.Console.WriteLine("Введите координату первой точки на орте(оси в пространстве)  = ");
        Pt_one[i] = Convert.ToInt32(Console.ReadLine());
    }

}

void scndPt(int N) // Задаем массив координат N-мерной точки №2
{
    int[] Pt_two = new int[N];
    for (int i = 0; i < N; i++)
    {
        System.Console.WriteLine("Введите координату второй точки на орте(оси в пространстве) = ");
        Pt_two[i] = Convert.ToInt32(Console.ReadLine());
    }

}
*/
double EuclidDistance(int N)
{
    // Задаем массив координат N-мерной точки №1
    int[] Pt_one = new int[N];
    for (int i = 0; i < N; i++)
    {
        System.Console.Write("Введите координату первой точки на орте(оси в пространстве)  = ");
        Pt_one[i] = Convert.ToInt32(Console.ReadLine());
    }
    // Задаем массив координат N-мерной точки №2
    int[] Pt_two = new int[N];
    for (int i = 0; i < N; i++)
    {
        System.Console.Write("Введите координату второй точки на орте(оси в пространстве) = ");
        Pt_two[i] = Convert.ToInt32(Console.ReadLine());
    }
    //Находим Евклидово расстояние
    double sum = 0;
    for (int i = 0; i < N; i++)
    {
        sum = sum + Math.Pow((Pt_two[i] - Pt_one[i]), 2);
    }
    sum = Math.Round(Math.Sqrt(sum), 2);
    return sum;
}
try
{
    System.Console.Write("Введите число мерностей = ");
    int N = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(EuclidDistance(N));

}
catch
{
    System.Console.WriteLine("Введено не число, или число больше, чем может вместить Int32");
}
