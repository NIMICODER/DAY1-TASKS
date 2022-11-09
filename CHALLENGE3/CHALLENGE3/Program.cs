using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
          
                
            Console.WriteLine("Enter your date in this format: (mm/dd/yyyy)");
            string str = Console.ReadLine();
            DateTime dt;
            var ValidDate = DateTime.TryParse(str, out dt);
            if (ValidDate)
            {
                TimeSpan ts = new TimeSpan(7,0,0,0);
                DateTime result = dt.Add(ts);
                Console.WriteLine($"the date one week from today is {result}");
            } else
            {
                Console.WriteLine("Date format is invalid");
            }
        }
    }
}
