using System;

namespace ListaEnlaza
{
    //creamos clase lista. Procedemos a añadir y mostrar un elemento de la lista
    public class lista
    {
        //declaramos dos variables de tipo nodo que nos ayudara a saber cual es el inicio y el final
        public nodo inicio, fin;

        //creamos un
        public lista()
        {
            inicio = null;
            fin = null;
        }
        //agregar elemennto
        public void agregarelemento(int elemento)
        {
            //creamos un metodo para agregar elentos con parametro
            inicio = new nodo(elemento, inicio);
            if (fin == null)
            {
                fin = inicio;
            }
        }
        // mostrar elemento
        public void mostrar()
        {
            //necesitamos una variable para que nos ayude a recorrer nuestra lista
            nodo recorrer = inicio;
            while (recorrer != null)
            {
                Console.WriteLine("[" + recorrer.Dato + "]");
                Console.WriteLine("");
                recorrer = recorrer.Enlace;
            }
        }
        public lista obtenerindice(int Dato, int n)
        {
            if (inicio == null)
            {
                return null;
            }
            else
            {
                nodo Enlace = inicio;
                int contador = 0;
                while (contador < Dato && Enlace.siguiente != null)
                {
                    Enlace = Enlace.siguiente;
                    contador++;
                }
                if (contador != Dato)
                {
                    return null;
                }else{
                    return Enlace.n;
                }
            }
        }
    }
}


