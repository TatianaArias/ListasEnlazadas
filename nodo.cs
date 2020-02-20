namespace ListaEnlaza
{
    public class nodo
    {
        //Declarar una variable para almacenar en muestra lista un entero
        public int Dato;
        //declaramos un puntero que nos sirva de enlace
        public nodo Enlace;
//declaramos un constructor.Nos ayuda a insertar un elemento
        public nodo(int dato, nodo enlace)
        {
            Dato = dato;
            Enlace = enlace;
        }
    }
}