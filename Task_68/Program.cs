// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string prompt)
{
    System.Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");

int FunctionAncerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAncerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAncerman(m - 1, FunctionAncerman(m, n - 1));
    return FunctionAncerman(m, n);
}
System.Console.WriteLine($"Вычисление функции Аккермана равно {FunctionAncerman(m, n)}");