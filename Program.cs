using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1;
            Double n2;
            Double soma;
            Double media;
            Double expoente;
            Double Resultado;
            Console.WriteLine("coloque o primeiro valor:");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("coloque o segundo valor:");
            n2 = Double.Parse(Console.ReadLine());
            expoente = 1.0 / 2;
            soma = n1 * n2;
            media = Math.Pow(soma, expoente);
            Resultado = media;
            Console.WriteLine("A media Geometrica é:");
            Console.WriteLine(media);
        }
    }
}
