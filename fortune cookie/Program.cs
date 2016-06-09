using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_cookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(inbeddifier("you will go to Paris"));
            Console.ReadLine();
        }
        static string inbeddifier(string prediction)
        {
            return prediction + " in bed ";
        }

    }
    
}
