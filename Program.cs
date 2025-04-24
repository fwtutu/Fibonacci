using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("請輸入第 N 個費式數列項目: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"第 {n} 項費式數列值為: {Fibonacci(n)}");
    }
}
