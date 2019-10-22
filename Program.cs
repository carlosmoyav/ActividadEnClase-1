using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadEnClase.clases;
namespace ActividadEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota nota = new Nota();
            int ban = 0, eleccion = 0;

            Console.WriteLine("Ingrese el nombre del estudiante");
            while (ban == 0)
            {
                nota.Nombre = Console.ReadLine();
                Console.WriteLine("Esta correcto su nombre?\n" + nota.Nombre + "\n" + "Ingrese 1 si desea continuar y escriba 2 si desea reescribirlo");
                eleccion = int.Parse(Console.ReadLine());
                if (eleccion == 1)
                {
                    ban = 1;
                }
            }
            Console.WriteLine("Ingrese la nota de actividad en clase del primer parcial");
            nota.Ac1P =
            float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Ac1P);
            Console.WriteLine("Ingrese la nota de practicas del primer parcial");
            nota.Pr1P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Pr1P);
            Console.WriteLine("Ingrese la nota de trabajo autonomo del primer parcial");
            nota.Ta1P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Ta1P);
            Console.WriteLine("Ingrese la nota de evaluacion final del primer parcial");
            nota.Ef1P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Ef1P);
            Console.WriteLine("Ingrese la nota de actividad en clase del segundo parcial");
            nota.Ac2P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Ac2P);
            Console.WriteLine("Ingrese la nota de practicas del segundo parcial");
            nota.Pr2P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Pr2P);
            Console.WriteLine("Ingrese la nota de trabajo autonomo del segundo parcial");
            nota.Ta2P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Ta2P);
            Console.WriteLine("Ingrese la nota de evaluacion final del segundo parcial");
            nota.Ef2P = float.Parse(Console.ReadLine());
            Console.WriteLine(nota.Ef2P);
            if (nota.Suma < 14)
            {
                Console.WriteLine("Ingrese la nota de recuperacion");
                nota.Recuperacion = float.Parse(Console.ReadLine());
            }
            Console.WriteLine(nota.Recuperacion);
            Console.WriteLine(nota.Suma);
            Console.WriteLine(nota.Suma2);
            Console.WriteLine("Su promedio es: " + nota.Final);
            Console.WriteLine("Usted esta: " + nota.Estado);
            Console.ReadKey();


        }
    }
}
