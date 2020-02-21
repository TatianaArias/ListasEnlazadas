using System;
using CoreEscuela.Util;
using static System.Console;

namespace ListaEnlaza
{
    class Program
    {
        static void Main(string[] args)
        {
             var dato = new lista();
            dato.obtenerindice(dato, n);
            //crear menu opciones
            int numero = 0;
            //instanciar la clase lista
            lista milista = new lista();
            while (numero != 3)
            {
                WriteLine("MENÚ OPCIONES");
                WriteLine("1. Añadir elemento");
                .WriteLine("2. mostrar");
               .WriteLine("3. salir");
                WriteLine("4. inserte elemento");
                numero = Convert.ToInt32(ReadLine());
                switch (numero)
                {
                    case 1:
                        {
                            //necesitamos leer el parametro
                            WriteLine("ingrese elemento");
                            int elemento = Convert.ToInt32(Console.ReadLine());

                            milista.agregarelemento(elemento);
                        }
                        break;
                    case 2:
                        { milista.mostrar(); }
                        break;
                    case 3:
                        {
                            ReadKey();
                            //ejecutar el programna
                        }
                        break;
                }
            }

            Printer.WriteTitle("Posisción número");
            WriteLine(new lista().obtenerindice(dato));
        }
    }
}
