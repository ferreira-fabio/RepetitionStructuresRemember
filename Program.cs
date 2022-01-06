using System;
using System.Threading;

namespace StopWatchForMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {

            System.Console.WriteLine("Digite uma das opções Abaixo: ");
            System.Console.WriteLine("0 - Sair ");
            System.Console.WriteLine("1 - Cronômetro ");
            System.Console.WriteLine("2 - Temporizador ");
            char option = char.Parse(Console.ReadLine());

            if (option == '1')
                Cronometer();
            if (option == '2')
                StopWatch();
            if (option == '0')
            {
                Thread.Sleep(800);
                System.Console.WriteLine("Goodbye");
                Thread.Sleep(800);


                System.Environment.Exit(0);
            }

        }

        static void Loading()
        {

            for (int i = 0; i <= 2; i++)
            {
                Console.Clear();

                System.Console.Write(".");
                Thread.Sleep(500);
                Console.Clear();
                System.Console.Write("..");
                Thread.Sleep(500);
                Console.Clear();
                System.Console.Write("...");
                Thread.Sleep(500);
                Console.Clear();
                System.Console.Write("....");
                Thread.Sleep(500);
                Console.Clear();
                System.Console.Write(".....");

            }




        }
        static void Cronometer()
        {
            Loading();
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("Digite o tempo que deseja em segundos para o fim do cronômetro: ");
            int time = int.Parse(Console.ReadLine());
            int init = 0;

            Thread.Sleep(800);
            while (init <= time)
            {


                Console.Clear();
                System.Console.WriteLine(init);
                Thread.Sleep(1000);
                init++;

            }

            System.Console.WriteLine("Finished...");
            Thread.Sleep(1500);

            //Loading();
            Menu();




        }
        static void StopWatch()
        {
            Loading();
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("Digite o tempo que deseja em contagem regressiva: ");
            int time = int.Parse(Console.ReadLine());
            int init = 0;
            for (init = 0; time >= init; time--)
            {

                Console.Clear();
                System.Console.WriteLine(time);
                Thread.Sleep(1000);


            }

            System.Console.WriteLine("Finished...");
            Thread.Sleep(1500);
            Loading();
            Menu();


        }
    }
}
