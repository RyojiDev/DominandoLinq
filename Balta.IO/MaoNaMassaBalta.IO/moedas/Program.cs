using System;
using System.Globalization;

namespace moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = 10.25;
            Console.WriteLine(valor.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}
