using System;

namespace won6vs2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
              paralelipiped dreptunghic, va afisa volumul lui
             */

            Console.WriteLine("introduceti latime");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti latime");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti latime");
            int inaltime = int.Parse(Console.ReadLine());

            int volumulParalelipipedului = latime * inaltime * lungime;

            Console.WriteLine(volumulParalelipipedului);

        }
    }
}
