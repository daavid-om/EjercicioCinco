using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal class NumDiaImplementacion : NumDiaInterfaz
    {
        public string anyoBisiesto(int anyo)
        {
            string respuesta = "";
            //Si el numero es bisiesto lo dividimos entre 4
            //si el resultado es 0 se hacen mas comprobaciones y si no es 0, no es bisiesto
            if (anyo % 4 == 0) 
            {
                //Si lo es, volvemos a comprobar para asegurarnos dividiendo entre 100
                //si el resultado es 0 se hacen mas comprobaciones y si no es 0 es bisiesto
                if (anyo % 100 == 0)
                {
                    //Si lo es, volvemos a comprobar para asegurarnos dividiendo entre 400
                    //si el resultado es 0 es bisiesto y si no lo es no es bisiesto
                    if (anyo % 400 == 0) 
                    {
                        respuesta = "s";
                    }
                    else 
                    {
                        respuesta = "n";
                    }

                } 
                else 
                {
                    respuesta = "s";
                }
            } 
            else 
            {
                respuesta = "n";
            }
         
            return respuesta;
        }
    }
}
