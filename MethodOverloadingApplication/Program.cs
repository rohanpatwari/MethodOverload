using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApplication
{
    class Program
    {
        public static void Add(int FN, int LN)
        {
            Console.WriteLine("Sum={0}", FN + LN);
        }
        public static void Add(double FN, double LN)
        {
            Console.WriteLine("Sum={0}", FN + LN);
        }
        public static void Add(int FN, int LN, out int Total)
        {
            Console.WriteLine("Sum={0}", FN + LN);
            Total = FN + LN;
        }
        static void Main(string[] args)
        {
            Add(10,20);
            Add(10.2, 12.5);
            Console.ReadLine();
        }
    }
}
