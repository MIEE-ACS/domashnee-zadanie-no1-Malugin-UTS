using System;

namespace hw1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите C");
            int c = int.Parse(Console.ReadLine());
            int buf1 = c;
            int buf2 = b;
            b = a;
            c = buf2;
            a = buf1;
            Console.WriteLine($"A: {a} \n B: {b}\n C: {c}");
        }
    }
}