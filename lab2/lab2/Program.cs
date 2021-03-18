using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            for(int i=0; i<t; i++)
            {
                int sum = 0;
                n = int.Parse(Console.ReadLine());
                string line = Console.ReadLine();
                var tab = line.Split(' ');
                for(int j=0; j<n; j++)
                {
                    sum += int.Parse(tab[j]);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
