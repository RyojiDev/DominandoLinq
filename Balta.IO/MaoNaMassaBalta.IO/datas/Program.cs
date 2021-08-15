using System;
using System.Globalization;

namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;

            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);

            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");

            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", en));
        }
    }
}
