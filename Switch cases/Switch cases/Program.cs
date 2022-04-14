using System;

namespace Switch_cases
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            for(int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Case 0");
                        break;
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("This is default case");
                        break;

                }
            }
        }
    }
}
