using System;
using static System.Console;

namespace ListaEnlaza {
    class Program {

        static void Main (string[] args) {
            Lista milista = new Lista ();
            milista.listaVacia ();
            ReadLine ();

            int numero = 0;
            while (numero != 4) {
                WriteLine ("MENÚ OPCIONES");
                WriteLine ("1. Agregar datos");
                WriteLine ("2. Mostrar datos");
                WriteLine ("3. Obtener tamaño lista");
                WriteLine ("4. Obtener Posición Por Valor");
                numero = Convert.ToInt32 (ReadLine ());
                switch (numero) {
                    case 1:
                        {
                            //necesitamos leer el parametro
                            WriteLine ("ingrese el dato");
                            int dato = Convert.ToInt32 (ReadLine ());
                            milista.agregarNodo (dato);
                        }
                        break;
                    case 2:
                        {
                            milista.mostrarDatosLista ();
                        }
                        break;
                    case 3:
                        {
                            WriteLine ("tamaño" + " " + milista.obtenertamañoLista ());
                            //tamaño de la lista
                        }
                        break;
                    case 4:
                        {
                            WriteLine ("ingrese el valor a consultar");
                            int valorAconsultar = Convert.ToInt32 (ReadLine ());
                            int posicionEncontrada = milista.ObtenerPosicionPorValor (valorAconsultar);
                            WriteLine ("A continuacion te muestro la posicion encontrada");
                            WriteLine (posicionEncontrada);
                        }
                        break;
                }
            }
        }
    }
}