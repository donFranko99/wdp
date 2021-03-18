using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            long allSum=0;
            while (true)
            {
                long partSum=0;
                string line = Console.ReadLine();
                if(line == null || line == string.Empty)
                {
                    break;
                }
                var tab = line.Split(' ');
                foreach (var number in tab)
                {
                    partSum += long.Parse(number);
                }
                allSum += partSum;
                Console.WriteLine(partSum);
            }
            Console.WriteLine(allSum);
        }
    }
}
