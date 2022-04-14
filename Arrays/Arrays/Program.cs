using System;

namespace Arrays
{   

    class Program
    {
        static void Main(string[] args)
        {
            int getal = 10;

            int[] getallen = { getal, 20, 30, 40, 50, 60 };
            int antwoord = 0;

            foreach (int eenGetal in getallen) 
            {
                antwoord = antwoord + eenGetal;
                Console.WriteLine("De variabel antwoord = "+antwoord + "De variabel eenGEtal = "+ eenGetal);
            }

            //for(een integer die bijhoud waar in de array die is; een voorwaarde tot hoever hij door moet gaan; een berekening met welke stappen hij moet neme){}

        }
    }
}
