using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE1
{
    internal class Program
    {
        private static string MaskStrng(string txt)
        {
            string maskedtxt = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if(i < txt.Length - 4)
                {
                    maskedtxt += "$";
                } else
                {
                    maskedtxt += txt[i];
                }
            }
            return maskedtxt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String here");
            string input = Console.ReadLine();
            Console.WriteLine(MaskStrng(input));
        }
    }
}
