using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i < 95; i++)
            {
                
                for (int j = 1; j <= 8; j++)
                {
                    Console.WriteLine(i - j);
                }
            }
        }
    }
}
