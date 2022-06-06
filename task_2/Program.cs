//2.Показать натуральные числа от 1 до N, N задано. Рекурсия.


Console.WriteLine("N = ");
int number = int.Parse(Console.ReadLine());
void Recursion(int n)
{
    if (n < 1)return;
    {
        Recursion(n - 1);
        Console.Write(n + " ");
    }
}
Recursion(number);
=============================================================


void Recursion(int n, int i)
{
    if (i < n) Console.Write($"{i}, ");
    if (i == n) Console.Write($"{i}");
    if (i > n) return;
    Recursion(n, i + 1);     
    
}

int n = 20;
int i = 1;
Recursion(n, i);
==============================================================

void PrintNumber(int n)
{
    n--;
    if (n == 0) return;
    PrintNumber(n);   
    Console.Write(n + " ");
}

int n = 20;
PrintNumber(n); 
=============================================================

void ShowNumbers(int Numbers)
{
 
    if (Numbers < 1) return;
    ShowNumbers(Numbers - 1);
    Console.Write(Numbers + " ");
}

ShowNumbers(15);
