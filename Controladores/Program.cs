using Ejercicio5Bucles.Servicios;

namespace Ejercicio5Bucles 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 051123 - dom
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 051123 - dom
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            string respuestaUno="";
            string respuestaDos = "";
            int anyo, mes;
            //Creamos los objetos
            PedirNumInterfaz pni = new PedirNumImplementacion();
            NumDiaInterfaz nd=new NumDiaImplementacion();
            //Se crea el bucle do while
            do 
            {
                //Guardamos los valores pedidos
                mes = nd.mes();
                anyo = nd.anyo();
                //Calculamos si el año es bisiesto o no
                respuestaDos=nd.anyoBisiesto(anyo);

                switch (mes) 
                {
                    case 1: case 3: case 5: case 7:case 8: case 10:case 12:
                        Console.WriteLine("El mes tiene 31 dias");
                        break;
                    case 2:
                        if (respuestaDos == "s")
                        {
                            Console.WriteLine("El mes tiene 29 dias");
                        }
                        else 
                        { 
                            Console.WriteLine("El mes tiene 28 dias");
                        }
                        break;
                    case 4: case 6: case 9: case 11:
                        Console.WriteLine("El mes tiene 30 dias");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no existe");
                        break;
                }
                //Preguntamos si quiere seguir usando la aplicacion
                respuestaUno = pni.preguntaSioNO();
            } while (respuestaUno == "s");
        }
    }
}
