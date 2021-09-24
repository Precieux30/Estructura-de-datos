using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            //creamos el Queue
            Console.Title = "PRECIEUX A. DE LEON OZORIA -- GERSON RODRIGUEZ HERRERA";
            Queue mifila = new Queue();
            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("================== COLAS ===============");
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
                    Console.WriteLine("Digite valor a insertar a cola : ");
                    numero = int.Parse(Console.ReadLine());
                    mifila.Enqueue(numero);
                }
                if (opcion == 2)
                {
                    Console.Clear();
                    numero = (int)mifila.Dequeue();
                    Console.WriteLine("El valor obtenido es: " + numero);
                }
                if (opcion == 3)
                {
                    Console.Clear();
                    mifila.Clear();
                }
                if (opcion == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite valor a encontrar: ");
                    numero = int.Parse(Console.ReadLine());
                    encontrado = mifila.Contains(numero);
                    Console.WriteLine("El encontrado es :" + encontrado);
                }
                Console.WriteLine("La cola tiene {0} elementos", mifila.Count);
                foreach (int n in mifila)
                    Console.Write("  {0}, ", n);
                Console.WriteLine("");
                Console.WriteLine("_____________");
            } while (opcion != 5);
        }
    }
}
