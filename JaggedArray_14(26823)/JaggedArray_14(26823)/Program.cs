using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray_14_26823_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[][] scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 86, 67, 88 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    Console.Write(scores[i][j] + " ");
                    sum += Convert.ToInt32(scores[i][j]);
                }
                Console.Write("=" + sum);
                sum = 0;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
