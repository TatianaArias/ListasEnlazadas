using System;
using static System.Console;

namespace ListaEnlaza
{
    class Program
    {
        static void Main(string[] args)
        {
            lista milista = new lista();
            milista.listaVacia();
            milista.agregarNodo(1);
            milista.agregarNodo(2);
            milista.agregarNodo(3);
            milista.agregarNodo(4);
            milista.agregarNodo(5);
            milista.agregarNodo(6);
            WriteLine("Tamaño de la lista: " + milista.obtenertamañoLista() + " datos.");
            milista.listaVacia();
            milista.mostrarDatosLista();
            if (milista.BuscarDatoLista(6) == null)
            {
                WriteLine("La lista no tiene el dato que ha solicitado");
            }
            else
            {
                WriteLine("La lista tiene el dato que ha solicitado");
            }
            WriteLine("ingrese el valor");
            int valorAconsultar = Convert.ToInt32(ReadLine());
            int posicionEncontrada = milista.ObtenerPosicionPorValor(valorAconsultar);
            WriteLine("A continuación te muestro la posicion en la que se encuentra el:");
            WriteLine(posicionEncontrada);
            ReadLine();
        }
    }
}

