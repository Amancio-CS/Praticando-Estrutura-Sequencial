using System;
using System.Globalization;

namespace Operadores5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circuito, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circuito = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("triangulo=" + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("circuito=" + circuito.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("trapezio=" + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("quadrado=" + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("retangulo=" + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
