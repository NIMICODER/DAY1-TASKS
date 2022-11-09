using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }


            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                {
                    continue;
                }










                Console.WriteLine(j);
            }

        }
    }
}
