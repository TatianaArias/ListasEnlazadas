using System;
using static System.Console;

namespace ListaEnlaza
{
    class Program
    {
        private Nodo cabezaLista;
        private int tamañoLista;

        public Program()
        {
            cabezaLista = null;
            tamañoLista = 0;
        }
        // Confirmar si la lista esta vacía
        public void listaVacia()
        {
            if (cabezaLista == null)
            {
                WriteLine("La lista esta vacía");
            }
            else
            {
                WriteLine("La lista tiene datos");
            }
        }
        //agregar datos a la lista
        public void agregarNodo(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato); //adicionar nodo
            nuevoNodo.siguiente = cabezaLista; // Ir al primer nodo
            cabezaLista = nuevoNodo; //coloca el nuevo nodo de primero
            tamañoLista++;
        }
        public void mostrarDatosLista()
        {
            Nodo nodoActual = cabezaLista;
            while (nodoActual != null)
            {

                WriteLine("[" + nodoActual.Dato + "]->");//imprimir el dato que esta en el nodo actual
                nodoActual = nodoActual.siguiente;//pasar al siguiente nodo

                /*el nodo actual pasa a ser el siguiente nodo
                 y de esta manera se imprimen todos los datos de nuestra lista*/
            }
        }

        //obtener el tamaño de la lista
        public int obtenertamañoLista()
        {
            return tamañoLista;
        }
        public int ObtenerPosicionPorValor(int dato)
        {

        }

        static void Main(string[] args)
        {
            Program milista = new Program();
            milista.listaVacia();
            ReadLine();

            int numero = 0;
            while (numero != 3)
            {
                WriteLine("MENÚ OPCIONES");
                WriteLine("1. Agregar datos");
                WriteLine("2. Mostrar datos");
                WriteLine("3. Obtener tamaño lista");
                WriteLine("4. Obtener Posición Por Valor");
                numero = Convert.ToInt32(ReadLine());
                switch (numero)
                {
                    case 1:
                        {
                            //necesitamos leer el parametro
                            WriteLine("ingrese el dato");
                            int dato = Convert.ToInt32(ReadLine());
                            milista.agregarNodo(dato);
                        }
                        break;
                    case 2:
                        {
                            milista.mostrarDatosLista();
                        }
                        break;
                    case 3:
                        {
                            WriteLine("tamaño" + milista.obtenertamañoLista());
                           //tamañolista
                        }
                        break;
                    case 4:
                        {
                            WriteLine("ingrese el valor a consultar");
                            int valorAconsultar = Convert.ToInt32(ReadLine());
                            int posicionEncontrada = milista.ObtenerPosicionPorValor(valorAconsultar);
                            WriteLine("A continuacion te muestro la posicion encontrada");
                            WriteLine(posicionEncontrada);

                        }
                        break;
                }
            }
        }
    }
}
