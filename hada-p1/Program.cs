using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            do
            {
                Console.WriteLine("¿De qué unidad partes? ¿Minutos o segundos? (m o s): ");
                string tipe = Console.ReadLine();
                Console.WriteLine("Dime el número a convertir: ");
                double variable = double.Parse(Console.ReadLine());

                if (tipe.Equals("m"))
                {
                    Console.WriteLine(HadaP1.Minutes2Seconds(variable) + " segundos.");
                }
                else
                {
                    Console.WriteLine(HadaP1.Seconds2Minutes(variable) + " minutos.");
                }

                Console.WriteLine("¿Desea continuar haciendo conversiones? (sí o no): ");
                result = Console.ReadLine();
            }
            while (result.Equals("sí"));
        }
    }
}
