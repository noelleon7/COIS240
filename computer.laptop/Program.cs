using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computers
{
    class Program
    {
        static void Main(string[] args)
        {
            laptop noellaptop = new laptop();
            Desktop classRoomDesktop = new Desktop();
            Desktop ClassRoomDesktop2 = new Desktop(true);
            Desktop classRoomDesktop3 = new Desktop(false, 300);
            noellaptop.turnOn();
            noellaptop.turnOff();
            Console.ReadLine();

        }
    }
}
