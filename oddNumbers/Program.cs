using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cavab = math(6);
            Console.WriteLine(cavab);
            Console.ReadLine();
        }

        static int math(int a)
        {
            if (a%2==0)
            {
                return a * a;
            }
            else
            {
                return a * a * a;
            }
        }
    }
}
