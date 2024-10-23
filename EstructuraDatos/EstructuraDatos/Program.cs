using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] dias = new string[5];
            string [] dias = {"lunes","martes","miercoles","jueves","viernes"};
            Console.WriteLine(dias[2]);

            //for+tab+tab
            Console.WriteLine("\nRecorrido con for");
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }

            //fore+tab+tab
            Console.WriteLine("\nRecorrido con for each");
            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }

            //matrices

            int[,] sala = new int[8, 10];
            Random rand = new Random();
            Console.WriteLine("matriz de {0} x {1}",sala.GetLength(0),sala.GetLength(1));
            Console.WriteLine("La matriz en la posicion 0,0 es: ",sala[0, 0]);

            Console.WriteLine("\nRecorrido con for");
            for (int f = 0; f < sala.GetLength(0); f++)
            {
                for (int c = 0; c < sala.GetLength(1); c++)
                {
                    sala[f, c] = rand.Next(0, 2);
                    Console.Write(sala[f,c] + " ");
                }
                Console.WriteLine("");
            }

            //listas

            Console.WriteLine("\nListas:");
            List<string> colores = new List<string>();
            colores.Add("rojo");
            colores.Add("verde");
            colores.Add("blanco");
            colores.Add("negro");

            Console.WriteLine("Primer elemento: " + colores[0]);
            Console.WriteLine("\nRecorrido con for each");

            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Add("Amarillo");

            Console.WriteLine("\nRecorrido con for each");

            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Insert(0,"rosado");

            Console.WriteLine("\nRecorrido con for each");

            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Total elementos en la lista "+colores.Count);
            

            Console.ReadLine();

        }
    }
}
