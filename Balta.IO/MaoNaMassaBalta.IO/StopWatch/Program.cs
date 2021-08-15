using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i= 2; i < 20; i++)
            {
                shapeArea(i);
            }
            
        }

        static void Menu(){
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");

            var data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1).ToString());

            var time = int.Parse(data.Substring(0, data.Length -1));

            switch(type)
            {
                case 's':
                     _= time; 
                    break;
                case 'm':
                     time = time * 60;
                     break;
                default:
                     System.Environment.Exit(0);
                     break;        
            }
            PreStart(time);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.WriteLine($"atualmente está em: {currentTime}");
                Thread.Sleep(1000);
               
                currentTime++;
            }
            Console.WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
        }

        static int shapeArea(int n)
        {
            int number = 0;
            for (int i = 1; i < 20; i++)
            {

                return (n * n) + ((n - 1) * (n - 1))
            }
            return number;
        }
    }
}
