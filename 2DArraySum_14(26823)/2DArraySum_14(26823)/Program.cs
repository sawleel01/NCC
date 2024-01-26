using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArraySum_14_26823_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] scores = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(scores[i, j] + " ");
                    sum += Convert.ToInt32(scores[i, j]);
                }
                Console.Write("=" + sum);
                sum = 0;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
