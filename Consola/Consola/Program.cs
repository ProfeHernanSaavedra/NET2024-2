using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion variables
            int num1 = 1,num2 = 3,num6;
            int suma;
            string nombre = "Maria";
            bool esCSharp = true;
            float num3 = 3.5f;
            decimal num4 = 2.5m;
            string num5 = "14";


            suma = num1 + num2 + (int)num3 + (int)num4 + int.Parse(num5);

            
            Console.WriteLine("Lenguaje C#: " + esCSharp);
            Console.WriteLine("Mi nombre es: " + nombre);

            Console.WriteLine("Ingrese el valor de num6");
            //num6 = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out num6);

            suma += num6; //acumulador ---> suma = suma + num6
            Console.WriteLine("la suma es " + suma);
            //cw + tab + tab
            //Console.WriteLine("Hola mundo");
            Console.ReadLine();

        }
    }
}
