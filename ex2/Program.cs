using System;
using System.Collections.Generic;
using System.Linq;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti nr1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti nr2");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti nr3");
            int n3 = int.Parse(Console.ReadLine());

            double media = (double) (n2 + n1 + n3) / 3;

            int ultimaCifra = n1 % 10;

            if (n1 > 0)
            {
                Console.WriteLine("+");
            }
            else if (n1 < 0)
            {
                Console.WriteLine("-");
            }
            else 
            {
                Console.WriteLine("0");
            }


            if (n1 < n2)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n2);
                Console.WriteLine(n1);
            }


            if (n1 > n2)
            {
                // n1 n2
                if (n2 > n3)
                {
                    // n1 n2 n3
                    Console.WriteLine(n1 + " " + n2 + " " + n3);
                }
                else if (n3>n1)
                {
                    // n3 n1 n2 
                    Console.WriteLine(n3 + " " + n1 + " " + n2);
                }
                else
                {
                    Console.WriteLine(n1 + " " + n3 + " " + n2);
                }
            }
            else
            {
                //?? n2 ?? n1 ??
                if (n3 > n2)
                {
                    //n3 n2 ?? n1 ??
                    Console.WriteLine(n3 + " " + n2 + " " + n1);
                }else 
                if (n3 <n2 && n3 > n1)
                {
                    // n2 n3 n1 ??
                    Console.WriteLine(n2 + " " + n3 + " " + n1);
                }
                else
                {
                    // n2  n1 n3
                    Console.WriteLine(n2 + " " + n1 + " " + n3);
                }
            }


            var  myList = new List<int> { n1, n2, n3 };

            myList
                .OrderByDescending(x => x)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            if (n1%2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }

            Console.WriteLine("media aritmetica " + media);
            /*
             * “unu” daca numarul citit este 1
“doi” daca numarul citit este 2
“trei” daca numarul citit este 3
“cinci” daca numarul citit este 5
“opt” daca numarul citit este 8
“neidentificat” pentru orice alt caz
             */

            if (n1 == 1)
            {
                Console.WriteLine("unu");
            }
            else if (n1 == 2 || n1 == 3 || n1==5)
            {
                Console.WriteLine("doi sau trei sau 5");
            }
            else if (n1 == 8)
            {
                Console.WriteLine("opt");
            }
           
        }
    }
}
