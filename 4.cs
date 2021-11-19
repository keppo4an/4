using System;

namespace vsvode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            ulong p = ulong.Parse(Console.ReadLine());
            ulong i = p;
            ulong f = 1;
            do
            {
                f*=i;
                --i;
            }
            while (i > 1);
            Console.WriteLine($"{p}! = {f}");
        }
    }
}
