// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string prompt)
{
    System.Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");

void WriteNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        System.Console.Write($"Сумма элементов равна {sum}");
        return;
    }
    sum = sum + (m++);
    WriteNumbers(m,n,sum);
}

WriteNumbers(m,n,0);