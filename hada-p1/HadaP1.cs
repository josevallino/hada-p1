using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta clase contiene métodos para convertir de minutos a segundos y viceversa
    /// </summary>
    class HadaP1
    {
        // Método que convierte de segundos a minutos a partir de un double dado como argumento
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
            {
                return 0;
            }
            return s / 60;
        }
        // Método que convierte de minutos a segundos a partir de un double dado como argumento
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }
    }
}
