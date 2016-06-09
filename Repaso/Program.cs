using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
           double alto;
            double ancho;
            double area;

            alto = 5;
            ancho = 10;
            area = add(alto, ancho);
            Console.WriteLine(area);
            Console.ReadLine();

            double r;
            double pi;
            double Area;

            r = 2;
            pi = 3.14;
            Area = pi * (r * r);
            Console.WriteLine(Area);
            Console.ReadLine();


        }

        static double add(double v1, double v2)
        {
            double producto = v1 + v2;
            return producto;
        }
    }
}
