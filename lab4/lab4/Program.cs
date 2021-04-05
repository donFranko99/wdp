using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] firstTable = Array.ConvertAll<string, int>(input.Split(" "), int.Parse);
            int secondLength = int.Parse(Console.ReadLine());
            input = Console.ReadLine();
            int[] secondTable = Array.ConvertAll<string, int>(input.Split(" "), int.Parse);

            int counter = 0;
            int[] controlTable = new int[firstLength];

            for (int i = 0; i < firstLength; i++)
            {
                for (int j = 0; j < secondLength; j++)
                {
                    if (firstTable[i] == secondTable[j])
                    {
                        controlTable[counter] = firstTable[i];
                        counter++;
                        continue;
                    }
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{controlTable[i]} ");
            }
        }
    }
}
