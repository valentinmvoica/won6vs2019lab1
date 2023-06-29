using System;

namespace p9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*“unu” daca numarul citit este 1
“doi” daca numarul citit este 2
“trei” daca numarul citit este 3
“cinci” daca numarul citit este 5
“opt” daca numarul citit este 8
“neidentificat” pentru orice alt caz*/
            int n1 = int.Parse(Console.ReadLine());

            switch (n1)
            {
                case 1:
                    Console.WriteLine("unu");
                    break;
                case 2:
                case 3:
                case 5:
                    Console.WriteLine("doi sau trei sau cinci");
                    break;
                default:
                    Console.WriteLine("neidentificat");
                    break;
            }
        }


    }
}
