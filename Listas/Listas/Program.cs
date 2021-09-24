using System;
using System.Collections;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args) 
        {
            int opcion = 0;
            int numero = 0;
            int indice = 0;
            bool encontrado = false;

            //creamos el Queue
            Console.Title = "PRECIEUX A. DE LEON OZORIA -- GERSON RODRIGUEZ HERRERA";
            List<int> milista = new List<int>();
            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("================== Listas ===============");
                Console.WriteLine("========================================");
                Console.WriteLine("1-Insertar");
                Console.WriteLine("2-Eliminar");
                Console.WriteLine("3-Eliminar Todo");
                Console.WriteLine("4-Buscar en la Lista");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Seleccione una opcion:");

                //Condicionales
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite valor a insertar a lista : ");
                    numero = int.Parse(Console.ReadLine());
                    milista.Add(numero);
                }
                if (opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite la posicion a eliminar");
                    indice = int.Parse(Console.ReadLine());
                    indice = indice - 1;
                    milista.RemoveAt(indice);
                    Console.WriteLine("El valor obtenido es: " + numero);
                }
                if (opcion == 3)
                {
                    Console.Clear();
                    milista.Clear();
                }
                if (opcion == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite valor a encontrar: ");
                    numero = int.Parse(Console.ReadLine());
                    encontrado = milista.Contains(numero);
                    Console.WriteLine("El encontrado es :" + encontrado);
                }
                Console.WriteLine("La lista tiene {0} elementos", milista.Count);
                foreach (int n in milista)
                    Console.Write("  {0}, ", n);
                Console.WriteLine("");
                Console.WriteLine("_____________");
            } while (opcion != 5);
            Console.ReadKey();
        }
    }
}
    

