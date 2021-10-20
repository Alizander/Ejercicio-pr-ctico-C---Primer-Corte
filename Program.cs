using System;

namespace Primer_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 6;
            byte b = 9;
            byte c = 4;

            //aacb
            Console.WriteLine($"Primera Combinación: {a}{a}{c}{b}");
            Console.WriteLine("----");

            //bca
            Console.WriteLine($"Segunda Combinación: {b}{c}{a}");
            Console.WriteLine("----");

            //bcbc
            Console.WriteLine($"Tercera Combinación: {b}{c}{b}{c}");

            /*Irvin Sánchez
            C.I.: 28232012
            Carrera: Ing. en Información
            */
        }
    }
}
