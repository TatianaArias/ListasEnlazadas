using System;

namespace ListaEnlaza
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear menu opciones
            int numero = 0;
            //instanciar la clase lista
            lista milista = new lista();
            while (numero != 3)
            {
                Console.WriteLine("MENÚ OPCIONES");
                Console.WriteLine("1. Añadir elemento");
                Console.WriteLine("2. mostrar");
                Console.WriteLine("3. salir");
                Console.WriteLine("4. inserte elemento");
                numero = Convert.ToInt32(Console.ReadLine());
                switch (numero)
                {
                    case 1:
                        {
                            //necesitamos leer el parametro
                            Console.WriteLine("ingrese elemento");
                            int elemento = Convert.ToInt32(Console.ReadLine());

                            milista.agregarelemento(elemento);
                        }
                        break;
                    case 2:
                        { milista.mostrar(); }
                        break;
                    case 3:
                        {
                            Console.ReadKey();
                            //ejecutar el programna
                        }
                        break;
                }
            }
        }
    }
}
