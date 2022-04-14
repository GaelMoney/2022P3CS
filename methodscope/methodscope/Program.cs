using System;

namespace methodscope
{
    class Program
    {
        private static string scope8Var;
        private static string scope12Var;
        private static string scope17Var;
 
        static void Main(string[] args)
        {
            Gael();
            Console.WriteLine(Gael());

            if(true)
            {
                //Scope Line 8: If Statement & Alles er buiten
                 scope8Var = "8";

                if(true)
                {
                    //Scope Line 12: If Statement & Alles er buiten
                     scope12Var = "12";
                }

                if(true)
                {
                    //Scope Line 17: If Statement & Alles er buiten
                     scope17Var = "17";
                }

                Console.WriteLine("This was set in scope line 8: " + scope8Var);
                Console.WriteLine("This was set in scope line 12: " + scope12Var);
                Console.WriteLine("This was set in scope line 17: " + scope17Var);
            }
        }
        //toegankelijkheid, static of niet, return type, functie naam (argumenten) {scope}
        public static int Gael()
        {
            //for(variabel == een getal (het beginpunt); voorwaarde (hoever moet die doorgaan); brekening(+ of - 1)){scope}
            for (int i = 0; i < 3; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine("Ik hou soms van kaas");
                }
            }  //ja
            return 1; 
        }

    }
    
}
