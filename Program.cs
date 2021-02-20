using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad=0;
            char sexo;
            float pulsaciones=0.0f;
            Console.WriteLine("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite su edad: ");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite su sexo: M/F");
            sexo = Convert.ToChar(Console.ReadLine());

            if (sexo =='m' || sexo =='M')
            {
                pulsaciones = (210 - edad) / 10;
                Console.WriteLine("usted es sexo Masculino.");
                Console.WriteLine($"sus pulsaciones son: {pulsaciones}");
            }
            if (sexo == 'f' || sexo == 'F')
            {
                pulsaciones = (220 - edad) / 10;
                Console.WriteLine("usted es sexo Femenino.");
                Console.WriteLine($"sus pulsaciones son: {pulsaciones}");
            }

            Console.ReadKey();
        }
    }
}
