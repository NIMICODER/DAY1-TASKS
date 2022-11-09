using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            Console.WriteLine("Pick a book");
            user = Console.ReadLine();
            
            switch (user.ToUpper())
            {
                case "C":
                    Console.WriteLine("c# books");
                    break;
                case "O":
                    Console.WriteLine("NET core books");
                    break;
                case "D":
                    Console.WriteLine("clean coding books");
                    break;
                case "E":
                    Console.WriteLine("EFcore books");
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }
        }
    }
}
