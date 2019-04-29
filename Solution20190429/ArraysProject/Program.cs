using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[4];
            names[0] = "Qeshem";
            names[1] = "Rustem";
            names[2] = "Ekber";
            names[3] = "Murad";

            foreach (var item in names)
            {
                Console.WriteLine(item);

            }

            int[,] numbers = new int[2, 4];
            numbers[0, 0] = 0;
            numbers[0, 1] = 1;
            numbers[0, 2] = 2;
            numbers[0, 3] = 3;
            numbers[1, 0] = 4;
            numbers[1, 1] = 5;
            numbers[1, 2] = 6;
            numbers[1, 3] = 7;

            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }


            Console.ReadLine();

        }
    }
}
