using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for printing numbers from 0 - 6
            for (int n = 0; n < 6; n++)
            {
                //prevents the no. 3 from being printed
                if (n == 3)
                {
                    continue; //breaks one iteration and continues with next iteration
                }
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
