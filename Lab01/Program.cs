using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordenada p1 = new Coordenada() { x = 1, y = 2 };
            Coordenada p2 = new Coordenada() { x = 4, y = 6 };
            Coordenada p3 = new Coordenada() { x = 7, y = 2 };

            Triangulo triangulo = new Triangulo(p1, p2, p3);

            //perimetro
            double per = triangulo.perimetro();               

            //area
            double ar = triangulo.area();

            Console.WriteLine("El perímetro es: " + per);
            Console.WriteLine("El área es: " +  ar);

            Console.Read();

        }
    }
}
