using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Triangulo
    {
        public Coordenada c01 { get; set; }
        public Coordenada c02 { get; set; }
        public Coordenada c03 { get; set; }

        public Triangulo(Coordenada c1, Coordenada c2, Coordenada c3, double a, double b, double c)
        {
            c01 = c1;
            c02 = c2;
            c03 = c3;
        }

        public double distancias(Coordenada coord1, Coordenada coord2)
        {   
            return Math.Sqrt(Math.Pow(coord1.x - coord2.x, 2) + Math.Pow(coord1.y - coord2.y, 2));
        }

        public double perimetro()
        {
            double a = distancias(c01, c02);
            double b = distancias(c02, c03);
            double c = distancias(c03, c01);

            return a + b + c;
        }

        public double area()
        {
            double a = distancias(c01, c02);
            double b = distancias(c02, c03);
            double c = distancias(c03, c01);

            double s = (a + b + c)/2;
            double area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            return area;
        }
    }
}
