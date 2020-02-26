using static System.Console;
namespace ListaEnlaza
{
    public class lista
    {
        private Nodo cabezaLista;
        private int tamañoLista;

        private int posicion;

        public lista()
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
        public int agregarNodo(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato); //adicionar nodo

            nuevoNodo.siguiente = cabezaLista; // Ir al primer nodo
            cabezaLista = nuevoNodo; //coloca el nuevo nodo de primero
            tamañoLista++;
            return dato;
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

        public Nodo BuscarDatoLista(int posicion)
        {
            Nodo prime = cabezaLista;
            if (prime == null)
            {
                WriteLine("La lista no tiene datos");
            }
            else
            {
                while (prime.siguiente != null || prime.siguiente == null)
                {
                    if (prime.Dato == posicion)
                    {
                        return prime;
                    }
                    else
                    {
                        if (prime.siguiente == null)
                        {
                           return null;
                        }
                        prime = prime.siguiente;
                    }
                }
            }
            return prime;
        }
        public int ObtenerPosicionPorValor(int Dato)
        {
            Nodo prime = cabezaLista;
            if (prime == null)
            {
                WriteLine("La lista no tiene datos");
            }
            else
            {
                while (prime.siguiente != null || prime.siguiente == null)
                {
                    if (prime.Dato == posicion)
                    {
                        return posicion;
                    }
                    else
                    {
                        if (prime.siguiente == null)
                        {
                            WriteLine("Es el ultimo nodo de la lista");
                        }
                        prime = prime.siguiente;
                    }
                }
            } 
            return posicion;
        }
    }
}

