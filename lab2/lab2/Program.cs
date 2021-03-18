using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum = 0;
            var tab = Console.ReadLine().Split(' ');
            a = int.Parse(tab[0]);
            b = int.Parse(tab[1]);
            for(int i=a; i<=b; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
    }
}
