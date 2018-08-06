using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_las_potencias_de_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\t\tPrograma que calcule las potencias de 2.\n");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Nombre estudiante= Mauricio Mejia Estevez.");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("teléfono estudiante= 31789561xx.");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("correo estudiante= estudiante@gmail.com.");

            Console.WriteLine("---------------------------------------------------\n");
            //Realizamos la declaracion de variables
            int value = 2;
            //declaramos el ciclo for para encontrar las potencia de 2
            for (int power = 0; power <= 10; power++)
                Console.WriteLine("{0}^{1} = {2:N0}",
                                  value, power, (long)Math.Pow(value, power));
            Console.ReadLine();
        }
    }

}