using System;
using System.Collections;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            //creamos el Stack
            Console.Title = "PRECIEUX A. DE LEON OZORIA -- GERSON RODRIGUEZ HERRERA";
            Stack mipila = new Stack();
            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("================== PILAS ===============");
                Console.WriteLine("========================================");
                Console.WriteLine("1-Insertar");
                Console.WriteLine("2-Eliminar");
                Console.WriteLine("3-Eliminar Todo");
                Console.WriteLine("4-Buscar en la Cola");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Seleccione una opcion:");

                //Condicionales
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite valor a insertar a la pila : ");
                    numero = int.Parse(Console.ReadLine());
                    mipila.Push(numero);
                }
                if (opcion == 2)
                {
                    Console.Clear();
                    numero = (int)mipila.Pop();
                    Console.WriteLine("El valor obtenido es: " + numero);
                }
                if (opcion == 3)
                {
                    Console.Clear();
                    mipila.Clear();
                }
                if (opcion == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite valor a encontrar: ");
                    numero = int.Parse(Console.ReadLine());
                    encontrado = mipila.Contains(numero);
                    Console.WriteLine("El encontrado es :" + encontrado);
                }
                Console.WriteLine("La cola tiene {0} elementos", mipila.Count);
                foreach (int n in mipila)
                    Console.Write("  {0}, ", n);
                Console.WriteLine("");
                Console.WriteLine("_____________");
            } while (opcion != 5);
            Console.ReadKey();
        }
    }
}

