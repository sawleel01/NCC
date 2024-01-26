using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab_14_26823_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Digit: ");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Digit: ");
            int b= Convert.ToInt32(Console.ReadLine()); ;
            AddTwoDigit obj = new AddTwoDigit(a, b);
            AddTwoDigit obj1 = new AddTwoDigit(2, 1);

            Console.WriteLine(obj.Add());
            Console.WriteLine(obj1.Add());

            Console.ReadLine();
        }
    }
    public class AddTwoDigit
    {
        int first = 0, second = 0;

        public AddTwoDigit(int x, int y)
        {
            first = x;
            second = y;
        }

        public int Add()
        {
            return first + second;
        }
    }

}
