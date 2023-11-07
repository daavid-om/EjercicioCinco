using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal interface PedirNumInterfaz
    {
        /// <summary>
        /// Metodo que pide al usuario el mes 
        /// 051123 - dom
        /// </summary>
        /// <returns></returns>
        public int mes();
        /// <summary>
        /// Metodo que pide al usuario el año 
        /// 051123 - dom
        /// </summary>
        /// <returns></returns>
        public int anyo();
        /// <summary>
        /// Metodo que pide al usuario si quiere volver a utilizar el programa
        /// 071123 - dom
        /// </summary>
        /// <returns></returns>
        public string preguntaSioNO();

    }
}
