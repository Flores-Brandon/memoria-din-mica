using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoria_dinámica
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arregloDinamico = new int[5]; // Crear un arreglo con capacidad inicial de 5 elementos
            int contador = 0; // Contador para llevar un registro de cuántos elementos se han agregado

            while (true)
            {
                Console.Write("Ingrese un número (o '0' para salir): ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                    break; // Salir del bucle si se ingresa '0'

                if (contador == arregloDinamico.Length)
                {
                    // Si el arreglo está lleno, duplicar su tamaño
                    Array.Resize(ref arregloDinamico, arregloDinamico.Length * 2);
                }

                arregloDinamico[contador] = numero;
                contador++;
            }

            // Mostrar los elementos ingresados
            Console.WriteLine("Elementos ingresados:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(arregloDinamico[i]);
            }

            Console.ReadLine(); // Para que la consola no se cierre inmediatamente
        }
    }
}
      
