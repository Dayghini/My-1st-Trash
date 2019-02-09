using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying_My_Best_At_It
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            for (int i=0; i<c; i++)
            {
                Console.WriteLine(i);
            }

            int n = int.Parse(Console.ReadLine());
            for (int d = 0; d < n; d--)
            {
                Console.WriteLine(d);
            }
        }
    }
}
