using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE2
{
    internal class Program
    {

        static int[] CapitalInd(string txt) 
        { 
        List<int> indices = new List<int>();
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsUpper(txt[i])) { 
                    indices.Add(i); 
                }
            }

            int[] indicesArray = indices.ToArray();
            return indicesArray;
        }
        static void Main(string[] args)
        {
            int[] helloindices = CapitalInd("Hello World");
            foreach (int i in helloindices) 
            {
                Console.WriteLine(i);
            }

          /*  Console.WriteLine("Enter your String here");
            string input = Console.ReadLine();
            Console.WriteLine(CapitalInd(input)); */
        }
    }
}
