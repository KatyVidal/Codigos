using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int gradosC = 0;
        //    double resultado = 0;
        //    string entrada;

        //    entrada = Console.ReadLine(); //lee entrada

        //    double entradaNumerica;

        //    entradaNumerica = Convert.ToDouble(entrada); // convierte a numero

        //    resultado = convertirAFarenheit(entradaNumerica); //llama al metodo


        //    Console.WriteLine(resultado);

        //    Console.ReadKey();

        //}

        //private static double convertirAFarenheit(double gradosC)
        //{
        //    double convertir;
        //    convertir = (9.0 / 5.0 * gradosC) + 32; //si se dividen dos numeros enteros te devuelve un numero entero
        //    return convertir;
        //}

        static void Main(string[] args)
        {
            double resultado = 0;
            double gradosCentigrados;

            gradosCentigrados = Convert.ToDouble(Console.ReadLine()); // convierte a numero
            resultado = (9.0 / 5.0 * gradosCentigrados) + 32;

            Console.WriteLine(resultado);
            Console.ReadKey();

        }

    }
}
