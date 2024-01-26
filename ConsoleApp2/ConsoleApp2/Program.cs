using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //if (str == "2")
            //{
            //    Console.WriteLine("You entered 2");
            //}
            //else if (str == "1")
            //{
            //    Console.WriteLine("You entered 1");
            //}
            //else
            //{
            //    Console.WriteLine("Enter 1 or 2");
            //}

            //switch (str)
            //{
            //    case "1":
            //        Console.WriteLine("You Entered One.");
            //        break;
            //    case "2":
            //        Console.WriteLine("You Entered Two");
            //        break;
            //    default:
            //        Console.WriteLine("Enter 1 or 2");
            //        break;
            //}

            Console.WriteLine("While Loop");
            int i = 0;
            while(i < 0) {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("do While Loop");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j<10);

            Console.WriteLine("For Each Loop.");
            int[] intarr= new int[] {1,2,3,4,5,6,7};
            foreach (var item in intarr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
