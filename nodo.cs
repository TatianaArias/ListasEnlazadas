namespace ListaEnlaza {
    public class Nodo {
        //representa el espacio en el nodo donde vamos a almacenar la informacion con nuestros datos
        public int Dato;
        // representa en el nodo la parte que apunta al siguiente nodo de su mismo tipo
        public Nodo siguiente;
        private Nodo cabezaLista;
        private int tamañoLista;
        public int posicion;

        // metodo constructor que recibe un parametro de tipo entero
        public Nodo (int dato) {
            //al atributo dato le asignamos el parametro dato
            Dato = dato;
            siguiente = null;
        }
    }
}