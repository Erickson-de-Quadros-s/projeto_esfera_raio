using System;
using System.Globalization;

namespace projeto_esfera_raio
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio!");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("A Circunferencia eh \n" + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("O Volume eh \n" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de PI eh \n" + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }

}
