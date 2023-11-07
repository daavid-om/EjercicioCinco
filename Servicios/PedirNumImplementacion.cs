using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal class PedirNumImplementacion : PedirNumInterfaz
    {
        public int anyo()
        {
            int anyo;
            Console.WriteLine("Introduzca el año:");
            anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }

        public int mes()
        {
            int mes;
            Console.WriteLine("Introduzca el mes:");
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        public string preguntaSioNO()
        {
            string contestacion = "";
            Console.WriteLine("¿Quiere volver a utilizar la aplicacion[s=si || n=no]?");
            contestacion = Console.ReadLine();
            return contestacion;
        }
    }
}
