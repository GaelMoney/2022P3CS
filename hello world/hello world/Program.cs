using System;
using System.Diagnostics;

namespace Functies
{
    class Program
    {
        static void Main(string[] args)
        {

             Program p = new Program();


             Console.WriteLine(p.ShowText());   
         }

         private string ShowText()
         {
             Console.ForegroundColor = ConsoleColor.Green;
             string naam = ("Hello World");

             return naam;

         } 



            /* Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (true)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                Console.Write(timeSpan);

                //thread sleep
                //cls command gebruiken


                //Console.Write(stopwatch.Elapsed.ToString());
                Console.Write('\r');

            } */

        }
    }
}
