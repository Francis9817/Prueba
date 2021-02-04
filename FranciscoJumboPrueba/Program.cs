using System;
using System.Threading;

namespace FranciscoJumboPrueba
{
    class Program
    {  
          static void Main(string[] args)
            {
            
                Thread hilo1 = new Thread(ConteoDePersonasEnElEDificio);
                Thread hilo2 = new Thread(ConteoDePersonasEnElEDificio);

                Console.WriteLine("hilo1");
                hilo1.Start();

                Console.WriteLine("hilo2");
                hilo2.Start();

                Thread.Sleep(1000);

                Console.WriteLine(" hilo1");
                hilo1.Join();
                Console.WriteLine(" hilo2");
                hilo2.Join();
            }

            static void ConteoDePersonasEnElEDificio()
            {

                var hiloActual = Thread.CurrentThread;

                Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId);


                int totalPersonas = 0;
                for (int i = 1; i <= 96; i++)
                {
                    var numeropersonas = new Random().Next(1, 6);
                    Console.WriteLine("Hilo {0} Departamento {1} Personas {2}", hiloActual.ManagedThreadId, i, numeropersonas);
                    totalPersonas += numeropersonas;

                    Thread.Sleep(150);
                }
                Console.WriteLine("El Edificio tiene: " + totalPersonas+ "personas" );
            }
        }
    }

