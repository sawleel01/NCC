using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_14_26823_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IA
    {
        int Add(int x, int y);
    }
    public interface IB
    {
        int Sub(int x, int y);
    }
    public class rectangle : IA, IB 
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return (x - y);
        }
    }
}
