using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona per = new Persona();
            per.Nombre = "Maria";
            per.Apellido = "Perez";
            per.FechaNacimiento = new DateTime(2002, 11, 21);
            Console.WriteLine("{0} Tienes {1} años",per.Nombre,per.Edad() );
            ///Console.WriteLine(per.Nombre+" Tienes " + per.Edad()+" años");

            Console.WriteLine("Hola " + per.Nombre);

            Persona per2 = new Persona("Armando","Casas");
            per2.FechaNacimiento = new DateTime(2000,10,11);
            Console.WriteLine("Hola " + per2.Nombre);


            Console.ReadLine();

        }
    }
}
