using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //int  a = int.Parse(napis);
            int suma = a + b +c;
            Console.WriteLine(suma);
            */
            int suma = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == null || line == string.Empty)
                {
                    break;
                } else
                {
                    suma += int.Parse(line);
                }
                Console.WriteLine(suma);
            }
        }
    }
}
